namespace MuniciTrack
{
    partial class Main
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ReportIssues = new Button();
            EventsAndAnnouncements = new Button();
            ServiceRequestStatus = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 41);
            label1.Name = "label1";
            label1.Size = new Size(479, 38);
            label1.TabIndex = 0;
            label1.Text = "Municipality Management Console";
            label1.Click += label1_Click;
            // 
            // ReportIssues
            // 
            ReportIssues.BackColor = Color.PaleGreen;
            ReportIssues.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReportIssues.ForeColor = Color.Black;
            ReportIssues.Location = new Point(136, 134);
            ReportIssues.Name = "ReportIssues";
            ReportIssues.Size = new Size(434, 47);
            ReportIssues.TabIndex = 1;
            ReportIssues.Text = "Report Issues";
            ReportIssues.UseVisualStyleBackColor = false;
            ReportIssues.Click += ReportIssues_Click;
            // 
            // EventsAndAnnouncements
            // 
            EventsAndAnnouncements.BackColor = SystemColors.ActiveCaption;
            EventsAndAnnouncements.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EventsAndAnnouncements.Location = new Point(136, 234);
            EventsAndAnnouncements.Name = "EventsAndAnnouncements";
            EventsAndAnnouncements.Size = new Size(434, 52);
            EventsAndAnnouncements.TabIndex = 2;
            EventsAndAnnouncements.Text = "Local Events and Announcements";
            EventsAndAnnouncements.UseVisualStyleBackColor = false;
            EventsAndAnnouncements.Click += EventsAndAnnouncements_Click;
            // 
            // ServiceRequestStatus
            // 
            ServiceRequestStatus.BackColor = SystemColors.GradientInactiveCaption;
            ServiceRequestStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServiceRequestStatus.Location = new Point(136, 334);
            ServiceRequestStatus.Name = "ServiceRequestStatus";
            ServiceRequestStatus.Size = new Size(434, 45);
            ServiceRequestStatus.TabIndex = 3;
            ServiceRequestStatus.Text = "Service Request Status";
            ServiceRequestStatus.UseVisualStyleBackColor = false;
            ServiceRequestStatus.Click += ServiceRequestStatus_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Salmon;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(136, 425);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(434, 49);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(723, 527);
            Controls.Add(btnExit);
            Controls.Add(ServiceRequestStatus);
            Controls.Add(EventsAndAnnouncements);
            Controls.Add(ReportIssues);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Main";
            Text = "MyMain";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ReportIssues;
        private Button EventsAndAnnouncements;
        private Button ServiceRequestStatus;
        private Button btnExit;
    }
}
