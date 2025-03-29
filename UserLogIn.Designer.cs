namespace GREENCYCLE
{
    partial class UserLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogIn));
            cbxShowPassL = new CheckBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            linkSignUp = new LinkLabel();
            label12 = new Label();
            btnLogIn = new Button();
            label13 = new Label();
            label14 = new Label();
            tbxPassL = new TextBox();
            linkLabel1 = new LinkLabel();
            tbxEmailL = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cbxShowPassL
            // 
            cbxShowPassL.Anchor = AnchorStyles.None;
            cbxShowPassL.AutoSize = true;
            cbxShowPassL.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxShowPassL.Location = new Point(321, 317);
            cbxShowPassL.Name = "cbxShowPassL";
            cbxShowPassL.Size = new Size(147, 23);
            cbxShowPassL.TabIndex = 53;
            cbxShowPassL.Text = "Show Password";
            cbxShowPassL.UseVisualStyleBackColor = true;
            cbxShowPassL.CheckedChanged += cbxShowPassL_CheckedChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(90, 274);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 32);
            pictureBox5.TabIndex = 52;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(90, 182);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 32);
            pictureBox4.TabIndex = 51;
            pictureBox4.TabStop = false;
            // 
            // linkSignUp
            // 
            linkSignUp.ActiveLinkColor = Color.Lime;
            linkSignUp.Anchor = AnchorStyles.None;
            linkSignUp.AutoSize = true;
            linkSignUp.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkSignUp.LinkColor = Color.Black;
            linkSignUp.Location = new Point(347, 520);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(67, 19);
            linkSignUp.TabIndex = 50;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign Up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(150, 520);
            label12.Name = "label12";
            label12.Size = new Size(198, 21);
            label12.TabIndex = 49;
            label12.Text = "Don't have an account?";
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.BackColor = Color.DarkGreen;
            btnLogIn.BackgroundImageLayout = ImageLayout.Center;
            btnLogIn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.Lime;
            btnLogIn.Location = new Point(220, 394);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(128, 53);
            btnLogIn.TabIndex = 48;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(127, 87);
            label13.Name = "label13";
            label13.Size = new Size(306, 23);
            label13.TabIndex = 47;
            label13.Text = "Log-in to your account to continue";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(220, 31);
            label14.Name = "label14";
            label14.Size = new Size(150, 56);
            label14.TabIndex = 46;
            label14.Text = "Hello!";
            // 
            // tbxPassL
            // 
            tbxPassL.Anchor = AnchorStyles.None;
            tbxPassL.Location = new Point(127, 274);
            tbxPassL.Multiline = true;
            tbxPassL.Name = "tbxPassL";
            tbxPassL.PasswordChar = '*';
            tbxPassL.PlaceholderText = "Password";
            tbxPassL.Size = new Size(341, 34);
            tbxPassL.TabIndex = 45;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Lime;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(220, 485);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 17);
            linkLabel1.TabIndex = 44;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // tbxEmailL
            // 
            tbxEmailL.Anchor = AnchorStyles.None;
            tbxEmailL.Location = new Point(127, 180);
            tbxEmailL.Multiline = true;
            tbxEmailL.Name = "tbxEmailL";
            tbxEmailL.PlaceholderText = "Email";
            tbxEmailL.Size = new Size(341, 34);
            tbxEmailL.TabIndex = 43;
            tbxEmailL.TabStop = false;
            // 
            // UserLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(589, 569);
            Controls.Add(cbxShowPassL);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(linkSignUp);
            Controls.Add(label12);
            Controls.Add(btnLogIn);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(tbxPassL);
            Controls.Add(linkLabel1);
            Controls.Add(tbxEmailL);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserLogIn";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += UserLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbxShowPassL;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private LinkLabel linkSignUp;
        private Label label12;
        private Button btnLogIn;
        private Label label13;
        private Label label14;
        private TextBox tbxPassL;
        private LinkLabel linkLabel1;
        private TextBox tbxEmailL;
    }
}