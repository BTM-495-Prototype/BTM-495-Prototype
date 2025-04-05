namespace BTM_495_Final_Prototype
{
    partial class AppoitmentMaker
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
            panel1 = new Panel();
            closeButton = new Button();
            makeApp = new Button();
            dateTip = new LinkLabel();
            slotBox = new ComboBox();
            datePicker = new DateTimePicker();
            typeBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            selectLabel = new Label();
            WelcomeLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(makeApp);
            panel1.Controls.Add(dateTip);
            panel1.Controls.Add(slotBox);
            panel1.Controls.Add(datePicker);
            panel1.Controls.Add(typeBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(selectLabel);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 374);
            panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(429, 258);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(157, 31);
            closeButton.TabIndex = 8;
            closeButton.Text = "Close Planner";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // makeApp
            // 
            makeApp.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makeApp.Location = new Point(230, 258);
            makeApp.Name = "makeApp";
            makeApp.Size = new Size(157, 31);
            makeApp.TabIndex = 7;
            makeApp.Text = "Plan Appointment";
            makeApp.UseVisualStyleBackColor = true;
            makeApp.Click += makeApp_Click;
            // 
            // dateTip
            // 
            dateTip.AutoSize = true;
            dateTip.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTip.Location = new Point(429, 33);
            dateTip.Name = "dateTip";
            dateTip.Size = new Size(16, 20);
            dateTip.TabIndex = 6;
            dateTip.TabStop = true;
            dateTip.Text = "?";
            dateTip.LinkClicked += dateTip_LinkClicked;
            // 
            // slotBox
            // 
            slotBox.AutoCompleteCustomSource.AddRange(new string[] { "09:00 am", "10:00 am", "11:00 am", "12:00 pm", "13:00 pm", "14:00 pm", "15:00 pm" });
            slotBox.DropDownStyle = ComboBoxStyle.DropDownList;
            slotBox.FormattingEnabled = true;
            slotBox.Items.AddRange(new object[] { "09:00 am", "10:00 am", "11:00 am", "12:00 pm", "13:00 pm", "14:00 pm", "15:00 pm", "16:00 pm" });
            slotBox.Location = new Point(230, 156);
            slotBox.Name = "slotBox";
            slotBox.Size = new Size(198, 23);
            slotBox.TabIndex = 5;
            slotBox.SelectedIndexChanged += slotBox_SelectedIndexChanged;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(230, 33);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(198, 23);
            datePicker.TabIndex = 4;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // typeBox
            // 
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.FormattingEnabled = true;
            typeBox.Items.AddRange(new object[] { "General consultation", "Vaccination", "Eye exam", "Order pickup" });
            typeBox.Location = new Point(230, 94);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(198, 23);
            typeBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 94);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 2;
            label2.Text = "Select appoitment type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 155);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Select time slot:";
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectLabel.Location = new Point(33, 33);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(170, 20);
            selectLabel.TabIndex = 0;
            selectLabel.Text = "Select appoitment date:";
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(170, 21);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Appoitment Planner:";
            // 
            // AppoitmentMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WelcomeLabel);
            Controls.Add(panel1);
            Name = "AppoitmentMaker";
            Text = "Appoitment Maker";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label WelcomeLabel;
        private ComboBox slotBox;
        private DateTimePicker datePicker;
        private ComboBox typeBox;
        private Label label2;
        private Label label1;
        private Label selectLabel;
        private LinkLabel dateTip;
        private Button closeButton;
        private Button makeApp;
    }
}