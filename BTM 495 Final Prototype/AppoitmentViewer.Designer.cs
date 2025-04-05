namespace BTM_495_Final_Prototype
{
    partial class AppoitmentViewer
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
            infoBox = new RichTextBox();
            appBox = new ComboBox();
            selectionLabel = new Label();
            button1 = new Button();
            cancelButton = new Button();
            appTip = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(190, 21);
            WelcomeLabel.TabIndex = 2;
            WelcomeLabel.Text = "Planned Appointments:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(appTip);
            panel1.Controls.Add(infoBox);
            panel1.Controls.Add(appBox);
            panel1.Controls.Add(selectionLabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cancelButton);
            panel1.Location = new Point(12, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 394);
            panel1.TabIndex = 3;
            // 
            // infoBox
            // 
            infoBox.Location = new Point(56, 72);
            infoBox.Name = "infoBox";
            infoBox.ReadOnly = true;
            infoBox.Size = new Size(659, 208);
            infoBox.TabIndex = 5;
            infoBox.Text = "";
            // 
            // appBox
            // 
            appBox.DropDownStyle = ComboBoxStyle.DropDownList;
            appBox.FormattingEnabled = true;
            appBox.Location = new Point(179, 20);
            appBox.Name = "appBox";
            appBox.Size = new Size(536, 23);
            appBox.TabIndex = 4;
            appBox.SelectedIndexChanged += appBox_SelectedIndexChanged;
            // 
            // selectionLabel
            // 
            selectionLabel.AutoSize = true;
            selectionLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectionLabel.Location = new Point(17, 19);
            selectionLabel.Name = "selectionLabel";
            selectionLabel.Size = new Size(156, 20);
            selectionLabel.TabIndex = 3;
            selectionLabel.Text = "Appointment to view:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(603, 305);
            button1.Name = "button1";
            button1.Size = new Size(112, 27);
            button1.TabIndex = 2;
            button1.Text = "Close Viewer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(56, 305);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(217, 27);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel/Dismiss Appoitment";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // appTip
            // 
            appTip.AutoSize = true;
            appTip.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appTip.Location = new Point(721, 19);
            appTip.Name = "appTip";
            appTip.Size = new Size(16, 20);
            appTip.TabIndex = 6;
            appTip.TabStop = true;
            appTip.Text = "?";
            appTip.LinkClicked += appTip_LinkClicked;
            // 
            // AppoitmentViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(WelcomeLabel);
            Name = "AppoitmentViewer";
            Text = "Appoitment Viewer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Panel panel1;
        private Button button1;
        private Button cancelButton;
        private RichTextBox infoBox;
        private ComboBox appBox;
        private Label selectionLabel;
        private LinkLabel appTip;
    }
}