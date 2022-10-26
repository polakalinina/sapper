using System.ComponentModel;

namespace WindowsFormsApp1.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.repeatPasswordField = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(75, 103);
            this.loginField.Margin = new System.Windows.Forms.Padding(4);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(300, 22);
            this.loginField.TabIndex = 0;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(75, 162);
            this.nameField.Margin = new System.Windows.Forms.Padding(4);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(300, 22);
            this.nameField.TabIndex = 1;
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(75, 219);
            this.emailField.Margin = new System.Windows.Forms.Padding(4);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(300, 22);
            this.emailField.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(75, 278);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '●';
            this.passwordField.Size = new System.Drawing.Size(300, 22);
            this.passwordField.TabIndex = 3;
            // 
            // repeatPasswordField
            // 
            this.repeatPasswordField.Location = new System.Drawing.Point(75, 342);
            this.repeatPasswordField.Margin = new System.Windows.Forms.Padding(4);
            this.repeatPasswordField.Name = "repeatPasswordField";
            this.repeatPasswordField.PasswordChar = '●';
            this.repeatPasswordField.Size = new System.Drawing.Size(300, 22);
            this.repeatPasswordField.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(133, 390);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(171, 47);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Отправить";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(91, 457);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(272, 59);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Почта";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(75, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(75, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Повторите пароль";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 530);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.repeatPasswordField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.loginField);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;

        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button registerButton;

        private System.Windows.Forms.TextBox repeatPasswordField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passwordField;

        #endregion
    }
}