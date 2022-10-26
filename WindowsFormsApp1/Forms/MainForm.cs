using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Location = Location;
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.FormClosing += delegate { Show(); };
            loginForm.Show();
            Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.Location = Location;
            registrationForm.StartPosition = FormStartPosition.Manual;
            registrationForm.FormClosing += delegate { Show(); };
            registrationForm.Show();
            Hide();
        }
    }
}