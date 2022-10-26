using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class GameForm : Form
    {
        private readonly User _user;
        
        private Field _f;
        private FieldController _fController;

        private decimal _time = 0;
        
        public GameForm(User user)
        {
            _user = user;
            
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            if (_fController != null)
            {
                _fController.Dispose();
            }
            _f = new Field(10, 15);
            _fController = new FieldController(panel1, _f, timerLabel);
            
            _fController.GameWon += () =>
            {
                timer.Stop();
                if (_user.Record == 0 || _time < _user.Record)
                {
                    _user.Record = _time;
                    Database.Save(_user);
                }
            };
            _fController.GameLost += () =>
            {
                timer.Stop();
            };
            
            _time = 0;
            timerLabel.Text = _time.ToString();
            timer.Start();
        }
        
        private void newGameButton_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            _fController?.ResizeField();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            _time += (decimal) 0.01;
            timerLabel.Text = _time.ToString();
        }
    }
}