namespace BTM_495_Final_Prototype
{
    partial class Dashdoard
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
            components = new System.ComponentModel.Container();
            WelcomeLabel = new Label();
            mOrdButton = new Button();
            mAppButton = new Button();
            cAppButton = new Button();
            rNoteButton = new Button();
            cNoteButton = new Button();
            upUserButton = new Button();
            cUserButton = new Button();
            clockBox = new TextBox();
            dashClock = new System.Windows.Forms.Timer(components);
            fButton = new Button();
            panel1 = new Panel();
            ordsViewbutton = new Button();
            exitButton = new Button();
            appsViewButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(57, 21);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "label1";
            // 
            // mOrdButton
            // 
            mOrdButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mOrdButton.Location = new Point(89, 17);
            mOrdButton.Name = "mOrdButton";
            mOrdButton.Size = new Size(104, 47);
            mOrdButton.TabIndex = 1;
            mOrdButton.Text = "Place New Order";
            mOrdButton.UseVisualStyleBackColor = true;
            mOrdButton.Click += mOrdButton_Click;
            // 
            // mAppButton
            // 
            mAppButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mAppButton.Location = new Point(252, 17);
            mAppButton.Name = "mAppButton";
            mAppButton.Size = new Size(104, 47);
            mAppButton.TabIndex = 3;
            mAppButton.Text = "Make New Appoitment";
            mAppButton.UseVisualStyleBackColor = true;
            mAppButton.Click += mAppButton_Click;
            // 
            // cAppButton
            // 
            cAppButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cAppButton.Location = new Point(252, 94);
            cAppButton.Name = "cAppButton";
            cAppButton.Size = new Size(104, 47);
            cAppButton.TabIndex = 4;
            cAppButton.Text = "View or Cancel Appointment";
            cAppButton.UseVisualStyleBackColor = true;
            cAppButton.Click += cAppButton_Click;
            // 
            // rNoteButton
            // 
            rNoteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rNoteButton.Location = new Point(415, 17);
            rNoteButton.Name = "rNoteButton";
            rNoteButton.Size = new Size(104, 47);
            rNoteButton.TabIndex = 5;
            rNoteButton.Text = "Read Notification";
            rNoteButton.UseVisualStyleBackColor = true;
            rNoteButton.Click += rNoteButton_Click;
            // 
            // cNoteButton
            // 
            cNoteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cNoteButton.Location = new Point(415, 94);
            cNoteButton.Name = "cNoteButton";
            cNoteButton.Size = new Size(104, 47);
            cNoteButton.TabIndex = 6;
            cNoteButton.Text = "Create Notification";
            cNoteButton.UseVisualStyleBackColor = true;
            cNoteButton.Click += cNoteButton_Click;
            // 
            // upUserButton
            // 
            upUserButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upUserButton.Location = new Point(578, 17);
            upUserButton.Name = "upUserButton";
            upUserButton.Size = new Size(104, 47);
            upUserButton.TabIndex = 7;
            upUserButton.Text = "Update User Details";
            upUserButton.UseVisualStyleBackColor = true;
            upUserButton.Click += upUserButton_Click;
            // 
            // cUserButton
            // 
            cUserButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cUserButton.Location = new Point(252, 17);
            cUserButton.Name = "cUserButton";
            cUserButton.Size = new Size(104, 47);
            cUserButton.TabIndex = 8;
            cUserButton.Text = "Create User";
            cUserButton.UseVisualStyleBackColor = true;
            cUserButton.Click += cUserButton_Click;
            // 
            // clockBox
            // 
            clockBox.BackColor = SystemColors.Control;
            clockBox.BorderStyle = BorderStyle.None;
            clockBox.Location = new Point(19, 33);
            clockBox.Name = "clockBox";
            clockBox.ReadOnly = true;
            clockBox.Size = new Size(128, 16);
            clockBox.TabIndex = 9;
            // 
            // dashClock
            // 
            dashClock.Enabled = true;
            dashClock.Interval = 1000;
            dashClock.Tick += dashClock_Tick;
            // 
            // fButton
            // 
            fButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fButton.Location = new Point(89, 301);
            fButton.Name = "fButton";
            fButton.Size = new Size(104, 47);
            fButton.TabIndex = 10;
            fButton.Text = "F.A.Q";
            fButton.UseVisualStyleBackColor = true;
            fButton.Click += fButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ordsViewbutton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(appsViewButton);
            panel1.Controls.Add(fButton);
            panel1.Controls.Add(cUserButton);
            panel1.Controls.Add(upUserButton);
            panel1.Controls.Add(cNoteButton);
            panel1.Controls.Add(rNoteButton);
            panel1.Controls.Add(cAppButton);
            panel1.Controls.Add(mAppButton);
            panel1.Controls.Add(mOrdButton);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 376);
            panel1.TabIndex = 13;
            // 
            // ordsViewbutton
            // 
            ordsViewbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordsViewbutton.Location = new Point(89, 17);
            ordsViewbutton.Name = "ordsViewbutton";
            ordsViewbutton.Size = new Size(104, 47);
            ordsViewbutton.TabIndex = 15;
            ordsViewbutton.Text = "View Orders";
            ordsViewbutton.UseVisualStyleBackColor = true;
            ordsViewbutton.Click += ordsViewbutton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(578, 301);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(104, 47);
            exitButton.TabIndex = 14;
            exitButton.Text = "Exit Dashboard";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // appsViewButton
            // 
            appsViewButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appsViewButton.Location = new Point(89, 94);
            appsViewButton.Name = "appsViewButton";
            appsViewButton.Size = new Size(104, 47);
            appsViewButton.TabIndex = 13;
            appsViewButton.Text = "View Appointments";
            appsViewButton.UseVisualStyleBackColor = true;
            appsViewButton.Click += appsViewButton_Click;
            // 
            // Dashdoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(clockBox);
            Controls.Add(WelcomeLabel);
            Name = "Dashdoard";
            Text = "User Dashdoard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Button mOrdButton;
        private Button mAppButton;
        private Button cAppButton;
        private Button rNoteButton;
        private Button cNoteButton;
        private Button upUserButton;
        private Button cUserButton;
        private TextBox clockBox;
        private System.Windows.Forms.Timer dashClock;
        private Button fButton;
        private Panel panel1;
        private Button appsViewButton;
        private Button exitButton;
        private Button ordsViewbutton;
    }
}