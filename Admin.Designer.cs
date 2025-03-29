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
            tbxAdminEmail = new TextBox();
            tbxAdminPass = new TextBox();
            label14 = new Label();
            label13 = new Label();
            btnLogIn = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            cbShowPassA = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // tbxAdminEmail
            // 
            tbxAdminEmail.Anchor = AnchorStyles.None;
            tbxAdminEmail.Location = new Point(129, 208);
            tbxAdminEmail.Multiline = true;
            tbxAdminEmail.Name = "tbxAdminEmail";
            tbxAdminEmail.PlaceholderText = "administratorID@green.cycle";
            tbxAdminEmail.Size = new Size(341, 34);
            tbxAdminEmail.TabIndex = 31;
            tbxAdminEmail.TabStop = false;
            // 
            // tbxAdminPass
            // 
            tbxAdminPass.Anchor = AnchorStyles.None;
            tbxAdminPass.Location = new Point(129, 302);
            tbxAdminPass.Multiline = true;
            tbxAdminPass.Name = "tbxAdminPass";
            tbxAdminPass.PasswordChar = '*';
            tbxAdminPass.PlaceholderText = "Password";
            tbxAdminPass.Size = new Size(341, 34);
            tbxAdminPass.TabIndex = 33;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(129, 59);
            label14.Name = "label14";
            label14.Size = new Size(314, 56);
            label14.TabIndex = 34;
            label14.Text = "Hello, Admin!";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(129, 115);
            label13.Name = "label13";
            label13.Size = new Size(306, 23);
            label13.TabIndex = 35;
            label13.Text = "Log-in to your account to continue";
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.BackColor = Color.DarkGreen;
            btnLogIn.BackgroundImageLayout = ImageLayout.Center;
            btnLogIn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.Lime;
            btnLogIn.Location = new Point(222, 440);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(119, 50);
            btnLogIn.TabIndex = 36;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(92, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 32);
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(92, 302);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 32);
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // cbShowPassA
            // 
            cbShowPassA.Anchor = AnchorStyles.None;
            cbShowPassA.AutoSize = true;
            cbShowPassA.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassA.Location = new Point(323, 342);
            cbShowPassA.Name = "cbShowPassA";
            cbShowPassA.Size = new Size(147, 23);
            cbShowPassA.TabIndex = 40;
            cbShowPassA.Text = "Show Password";
            cbShowPassA.UseVisualStyleBackColor = true;
            cbShowPassA.CheckedChanged += cbShowPassA_CheckedChanged;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(589, 569);
            Controls.Add(cbShowPassA);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btnLogIn);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(tbxAdminEmail);
            Controls.Add(tbxAdminPass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxAdminEmail;
        private TextBox tbxAdminPass;
        private Label label14;
        private Label label13;
        private Button btnLogIn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private CheckBox cbShowPassA;
    }
}