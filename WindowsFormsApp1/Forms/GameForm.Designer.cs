namespace WindowsFormsApp1.Forms
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newGameButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(13, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newGameButton.Location = new System.Drawing.Point(68, 26);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(113, 25);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(260, 31);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(113, 25);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "0";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 530);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(449, 550);
            this.Name = "GameForm";
            this.Text = "Сапёр";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label timerLabel;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Timer timer;
    }
}