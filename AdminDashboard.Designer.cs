namespace GREENCYCLE
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            label1 = new Label();
            UserProfile = new PictureBox();
            panelMenu = new Panel();
            btnOut = new Button();
            btnSettings = new Button();
            btnEditRates = new Button();
            btnStatistics = new Button();
            btnEditTypes = new Button();
            btnUsers = new Button();
            btnDashboard = new Button();
            btnMin = new Button();
            btnMax = new Button();
            btnExit = new Button();
            panelAdminDB = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserProfile).BeginInit();
            panelMenu.SuspendLayout();
            panelAdminDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserProfile);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 185);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 112);
            label1.Name = "label1";
            label1.Size = new Size(103, 24);
            label1.TabIndex = 0;
            label1.Text = "< admin >";
            // 
            // UserProfile
            // 
            UserProfile.BackgroundImageLayout = ImageLayout.Center;
            UserProfile.Image = (Image)resources.GetObject("UserProfile.Image");
            UserProfile.Location = new Point(113, 28);
            UserProfile.Name = "UserProfile";
            UserProfile.Size = new Size(64, 64);
            UserProfile.TabIndex = 0;
            UserProfile.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Green;
            panelMenu.Controls.Add(btnOut);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnEditRates);
            panelMenu.Controls.Add(btnStatistics);
            panelMenu.Controls.Add(btnEditTypes);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.ForestGreen;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(299, 765);
            panelMenu.TabIndex = 26;
            // 
            // btnOut
            // 
            btnOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOut.BackColor = Color.Transparent;
            btnOut.BackgroundImageLayout = ImageLayout.None;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOut.ForeColor = Color.White;
            btnOut.Image = (Image)resources.GetObject("btnOut.Image");
            btnOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnOut.Location = new Point(131, 700);
            btnOut.Name = "btnOut";
            btnOut.Padding = new Padding(10, 0, 0, 0);
            btnOut.Size = new Size(169, 53);
            btnOut.TabIndex = 28;
            btnOut.Text = " LOG OUT";
            btnOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.BackgroundImageLayout = ImageLayout.None;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(131, 641);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(169, 53);
            btnSettings.TabIndex = 27;
            btnSettings.Text = " SETTINGS";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnEditRates
            // 
            btnEditRates.Anchor = AnchorStyles.Left;
            btnEditRates.BackColor = Color.Transparent;
            btnEditRates.BackgroundImageLayout = ImageLayout.None;
            btnEditRates.FlatStyle = FlatStyle.Flat;
            btnEditRates.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditRates.ForeColor = Color.White;
            btnEditRates.Image = (Image)resources.GetObject("btnEditRates.Image");
            btnEditRates.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditRates.Location = new Point(3, 327);
            btnEditRates.Name = "btnEditRates";
            btnEditRates.Padding = new Padding(10, 0, 0, 0);
            btnEditRates.Size = new Size(307, 65);
            btnEditRates.TabIndex = 26;
            btnEditRates.Text = " EDIT RECYCLE RATES";
            btnEditRates.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditRates.UseVisualStyleBackColor = false;
            btnEditRates.Click += btnEditRates_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Anchor = AnchorStyles.Left;
            btnStatistics.BackColor = Color.Transparent;
            btnStatistics.BackgroundImageLayout = ImageLayout.None;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.Image = (Image)resources.GetObject("btnStatistics.Image");
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(3, 469);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Padding = new Padding(10, 0, 0, 0);
            btnStatistics.Size = new Size(307, 65);
            btnStatistics.TabIndex = 25;
            btnStatistics.Text = " STATISTICS";
            btnStatistics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnEditTypes
            // 
            btnEditTypes.Anchor = AnchorStyles.Left;
            btnEditTypes.BackColor = Color.Transparent;
            btnEditTypes.BackgroundImageLayout = ImageLayout.None;
            btnEditTypes.FlatStyle = FlatStyle.Flat;
            btnEditTypes.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditTypes.ForeColor = Color.White;
            btnEditTypes.Image = (Image)resources.GetObject("btnEditTypes.Image");
            btnEditTypes.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditTypes.Location = new Point(3, 398);
            btnEditTypes.Name = "btnEditTypes";
            btnEditTypes.Padding = new Padding(10, 0, 0, 0);
            btnEditTypes.Size = new Size(307, 65);
            btnEditTypes.TabIndex = 24;
            btnEditTypes.Text = " EDIT RECYCLES";
            btnEditTypes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditTypes.UseVisualStyleBackColor = false;
            btnEditTypes.Click += btnEditTypes_Click;
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.Left;
            btnUsers.BackColor = Color.Transparent;
            btnUsers.BackgroundImageLayout = ImageLayout.None;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(3, 256);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(10, 0, 0, 0);
            btnUsers.Size = new Size(307, 65);
            btnUsers.TabIndex = 23;
            btnUsers.Text = " USERS";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Left;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 185);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(307, 65);
            btnDashboard.TabIndex = 22;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.PaleGreen;
            btnMin.BackgroundImageLayout = ImageLayout.Center;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(1334, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(38, 34);
            btnMin.TabIndex = 25;
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
            btnMax.Location = new Point(1378, 9);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 30);
            btnMax.TabIndex = 24;
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
            btnExit.Location = new Point(1413, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(27, 25);
            btnExit.TabIndex = 23;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelAdminDB
            // 
            panelAdminDB.Controls.Add(panel4);
            panelAdminDB.Controls.Add(panel3);
            panelAdminDB.Controls.Add(pictureBox1);
            panelAdminDB.Controls.Add(pictureBox5);
            panelAdminDB.Controls.Add(button4);
            panelAdminDB.Controls.Add(button3);
            panelAdminDB.Controls.Add(button2);
            panelAdminDB.Controls.Add(pictureBox4);
            panelAdminDB.Controls.Add(pictureBox3);
            panelAdminDB.Controls.Add(pictureBox2);
            panelAdminDB.Location = new Point(298, 43);
            panelAdminDB.Name = "panelAdminDB";
            panelAdminDB.Size = new Size(1154, 722);
            panelAdminDB.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 227);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Location = new Point(28, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(251, 227);
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(877, 13);
            button4.Name = "button4";
            button4.Size = new Size(251, 227);
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(596, 13);
            button3.Name = "button3";
            button3.Size = new Size(251, 227);
            button3.TabIndex = 24;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(312, 13);
            button2.Name = "button2";
            button2.Size = new Size(251, 227);
            button2.TabIndex = 23;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(877, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(251, 227);
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(596, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(251, 227);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(312, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(251, 227);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(28, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(418, 312);
            panel3.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(452, 246);
            panel4.Name = "panel4";
            panel4.Size = new Size(676, 312);
            panel4.TabIndex = 28;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1452, 765);
            Controls.Add(panelAdminDB);
            Controls.Add(panelMenu);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserProfile).EndInit();
            panelMenu.ResumeLayout(false);
            panelAdminDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox UserProfile;
        private Panel panelMenu;
        private Button btnOut;
        private Button btnSettings;
        private Button btnEditRates;
        private Button btnStatistics;
        private Button btnEditTypes;
        private Button btnUsers;
        private Button btnDashboard;
        private Button btnMin;
        private Button btnMax;
        private Button btnExit;
        private Panel panelAdminDB;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel3;
    }
}