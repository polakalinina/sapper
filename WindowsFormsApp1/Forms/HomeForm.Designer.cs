using System.ComponentModel;

namespace WindowsFormsApp1.Forms
{
    partial class HomeForm
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.recordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.helloLabel.Location = new System.Drawing.Point(29, 22);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(271, 40);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(55, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Почта";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(55, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Имя";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(64, 358);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(204, 48);
            this.errorLabel.TabIndex = 19;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.saveButton.Location = new System.Drawing.Point(106, 303);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 38);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(55, 265);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(226, 20);
            this.emailField.TabIndex = 15;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(55, 219);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(226, 20);
            this.nameField.TabIndex = 14;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.playButton.Location = new System.Drawing.Point(106, 75);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(128, 38);
            this.playButton.TabIndex = 23;
            this.playButton.Text = "Играть";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // recordLabel
            // 
            this.recordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.recordLabel.Location = new System.Drawing.Point(55, 133);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(225, 41);
            this.recordLabel.TabIndex = 24;
            this.recordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 431);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.helloLabel);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label recordLabel;

        private System.Windows.Forms.Button playButton;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox nameField;

        private System.Windows.Forms.Label helloLabel;

        #endregion
    }
}