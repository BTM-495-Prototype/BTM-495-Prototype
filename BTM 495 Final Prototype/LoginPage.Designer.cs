namespace BTM_495_Final_Prototype
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            BackgroundPanel = new Panel();
            faqLink = new LinkLabel();
            SeeCheck = new CheckBox();
            RegisterLable = new LinkLabel();
            LoginButton = new Button();
            PasswordBox = new TextBox();
            EmailBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            WelcomeLabel = new Label();
            panel1 = new Panel();
            BackgroundPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.BackColor = SystemColors.ActiveCaption;
            BackgroundPanel.BorderStyle = BorderStyle.FixedSingle;
            BackgroundPanel.Controls.Add(faqLink);
            BackgroundPanel.Controls.Add(SeeCheck);
            BackgroundPanel.Controls.Add(RegisterLable);
            BackgroundPanel.Controls.Add(LoginButton);
            BackgroundPanel.Controls.Add(PasswordBox);
            BackgroundPanel.Controls.Add(EmailBox);
            BackgroundPanel.Controls.Add(label3);
            BackgroundPanel.Controls.Add(label2);
            BackgroundPanel.Controls.Add(label1);
            BackgroundPanel.Location = new Point(156, 69);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.Size = new Size(472, 223);
            BackgroundPanel.TabIndex = 3;
            // 
            // faqLink
            // 
            faqLink.AutoSize = true;
            faqLink.Location = new Point(251, 172);
            faqLink.Name = "faqLink";
            faqLink.Size = new Size(105, 15);
            faqLink.TabIndex = 8;
            faqLink.TabStop = true;
            faqLink.Text = "I need help (F.A.Q)";
            faqLink.LinkClicked += faqLink_LinkClicked;
            // 
            // SeeCheck
            // 
            SeeCheck.AutoSize = true;
            SeeCheck.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            SeeCheck.Location = new Point(426, 110);
            SeeCheck.Name = "SeeCheck";
            SeeCheck.Size = new Size(46, 21);
            SeeCheck.TabIndex = 7;
            SeeCheck.Text = "👁";
            SeeCheck.UseVisualStyleBackColor = true;
            SeeCheck.CheckedChanged += SeeCheck_CheckedChanged;
            // 
            // RegisterLable
            // 
            RegisterLable.AutoSize = true;
            RegisterLable.Location = new Point(251, 148);
            RegisterLable.Name = "RegisterLable";
            RegisterLable.Size = new Size(181, 15);
            RegisterLable.TabIndex = 6;
            RegisterLable.TabStop = true;
            RegisterLable.Text = "I don't have an account (register)";
            RegisterLable.LinkClicked += RegisterLable_LinkClicked;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(141, 148);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(104, 39);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(141, 108);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(282, 23);
            PasswordBox.TabIndex = 4;
            PasswordBox.Text = "*****************";
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(141, 64);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(282, 23);
            EmailBox.TabIndex = 2;
            EmailBox.Text = "Email@Domain.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(28, 109);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(28, 65);
            label2.Name = "label2";
            label2.Size = new Size(107, 19);
            label2.TabIndex = 2;
            label2.Text = "Email Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 21);
            label1.TabIndex = 2;
            label1.Text = "To access the system, please login:";
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            WelcomeLabel.Location = new Point(5, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(392, 25);
            WelcomeLabel.TabIndex = 2;
            WelcomeLabel.Text = "Welcome to the online pharmacy platform!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BackgroundPanel);
            panel1.Location = new Point(5, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 408);
            panel1.TabIndex = 4;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WelcomeLabel);
            Controls.Add(panel1);
            Name = "LoginPage";
            Text = "Online Pharmacy Platform";
            BackgroundPanel.ResumeLayout(false);
            BackgroundPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BackgroundPanel;
        private CheckBox SeeCheck;
        private LinkLabel RegisterLable;
        private Button LoginButton;
        private TextBox PasswordBox;
        private TextBox EmailBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label WelcomeLabel;
        private LinkLabel faqLink;
        private Panel panel1;
    }
}