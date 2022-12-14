using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class FieldController : IDisposable
    {
        private Control _container;
        private Field _field;
        private Label _label;

        public event Action GameWon;
        public event Action GameLost; 

        //Вычисляет размер ячейки
        public int CellSize
        {
            get
            {
                var w = _container.Width;
                var h = _container.Height;
                var cellW = (int)(w / _field.Cols);
                var cellH = (int)(h / _field.Rows);
                return Math.Min(cellW, cellH);
            }
        }

        public FieldController(Control container, Field f, Label label)
        {
            _field = f;
            _container = container;
            _label = label;
            Create();
        }

        private void Create()
        {
            Rectangle r = GetRectangle();
            for (int i = 0; i < _field.Rows; i++)
            {
                for (int j = 0; j < _field.Cols; j++)
                {
                    var cellView = new CellView(_field, i, j);
                    cellView.Location = new Point(r.X + j * CellSize, r.Y + i * CellSize);
                    cellView.Size = new Size(CellSize, CellSize);
                    cellView.StateChanged += CellViewOnStateChanged;
                    cellView.Start += CellViewOnStart;
                    cellView.Name = $"c{i},{j}";
                    _container.Controls.Add(cellView);
                }
            }
        }

        public void ResizeField()
        {
            Rectangle r = GetRectangle();
            for (int i = 0; i < _field.Rows; i++)
            {
                for (int j = 0; j < _field.Cols; j++)
                {
                    if (_container.Controls[i * _field.Cols + j] is CellView cv)
                    {
                        cv.Location = new Point(r.X + j * CellSize, r.Y + i * CellSize);
                        cv.Size = new Size(CellSize, CellSize);
                        cv.Invalidate();
                    }
                }
            }
        }

        private void CellViewOnStart()
        {
            _field.Mine();
        }

        private void CellViewOnStateChanged(CellView cell)
        {
            if (cell.State == StateType.Opened)
            {
                if (_field[cell.Row, cell.Col])
                {
                    foreach (Control containerControl in _container.Controls)
                    {
                        if (containerControl is CellView cv)
                        {
                            cv.State = StateType.Opened;
                        }
                    }
                    
                    GameLost();
                    _label.Text = "Поражение";
                } 
                else
                {
                    if (_field.GetNeighboursMineCount(cell.Row, cell.Col) == 0)
                    {
                        var nbrs = GetNeighbours(cell);
                        nbrs.ForEach(c => c.State = StateType.Opened);
                    }
                }
            }

            var isGameWon = true;
            
            //Проверка, выиграна ли игра
            foreach (var control in _container.Controls)
            {
                if (control is CellView cellView && 
                    !(cellView.State == StateType.Marked && _field[cellView.Row, cellView.Col] ||
                      cellView.State is StateType.Opened && !_field[cellView.Row, cellView.Col]))
                {
                    isGameWon = false;
                    break;
                }
            }

            if (isGameWon)
            {
                GameWon();
                _label.Text = "Победа";
            } 
        }

        private Rectangle GetRectangle()
        {
            var r = new Rectangle();
            r.Width = CellSize * _field.Cols;
            r.Height = CellSize * _field.Rows;
            r.X = (_container.Width - r.Width) / 2;
            r.Y = (_container.Height - r.Height) / 2;
            return r;
        }

        private List<CellView> GetNeighbours(CellView cell)
        {
            var neighbours = new List<CellView>();
            for (int i = cell.Row - 1; i <= cell.Row + 1; i++)
            {
                if (i < 0 || i >= _field.Rows) continue;
                for (int j = cell.Col - 1; j <= cell.Col + 1; j++)
                {
                    if (j < 0 || j >= _field.Cols) continue;
                    if (i == cell.Row && j == cell.Col) continue;
                    var ctrl = _container.Controls.Find($"c{i},{j}", false)[0];
                    if (ctrl is CellView cvCtrl)
                    {
                        neighbours.Add(cvCtrl);
                    }
                }
            }
            return neighbours;
        }

        //Удаляет всё, чтобы начать новую игру
        public void Dispose()
        {
            int cc = _container.Controls.Count;
            for (int i = 0; i < cc; i++)
                _container.Controls.RemoveAt(0);
        }
    }
}
