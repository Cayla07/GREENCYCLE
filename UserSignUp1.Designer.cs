namespace GREENCYCLE
{
    partial class UserSignUp1
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
            cbxBarangay = new ComboBox();
            label11 = new Label();
            cbxMunicipality = new ComboBox();
            label10 = new Label();
            cbxProvince = new ComboBox();
            label9 = new Label();
            cbxPayMeth = new ComboBox();
            label8 = new Label();
            tbxAge = new TextBox();
            label7 = new Label();
            linkUserLog = new LinkLabel();
            label5 = new Label();
            btnNext = new Button();
            label4 = new Label();
            label1 = new Label();
            tbxPhoneNum = new TextBox();
            label2 = new Label();
            tbxFullName = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // cbxBarangay
            // 
            cbxBarangay.Anchor = AnchorStyles.None;
            cbxBarangay.FormattingEnabled = true;
            cbxBarangay.Location = new Point(35, 412);
            cbxBarangay.Name = "cbxBarangay";
            cbxBarangay.Size = new Size(213, 28);
            cbxBarangay.TabIndex = 57;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(35, 385);
            label11.Name = "label11";
            label11.Size = new Size(107, 24);
            label11.TabIndex = 56;
            label11.Text = "Barangay:";
            // 
            // cbxMunicipality
            // 
            cbxMunicipality.Anchor = AnchorStyles.None;
            cbxMunicipality.FormattingEnabled = true;
            cbxMunicipality.Location = new Point(312, 332);
            cbxMunicipality.Name = "cbxMunicipality";
            cbxMunicipality.Size = new Size(213, 28);
            cbxMunicipality.TabIndex = 55;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(312, 305);
            label10.Name = "label10";
            label10.Size = new Size(130, 24);
            label10.TabIndex = 54;
            label10.Text = "Municipality:";
            // 
            // cbxProvince
            // 
            cbxProvince.Anchor = AnchorStyles.None;
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Location = new Point(35, 332);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(213, 28);
            cbxProvince.TabIndex = 53;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 305);
            label9.Name = "label9";
            label9.Size = new Size(100, 24);
            label9.TabIndex = 52;
            label9.Text = "Province:";
            // 
            // cbxPayMeth
            // 
            cbxPayMeth.Anchor = AnchorStyles.None;
            cbxPayMeth.FormattingEnabled = true;
            cbxPayMeth.Location = new Point(349, 250);
            cbxPayMeth.Name = "cbxPayMeth";
            cbxPayMeth.Size = new Size(176, 28);
            cbxPayMeth.TabIndex = 51;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(349, 223);
            label8.Name = "label8";
            label8.Size = new Size(176, 24);
            label8.TabIndex = 50;
            label8.Text = "Payment Method:";
            // 
            // tbxAge
            // 
            tbxAge.Anchor = AnchorStyles.None;
            tbxAge.Location = new Point(415, 158);
            tbxAge.Multiline = true;
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(110, 34);
            tbxAge.TabIndex = 49;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(415, 131);
            label7.Name = "label7";
            label7.Size = new Size(53, 24);
            label7.TabIndex = 48;
            label7.Text = "Age:";
            // 
            // linkUserLog
            // 
            linkUserLog.ActiveLinkColor = Color.Lime;
            linkUserLog.Anchor = AnchorStyles.None;
            linkUserLog.AutoSize = true;
            linkUserLog.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkUserLog.LinkColor = Color.Black;
            linkUserLog.Location = new Point(349, 538);
            linkUserLog.Name = "linkUserLog";
            linkUserLog.Size = new Size(56, 19);
            linkUserLog.TabIndex = 47;
            linkUserLog.TabStop = true;
            linkUserLog.Text = "Log-In";
            linkUserLog.LinkClicked += linkUserLog_LinkClicked;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(133, 538);
            label5.Name = "label5";
            label5.Size = new Size(217, 21);
            label5.TabIndex = 46;
            label5.Text = "Already have an account?";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.DarkGreen;
            btnNext.BackgroundImageLayout = ImageLayout.Center;
            btnNext.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Lime;
            btnNext.Location = new Point(447, 460);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(106, 41);
            btnNext.TabIndex = 45;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 65);
            label4.Name = "label4";
            label4.Size = new Size(267, 21);
            label4.TabIndex = 44;
            label4.Text = "Please fill out user's information.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 56);
            label1.TabIndex = 43;
            label1.Text = "Welcome!";
            // 
            // tbxPhoneNum
            // 
            tbxPhoneNum.Anchor = AnchorStyles.None;
            tbxPhoneNum.Location = new Point(35, 250);
            tbxPhoneNum.Multiline = true;
            tbxPhoneNum.Name = "tbxPhoneNum";
            tbxPhoneNum.Size = new Size(267, 34);
            tbxPhoneNum.TabIndex = 42;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 223);
            label2.Name = "label2";
            label2.Size = new Size(157, 24);
            label2.TabIndex = 41;
            label2.Text = "Phone Number:";
            // 
            // tbxFullName
            // 
            tbxFullName.Anchor = AnchorStyles.None;
            tbxFullName.Location = new Point(35, 158);
            tbxFullName.Multiline = true;
            tbxFullName.Name = "tbxFullName";
            tbxFullName.PlaceholderText = "ex. Juan Dela Cruz";
            tbxFullName.Size = new Size(341, 34);
            tbxFullName.TabIndex = 40;
            tbxFullName.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 131);
            label6.Name = "label6";
            label6.Size = new Size(110, 24);
            label6.TabIndex = 39;
            label6.Text = "Full Name:";
            // 
            // UserSignUp1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(589, 569);
            Controls.Add(cbxBarangay);
            Controls.Add(label11);
            Controls.Add(cbxMunicipality);
            Controls.Add(label10);
            Controls.Add(cbxProvince);
            Controls.Add(label9);
            Controls.Add(cbxPayMeth);
            Controls.Add(label8);
            Controls.Add(tbxAge);
            Controls.Add(label7);
            Controls.Add(linkUserLog);
            Controls.Add(label5);
            Controls.Add(btnNext);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(tbxPhoneNum);
            Controls.Add(label2);
            Controls.Add(tbxFullName);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSignUp1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += UserSignUp1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxBarangay;
        private Label label11;
        private ComboBox cbxMunicipality;
        private Label label10;
        private ComboBox cbxProvince;
        private Label label9;
        private ComboBox cbxPayMeth;
        private Label label8;
        private TextBox tbxAge;
        private Label label7;
        private LinkLabel linkUserLog;
        private Label label5;
        private Button btnNext;
        private Label label4;
        private Label label1;
        private TextBox tbxPhoneNum;
        private Label label2;
        private TextBox tbxFullName;
        private Label label6;
    }
}