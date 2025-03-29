namespace GREENCYCLE
{
    partial class UserSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignUp));
            cbShowPassA = new CheckBox();
            pictureBox3 = new PictureBox();
            tbxConPass = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnCreateAcc = new Button();
            label3 = new Label();
            tbxPassC = new TextBox();
            tbxEmailC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbShowPassA
            // 
            cbShowPassA.Anchor = AnchorStyles.None;
            cbShowPassA.AutoSize = true;
            cbShowPassA.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassA.Location = new Point(325, 311);
            cbShowPassA.Name = "cbShowPassA";
            cbShowPassA.Size = new Size(147, 23);
            cbShowPassA.TabIndex = 50;
            cbShowPassA.Text = "Show Password";
            cbShowPassA.UseVisualStyleBackColor = true;
            cbShowPassA.CheckedChanged += cbShowPassA_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(88, 359);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 31);
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // tbxConPass
            // 
            tbxConPass.Anchor = AnchorStyles.None;
            tbxConPass.Location = new Point(131, 359);
            tbxConPass.Multiline = true;
            tbxConPass.Name = "tbxConPass";
            tbxConPass.PlaceholderText = "Confirm Password";
            tbxConPass.Size = new Size(341, 34);
            tbxConPass.TabIndex = 48;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(88, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 31);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 31);
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.Anchor = AnchorStyles.None;
            btnCreateAcc.BackColor = Color.DarkGreen;
            btnCreateAcc.BackgroundImageLayout = ImageLayout.Center;
            btnCreateAcc.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAcc.ForeColor = Color.Lime;
            btnCreateAcc.Location = new Point(193, 445);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(210, 41);
            btnCreateAcc.TabIndex = 45;
            btnCreateAcc.Text = "CREATE ACCOUNT";
            btnCreateAcc.UseVisualStyleBackColor = false;
            btnCreateAcc.Click += btnCreateAcc_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 83);
            label3.Name = "label3";
            label3.Size = new Size(436, 56);
            label3.TabIndex = 44;
            label3.Text = "Create an Account";
            // 
            // tbxPassC
            // 
            tbxPassC.Anchor = AnchorStyles.None;
            tbxPassC.Location = new Point(131, 271);
            tbxPassC.Multiline = true;
            tbxPassC.Name = "tbxPassC";
            tbxPassC.PasswordChar = '*';
            tbxPassC.PlaceholderText = "Password";
            tbxPassC.Size = new Size(341, 34);
            tbxPassC.TabIndex = 43;
            // 
            // tbxEmailC
            // 
            tbxEmailC.Anchor = AnchorStyles.None;
            tbxEmailC.Location = new Point(131, 201);
            tbxEmailC.Multiline = true;
            tbxEmailC.Name = "tbxEmailC";
            tbxEmailC.PlaceholderText = "Email";
            tbxEmailC.Size = new Size(341, 34);
            tbxEmailC.TabIndex = 42;
            tbxEmailC.TabStop = false;
            // 
            // UserSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(589, 569);
            Controls.Add(cbShowPassA);
            Controls.Add(pictureBox3);
            Controls.Add(tbxConPass);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCreateAcc);
            Controls.Add(label3);
            Controls.Add(tbxPassC);
            Controls.Add(tbxEmailC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSignUp";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += UserSignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbShowPassA;
        private PictureBox pictureBox3;
        private TextBox tbxConPass;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnCreateAcc;
        private Label label3;
        private TextBox tbxPassC;
        private TextBox tbxEmailC;
    }
}