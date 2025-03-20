namespace GREENCYCLE
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            btnMin = new Button();
            btnMax = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            cbShowPassA = new CheckBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnLogIn = new Button();
            label13 = new Label();
            label14 = new Label();
            tbxAdminPass = new TextBox();
            tbxAdminEmail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.PaleGreen;
            btnMin.BackgroundImageLayout = ImageLayout.Center;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(1195, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(38, 34);
            btnMin.TabIndex = 17;
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
            btnMax.Location = new Point(1239, 9);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 30);
            btnMax.TabIndex = 16;
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
            btnExit.Location = new Point(1274, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(27, 25);
            btnExit.TabIndex = 15;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(cbShowPassA);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(tbxAdminPass);
            panel1.Controls.Add(tbxAdminEmail);
            panel1.Location = new Point(358, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 616);
            panel1.TabIndex = 18;
            // 
            // cbShowPassA
            // 
            cbShowPassA.Anchor = AnchorStyles.None;
            cbShowPassA.AutoSize = true;
            cbShowPassA.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassA.Location = new Point(335, 377);
            cbShowPassA.Name = "cbShowPassA";
            cbShowPassA.Size = new Size(147, 23);
            cbShowPassA.TabIndex = 40;
            cbShowPassA.Text = "Show Password";
            cbShowPassA.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(104, 337);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 32);
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(104, 245);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 32);
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.BackColor = Color.DarkGreen;
            btnLogIn.BackgroundImageLayout = ImageLayout.Center;
            btnLogIn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.Lime;
            btnLogIn.Location = new Point(234, 475);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(119, 50);
            btnLogIn.TabIndex = 36;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(141, 150);
            label13.Name = "label13";
            label13.Size = new Size(306, 23);
            label13.TabIndex = 35;
            label13.Text = "Log-in to your account to continue";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(141, 94);
            label14.Name = "label14";
            label14.Size = new Size(314, 56);
            label14.TabIndex = 34;
            label14.Text = "Hello, Admin!";
            // 
            // tbxAdminPass
            // 
            tbxAdminPass.Anchor = AnchorStyles.None;
            tbxAdminPass.Location = new Point(141, 337);
            tbxAdminPass.Multiline = true;
            tbxAdminPass.Name = "tbxAdminPass";
            tbxAdminPass.PlaceholderText = "Password";
            tbxAdminPass.Size = new Size(341, 34);
            tbxAdminPass.TabIndex = 33;
            // 
            // tbxAdminEmail
            // 
            tbxAdminEmail.Anchor = AnchorStyles.None;
            tbxAdminEmail.Location = new Point(141, 243);
            tbxAdminEmail.Multiline = true;
            tbxAdminEmail.Name = "tbxAdminEmail";
            tbxAdminEmail.PlaceholderText = "administratorID@green.cycle";
            tbxAdminEmail.Size = new Size(341, 34);
            tbxAdminEmail.TabIndex = 31;
            tbxAdminEmail.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1313, 736);
            Controls.Add(panel1);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMin;
        private Button btnMax;
        private Button btnExit;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button btnLogIn;
        private Label label13;
        private Label label14;
        private TextBox tbxAdminPass;
        private TextBox tbxAdminEmail;
        private CheckBox cbShowPassA;
    }
}