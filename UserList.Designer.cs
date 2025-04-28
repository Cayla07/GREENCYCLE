namespace GREENCYCLE
{
    partial class UserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList));
            cbxBarangay = new ComboBox();
            tbxUserID = new TextBox();
            label10 = new Label();
            tbxPhoneNum = new TextBox();
            label6 = new Label();
            tbxFullname = new TextBox();
            label4 = new Label();
            tbxPassword = new TextBox();
            label3 = new Label();
            tbxEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLoadFile = new Button();
            btnConnection = new Button();
            cbxMunicipality = new ComboBox();
            cbxProvince = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            btnClear = new Button();
            btnSearch = new Button();
            dgvUserList = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // cbxBarangay
            // 
            cbxBarangay.BackColor = Color.White;
            cbxBarangay.Font = new Font("Segoe UI", 9F);
            cbxBarangay.FormattingEnabled = true;
            cbxBarangay.Location = new Point(126, 439);
            cbxBarangay.Name = "cbxBarangay";
            cbxBarangay.Size = new Size(253, 28);
            cbxBarangay.TabIndex = 69;
            cbxBarangay.SelectedIndexChanged += cbxBarangay_SelectedIndexChanged;
            // 
            // tbxUserID
            // 
            tbxUserID.Location = new Point(105, 89);
            tbxUserID.Name = "tbxUserID";
            tbxUserID.Size = new Size(102, 27);
            tbxUserID.TabIndex = 68;
            tbxUserID.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(54, 12);
            label10.Name = "label10";
            label10.Size = new Size(264, 32);
            label10.TabIndex = 67;
            label10.Text = "User Information";
            // 
            // tbxPhoneNum
            // 
            tbxPhoneNum.Location = new Point(190, 294);
            tbxPhoneNum.Name = "tbxPhoneNum";
            tbxPhoneNum.Size = new Size(189, 27);
            tbxPhoneNum.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(14, 294);
            label6.Name = "label6";
            label6.Size = new Size(170, 23);
            label6.TabIndex = 65;
            label6.Text = "Phone Number:";
            // 
            // tbxFullname
            // 
            tbxFullname.Location = new Point(126, 219);
            tbxFullname.Name = "tbxFullname";
            tbxFullname.Size = new Size(253, 27);
            tbxFullname.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 221);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 61;
            label4.Text = "Fullname:";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(126, 182);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(253, 27);
            tbxPassword.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 186);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 59;
            label3.Text = "Password:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(87, 149);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(292, 27);
            tbxEmail.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 153);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 57;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 91);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 56;
            label1.Text = "User ID:";
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.Salmon;
            btnLoadFile.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadFile.Location = new Point(568, 605);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(173, 54);
            btnLoadFile.TabIndex = 55;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click_1;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Salmon;
            btnConnection.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(387, 605);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(173, 54);
            btnConnection.TabIndex = 54;
            btnConnection.Text = "Connection Test";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click_1;
            // 
            // cbxMunicipality
            // 
            cbxMunicipality.FormattingEnabled = true;
            cbxMunicipality.Location = new Point(165, 400);
            cbxMunicipality.Name = "cbxMunicipality";
            cbxMunicipality.Size = new Size(214, 28);
            cbxMunicipality.TabIndex = 74;
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Location = new Point(126, 366);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(253, 28);
            cbxProvince.TabIndex = 73;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(14, 402);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 72;
            label8.Text = "Municipality:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(14, 368);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 71;
            label7.Text = "Province:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Salmon;
            btnClear.Font = new Font("Cooper Black", 12F);
            btnClear.Location = new Point(271, 485);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 42);
            btnClear.TabIndex = 75;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(203, 89);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(31, 27);
            btnSearch.TabIndex = 76;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvUserList
            // 
            dgvUserList.BackgroundColor = Color.LemonChiffon;
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(387, 12);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.RowHeadersWidth = 51;
            dgvUserList.Size = new Size(754, 515);
            dgvUserList.TabIndex = 77;
            dgvUserList.CellContentClick += dgvUserList_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 439);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 78;
            label5.Text = "Barangay:";
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 703);
            Controls.Add(label5);
            Controls.Add(dgvUserList);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(cbxMunicipality);
            Controls.Add(cbxProvince);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbxBarangay);
            Controls.Add(tbxUserID);
            Controls.Add(label10);
            Controls.Add(tbxPhoneNum);
            Controls.Add(label6);
            Controls.Add(tbxFullname);
            Controls.Add(label4);
            Controls.Add(tbxPassword);
            Controls.Add(label3);
            Controls.Add(tbxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadFile);
            Controls.Add(btnConnection);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserList";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += UserList_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbxBarangay;
        private TextBox tbxUserID;
        private Label label10;
        private TextBox tbxPhoneNum;
        private Label label6;
        private TextBox tbxFullname;
        private Label label4;
        private TextBox tbxPassword;
        private Label label3;
        private TextBox tbxEmail;
        private Label label2;
        private Label label1;
        private Button btnLoadFile;
        private Button btnConnection;
        private ComboBox cbxMunicipality;
        private ComboBox cbxProvince;
        private Label label8;
        private Label label7;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView dgvUserList;
        private Label label5;
    }
}