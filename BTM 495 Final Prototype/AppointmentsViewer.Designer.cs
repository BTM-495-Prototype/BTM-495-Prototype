namespace BTM_495_Final_Prototype
{
    partial class AppointmentsViewer
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
            WelcomeLabel = new Label();
            panel1 = new Panel();
            exitButton = new Button();
            appBox = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(205, 21);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Scheduled appointments:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(appBox);
            panel1.Location = new Point(12, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 387);
            panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(306, 330);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(159, 34);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit Viewer";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // appBox
            // 
            appBox.Location = new Point(19, 17);
            appBox.Name = "appBox";
            appBox.Size = new Size(738, 289);
            appBox.TabIndex = 0;
            appBox.Text = "";
            // 
            // AppointmentsViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(WelcomeLabel);
            Name = "AppointmentsViewer";
            Text = "Appointments Viewer";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Panel panel1;
        private Button exitButton;
        private RichTextBox appBox;
    }
}