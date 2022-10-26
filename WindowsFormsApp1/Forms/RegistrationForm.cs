using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var login = loginField.Text;
            var name = nameField.Text;
            var email = emailField.Text;
            var password = passwordField.Text;
            var repeatPassword = repeatPasswordField.Text;

            if (User.CheckLogin(login) && 
                User.CheckName(name) && 
                User.CheckEmail(email) && 
                User.CheckPassword(password, repeatPassword))
            {
                var user = new User
                {
                    Login = login,
                    Name = name,
                    Email = email,
                    Password = password,
                };
            
                Database.AddUser(user);
                
                var homeForm = new HomeForm(user);
                homeForm.Location = Location;
                homeForm.StartPosition = FormStartPosition.Manual;
                homeForm.FormClosing += delegate { Close(); };
                homeForm.Show();
                Hide();
            }
            else
            {
                errorLabel.Text = "Что-то пошло не так, попробуйте снова";
            }
        }
    }
}