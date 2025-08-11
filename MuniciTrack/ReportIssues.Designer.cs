namespace MuniciTrack
{
    partial class ReportIssues
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
            label1 = new Label();
            lblFullName = new Label();
            label2 = new Label();
            txtFullName = new TextBox();
            txtLocation = new TextBox();
            lblCategory = new Label();
            rbInfrastructure = new RadioButton();
            rbElectricity = new RadioButton();
            rbWater = new RadioButton();
            rbWaste = new RadioButton();
            rbSanitation = new RadioButton();
            rbtOther = new RadioButton();
            label3 = new Label();
            richTxtDescription = new RichTextBox();
            label4 = new Label();
            btnUploadAttachment = new Button();
            label5 = new Label();
            rdbOpen = new RadioButton();
            rdbInProgress = new RadioButton();
            rdbClosed = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            buttonBack = new Button();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(379, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(374, 38);
            label1.TabIndex = 0;
            label1.Text = "Report Issues Management";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(101, 115);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(116, 32);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "FullName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 199);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Location ";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(329, 92);
            txtFullName.Margin = new Padding(4);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(672, 55);
            txtFullName.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(329, 178);
            txtLocation.Margin = new Padding(4);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(672, 53);
            txtLocation.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(109, 335);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(110, 32);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // rbInfrastructure
            // 
            rbInfrastructure.AutoSize = true;
            rbInfrastructure.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbInfrastructure.ForeColor = Color.White;
            rbInfrastructure.Location = new Point(21, 52);
            rbInfrastructure.Margin = new Padding(4);
            rbInfrastructure.Name = "rbInfrastructure";
            rbInfrastructure.Size = new Size(181, 36);
            rbInfrastructure.TabIndex = 6;
            rbInfrastructure.TabStop = true;
            rbInfrastructure.Text = "Infrastructure";
            rbInfrastructure.UseVisualStyleBackColor = true;
            // 
            // rbElectricity
            // 
            rbElectricity.AutoSize = true;
            rbElectricity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbElectricity.ForeColor = Color.White;
            rbElectricity.Location = new Point(21, 106);
            rbElectricity.Margin = new Padding(4);
            rbElectricity.Name = "rbElectricity";
            rbElectricity.Size = new Size(140, 36);
            rbElectricity.TabIndex = 7;
            rbElectricity.TabStop = true;
            rbElectricity.Text = "Electricity";
            rbElectricity.UseVisualStyleBackColor = true;
            // 
            // rbWater
            // 
            rbWater.AutoSize = true;
            rbWater.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbWater.ForeColor = Color.White;
            rbWater.Location = new Point(21, 160);
            rbWater.Margin = new Padding(4);
            rbWater.Name = "rbWater";
            rbWater.Size = new Size(101, 36);
            rbWater.TabIndex = 8;
            rbWater.TabStop = true;
            rbWater.Text = "Water";
            rbWater.UseVisualStyleBackColor = true;
            // 
            // rbWaste
            // 
            rbWaste.AutoSize = true;
            rbWaste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbWaste.ForeColor = Color.White;
            rbWaste.Location = new Point(298, 52);
            rbWaste.Margin = new Padding(4);
            rbWaste.Name = "rbWaste";
            rbWaste.Size = new Size(103, 36);
            rbWaste.TabIndex = 9;
            rbWaste.TabStop = true;
            rbWaste.Text = "Waste";
            rbWaste.UseVisualStyleBackColor = true;
            // 
            // rbSanitation
            // 
            rbSanitation.AutoSize = true;
            rbSanitation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSanitation.ForeColor = Color.White;
            rbSanitation.Location = new Point(298, 106);
            rbSanitation.Margin = new Padding(4);
            rbSanitation.Name = "rbSanitation";
            rbSanitation.Size = new Size(146, 36);
            rbSanitation.TabIndex = 10;
            rbSanitation.TabStop = true;
            rbSanitation.Text = "Sanitation";
            rbSanitation.UseVisualStyleBackColor = true;
            // 
            // rbtOther
            // 
            rbtOther.AutoSize = true;
            rbtOther.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtOther.ForeColor = Color.White;
            rbtOther.Location = new Point(302, 160);
            rbtOther.Margin = new Padding(4);
            rbtOther.Name = "rbtOther";
            rbtOther.Size = new Size(100, 36);
            rbtOther.TabIndex = 11;
            rbtOther.TabStop = true;
            rbtOther.Text = "Other";
            rbtOther.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(112, 537);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // richTxtDescription
            // 
            richTxtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTxtDescription.Location = new Point(329, 486);
            richTxtDescription.Margin = new Padding(4);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(671, 150);
            richTxtDescription.TabIndex = 13;
            richTxtDescription.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 689);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 32);
            label4.TabIndex = 14;
            label4.Text = "Attachment";
            // 
            // btnUploadAttachment
            // 
            btnUploadAttachment.BackColor = Color.Salmon;
            btnUploadAttachment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUploadAttachment.ForeColor = SystemColors.ButtonHighlight;
            btnUploadAttachment.Location = new Point(328, 666);
            btnUploadAttachment.Margin = new Padding(4);
            btnUploadAttachment.Name = "btnUploadAttachment";
            btnUploadAttachment.Size = new Size(672, 55);
            btnUploadAttachment.TabIndex = 15;
            btnUploadAttachment.Text = "Upload Attachment";
            btnUploadAttachment.UseVisualStyleBackColor = false;
            btnUploadAttachment.Click += btnUploadAttachment_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(112, 793);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 18;
            label5.Text = "Status";
            // 
            // rdbOpen
            // 
            rdbOpen.AutoSize = true;
            rdbOpen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbOpen.ForeColor = Color.White;
            rdbOpen.Location = new Point(19, 62);
            rdbOpen.Margin = new Padding(4);
            rdbOpen.Name = "rdbOpen";
            rdbOpen.Size = new Size(98, 36);
            rdbOpen.TabIndex = 19;
            rdbOpen.TabStop = true;
            rdbOpen.Text = "Open";
            rdbOpen.UseVisualStyleBackColor = true;
            // 
            // rdbInProgress
            // 
            rdbInProgress.AutoSize = true;
            rdbInProgress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbInProgress.ForeColor = Color.White;
            rdbInProgress.Location = new Point(158, 62);
            rdbInProgress.Margin = new Padding(4);
            rdbInProgress.Name = "rdbInProgress";
            rdbInProgress.Size = new Size(156, 36);
            rdbInProgress.TabIndex = 20;
            rdbInProgress.TabStop = true;
            rdbInProgress.Text = "In Progress";
            rdbInProgress.UseVisualStyleBackColor = true;
            // 
            // rdbClosed
            // 
            rdbClosed.AutoSize = true;
            rdbClosed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbClosed.ForeColor = Color.White;
            rdbClosed.Location = new Point(332, 62);
            rdbClosed.Margin = new Padding(4);
            rdbClosed.Name = "rdbClosed";
            rdbClosed.Size = new Size(111, 36);
            rdbClosed.TabIndex = 21;
            rdbClosed.TabStop = true;
            rdbClosed.Text = "Closed";
            rdbClosed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(rbInfrastructure);
            groupBox1.Controls.Add(rbElectricity);
            groupBox1.Controls.Add(rbWater);
            groupBox1.Controls.Add(rbWaste);
            groupBox1.Controls.Add(rbSanitation);
            groupBox1.Controls.Add(rbtOther);
            groupBox1.ForeColor = SystemColors.InfoText;
            groupBox1.Location = new Point(329, 262);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(495, 196);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Issue Category:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(rdbOpen);
            groupBox2.Controls.Add(rdbInProgress);
            groupBox2.Controls.Add(rdbClosed);
            groupBox2.Location = new Point(329, 754);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(495, 101);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Issue Status:";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.Location = new Point(329, 890);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(177, 56);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightCoral;
            buttonBack.Location = new Point(647, 890);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(177, 56);
            buttonBack.TabIndex = 25;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // toolTip1
            // 
//toolTip1.Popup += toolTip1_Popup;
            // 
            // ReportIssues
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1097, 1050);
            Controls.Add(buttonBack);
            Controls.Add(buttonSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(btnUploadAttachment);
            Controls.Add(label4);
            Controls.Add(richTxtDescription);
            Controls.Add(label3);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ReportIssues";
            Text = "ReportIssues";
            Load += ReportIssues_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFullName;
        private Label label2;
        private RadioButton rbInfrastructure;
        private TextBox txtFullName;
        private TextBox txtLocation;
        private Label lblCategory;
        private RadioButton rbElectricity;
        private RadioButton rbWater;
        private RadioButton rbWaste;
        private RadioButton rbSanitation;
        private RadioButton rbtOther;
        private Label label3;
        private RichTextBox richTxtDescription;
        private Label label4;
        private Button btnUploadAttachment;
       // private Button btnSave;
       // private Button btnCancel;
        private Label label5;
        private RadioButton rdbOpen;
        private RadioButton rdbInProgress;
        private RadioButton rdbClosed;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonSave;
        private Button buttonBack;
        private ToolTip toolTip1;
    }
}