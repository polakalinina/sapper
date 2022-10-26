using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class HomeForm : Form
    {
        private readonly User _user;
        
        public HomeForm(User user)
        {
            _user = user;
            
            InitializeComponent();
            
            helloLabel.Text = $"Привет, { _user.Name}";
            recordLabel.Text = $"Рекорд: {_user.Record}";
            
            nameField.DataBindings.Add("Text", _user, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            emailField.DataBindings.Add("Text", _user, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (User.CheckName(_user.Name) &&
                User.CheckEmail(_user.Email))
            {
                helloLabel.Text = $"Привет, { _user.Name}";
                Database.Save(_user);
                errorLabel.Text = "";
            }
            else
            {
                errorLabel.Text = "Не удалось изменить информацию";
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            var gameForm = new GameForm(_user);
            gameForm.Location = Location;
            gameForm.StartPosition = FormStartPosition.Manual;
            gameForm.FormClosing += delegate { Show(); };
            gameForm.Show();
            Hide();
        }
    }
}