namespace GREENCYCLE
{
    partial class MonitorUsers
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
            dataGridView1 = new DataGridView();
            btnConnection = new Button();
            btnLoadFile = new Button();
            label1 = new Label();
            label2 = new Label();
            tbxEmail = new TextBox();
            label3 = new Label();
            tbxPassword = new TextBox();
            label4 = new Label();
            tbxFullname = new TextBox();
            label5 = new Label();
            tbxAge = new TextBox();
            label6 = new Label();
            tbxPhoneNum = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbxProvince = new ComboBox();
            cbxMunicipality = new ComboBox();
            label10 = new Label();
            cbxBarangay = new ComboBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            tbxUserID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(383, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(758, 679);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Salmon;
            btnConnection.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(12, 637);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(173, 54);
            btnConnection.TabIndex = 1;
            btnConnection.Text = "Connection Test";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.Salmon;
            btnLoadFile.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadFile.Location = new Point(191, 637);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(173, 54);
            btnLoadFile.TabIndex = 2;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 73);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 3;
            label1.Text = "User ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 133);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(89, 133);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(292, 27);
            tbxEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 168);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(128, 166);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(253, 27);
            tbxPassword.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 205);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 9;
            label4.Text = "Fullname:";
            // 
            // tbxFullname
            // 
            tbxFullname.Location = new Point(128, 203);
            tbxFullname.Name = "tbxFullname";
            tbxFullname.Size = new Size(253, 27);
            tbxFullname.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 260);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 11;
            label5.Text = "Age:";
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(72, 258);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(86, 27);
            tbxAge.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 292);
            label6.Name = "label6";
            label6.Size = new Size(152, 21);
            label6.TabIndex = 13;
            label6.Text = "Phone Number:";
            // 
            // tbxPhoneNum
            // 
            tbxPhoneNum.Location = new Point(174, 292);
            tbxPhoneNum.Name = "tbxPhoneNum";
            tbxPhoneNum.Size = new Size(207, 27);
            tbxPhoneNum.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 351);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 15;
            label7.Text = "Province:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(16, 385);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 16;
            label8.Text = "Municipality:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(16, 422);
            label9.Name = "label9";
            label9.Size = new Size(101, 21);
            label9.TabIndex = 17;
            label9.Text = "Barangay:";
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Location = new Point(118, 349);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(263, 28);
            cbxProvince.TabIndex = 18;
            // 
            // cbxMunicipality
            // 
            cbxMunicipality.FormattingEnabled = true;
            cbxMunicipality.Location = new Point(152, 383);
            cbxMunicipality.Name = "cbxMunicipality";
            cbxMunicipality.Size = new Size(229, 28);
            cbxMunicipality.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(72, 9);
            label10.Name = "label10";
            label10.Size = new Size(264, 32);
            label10.TabIndex = 20;
            label10.Text = "User Information";
            // 
            // cbxBarangay
            // 
            cbxBarangay.FormattingEnabled = true;
            cbxBarangay.Location = new Point(123, 420);
            cbxBarangay.Name = "cbxBarangay";
            cbxBarangay.Size = new Size(258, 28);
            cbxBarangay.TabIndex = 21;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.SandyBrown;
            btnInsert.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(26, 497);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(96, 39);
            btnInsert.TabIndex = 22;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SandyBrown;
            btnDelete.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(142, 497);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 39);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SandyBrown;
            btnUpdate.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(260, 497);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 39);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxUserID
            // 
            tbxUserID.Location = new Point(107, 71);
            tbxUserID.Name = "tbxUserID";
            tbxUserID.Size = new Size(102, 27);
            tbxUserID.TabIndex = 25;
            // 
            // MonitorUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 703);
            Controls.Add(tbxUserID);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(cbxBarangay);
            Controls.Add(label10);
            Controls.Add(cbxMunicipality);
            Controls.Add(cbxProvince);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tbxPhoneNum);
            Controls.Add(label6);
            Controls.Add(tbxAge);
            Controls.Add(label5);
            Controls.Add(tbxFullname);
            Controls.Add(label4);
            Controls.Add(tbxPassword);
            Controls.Add(label3);
            Controls.Add(tbxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadFile);
            Controls.Add(btnConnection);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonitorUsers";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += MonitorUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnConnection;
        private Button btnLoadFile;
        private Label label1;
        private Label label2;
        private TextBox tbxEmail;
        private Label label3;
        private TextBox tbxPassword;
        private Label label4;
        private TextBox tbxFullname;
        private Label label5;
        private TextBox tbxAge;
        private Label label6;
        private TextBox tbxPhoneNum;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbxProvince;
        private ComboBox cbxMunicipality;
        private Label label10;
        private ComboBox cbxBarangay;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox tbxUserID;
    }
}