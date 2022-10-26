using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = loginField.Text;
            var password = passwordField.Text;

            var user = Database.GetUser(login, password);

            if (user != null)
            {
                var homeForm = new HomeForm(user);
                homeForm.Location = Location;
                homeForm.StartPosition = FormStartPosition.Manual;
                homeForm.FormClosing += delegate { Close(); };
                homeForm.Show();
                Hide();
            }
            else
            {
                errorLabel.Text = "Не удалось войти";
            }
        }
    }
}