namespace GREENCYCLE
{
    partial class UserTypePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTypePage));
            label1 = new Label();
            btnMin = new Button();
            btnMax = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            btnProceed = new Button();
            cmbType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGreen;
            label1.Font = new Font("Cooper Black", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(482, 139);
            label1.Name = "label1";
            label1.Size = new Size(396, 77);
            label1.TabIndex = 2;
            label1.Text = "WELCOME";
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.PaleGreen;
            btnMin.BackgroundImageLayout = ImageLayout.Center;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(1213, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(38, 34);
            btnMin.TabIndex = 11;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.PaleGreen;
            btnMax.BackgroundImageLayout = ImageLayout.Center;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(1257, 9);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 30);
            btnMax.TabIndex = 10;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.PaleGreen;
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1292, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(27, 25);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(btnProceed);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(449, 462);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 194);
            panel1.TabIndex = 12;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.DarkGreen;
            btnProceed.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProceed.ForeColor = Color.Lime;
            btnProceed.Location = new Point(372, 136);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(103, 43);
            btnProceed.TabIndex = 2;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(50, 77);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(343, 27);
            cmbType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(50, 36);
            label2.Name = "label2";
            label2.Size = new Size(255, 23);
            label2.TabIndex = 0;
            label2.Text = "Please select a user type";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.PaleGreen;
            label3.Font = new Font("Cooper Black", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(432, 343);
            label3.Name = "label3";
            label3.Size = new Size(522, 77);
            label3.TabIndex = 13;
            label3.Text = "GREENCYCLE";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.PaleGreen;
            label4.Font = new Font("Cooper Black", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(614, 237);
            label4.Name = "label4";
            label4.Size = new Size(132, 77);
            label4.TabIndex = 14;
            label4.Text = "TO";
            // 
            // UserTypePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1331, 783);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserTypePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMin;
        private Button btnMax;
        private Button btnExit;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private Label label4;
        private Button btnProceed;
    }
}