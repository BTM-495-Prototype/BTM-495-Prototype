namespace BTM_495_Final_Prototype
{
    partial class FaqForm
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
            FormTitleLabel = new Label();
            panel1 = new Panel();
            answerBox = new RichTextBox();
            button1 = new Button();
            fawComboBox = new ComboBox();
            helpLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FormTitleLabel
            // 
            FormTitleLabel.AutoSize = true;
            FormTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormTitleLabel.Location = new Point(8, 8);
            FormTitleLabel.Name = "FormTitleLabel";
            FormTitleLabel.Size = new Size(222, 21);
            FormTitleLabel.TabIndex = 1;
            FormTitleLabel.Text = "Frequently asked questions:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(answerBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(fawComboBox);
            panel1.Controls.Add(helpLabel);
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 405);
            panel1.TabIndex = 3;
            // 
            // answerBox
            // 
            answerBox.Location = new Point(139, 104);
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(512, 228);
            answerBox.TabIndex = 7;
            answerBox.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(646, 14);
            button1.Name = "button1";
            button1.Size = new Size(115, 26);
            button1.TabIndex = 6;
            button1.Text = "Close F.A.Q";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fawComboBox
            // 
            fawComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fawComboBox.FormattingEnabled = true;
            fawComboBox.Items.AddRange(new object[] { "Making/viewing/canceling an appointment", "Placing/viewing/canceling an order", "Updating my user", "Deactivating my user", "I forgot my login details", "How do I create a new account?", "My issue isnt on the list (other)" });
            fawComboBox.Location = new Point(139, 15);
            fawComboBox.Name = "fawComboBox";
            fawComboBox.Size = new Size(414, 23);
            fawComboBox.TabIndex = 5;
            fawComboBox.SelectedIndexChanged += fawComboBox_SelectedIndexChanged;
            // 
            // helpLabel
            // 
            helpLabel.AutoSize = true;
            helpLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helpLabel.Location = new Point(11, 16);
            helpLabel.Name = "helpLabel";
            helpLabel.Size = new Size(122, 20);
            helpLabel.TabIndex = 4;
            helpLabel.Text = "I need help with:";
            // 
            // FaqForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FormTitleLabel);
            Controls.Add(panel1);
            Name = "FaqForm";
            Text = "F.A.Q - Online Pharmacy Platform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormTitleLabel;
        private Panel panel1;
        private Label helpLabel;
        private ComboBox fawComboBox;
        private Button button1;
        private RichTextBox answerBox;
    }
}