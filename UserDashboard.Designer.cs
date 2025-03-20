namespace GREENCYCLE
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            btnMin = new Button();
            btnMax = new Button();
            btnExit = new Button();
            panelMenu = new Panel();
            btnOut = new Button();
            btnSettings = new Button();
            btnWallet = new Button();
            btnHistory = new Button();
            btnTransaction = new Button();
            btnRecycle = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            label1 = new Label();
            UserProfile = new PictureBox();
            panel2 = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserProfile).BeginInit();
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
            btnMin.Location = new Point(1334, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(38, 34);
            btnMin.TabIndex = 20;
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
            btnMax.TabIndex = 19;
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
            btnExit.TabIndex = 18;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Green;
            panelMenu.Controls.Add(btnOut);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnWallet);
            panelMenu.Controls.Add(btnHistory);
            panelMenu.Controls.Add(btnTransaction);
            panelMenu.Controls.Add(btnRecycle);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.ForestGreen;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(299, 765);
            panelMenu.TabIndex = 21;
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
            // btnWallet
            // 
            btnWallet.Anchor = AnchorStyles.Left;
            btnWallet.BackColor = Color.Transparent;
            btnWallet.BackgroundImageLayout = ImageLayout.None;
            btnWallet.FlatStyle = FlatStyle.Flat;
            btnWallet.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWallet.ForeColor = Color.White;
            btnWallet.Image = (Image)resources.GetObject("btnWallet.Image");
            btnWallet.ImageAlign = ContentAlignment.MiddleLeft;
            btnWallet.Location = new Point(3, 327);
            btnWallet.Name = "btnWallet";
            btnWallet.Padding = new Padding(10, 0, 0, 0);
            btnWallet.Size = new Size(307, 65);
            btnWallet.TabIndex = 26;
            btnWallet.Text = " MY WALLET";
            btnWallet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWallet.UseVisualStyleBackColor = false;
            btnWallet.Click += btnWallet_Click;
            // 
            // btnHistory
            // 
            btnHistory.Anchor = AnchorStyles.Left;
            btnHistory.BackColor = Color.Transparent;
            btnHistory.BackgroundImageLayout = ImageLayout.None;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(3, 469);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(10, 0, 0, 0);
            btnHistory.Size = new Size(307, 65);
            btnHistory.TabIndex = 25;
            btnHistory.Text = "HISTORY";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Anchor = AnchorStyles.Left;
            btnTransaction.BackColor = Color.Transparent;
            btnTransaction.BackgroundImageLayout = ImageLayout.None;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.Image = (Image)resources.GetObject("btnTransaction.Image");
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(3, 398);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Padding = new Padding(10, 0, 0, 0);
            btnTransaction.Size = new Size(307, 65);
            btnTransaction.TabIndex = 24;
            btnTransaction.Text = "TRANSACTION";
            btnTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnRecycle
            // 
            btnRecycle.Anchor = AnchorStyles.Left;
            btnRecycle.BackColor = Color.Transparent;
            btnRecycle.BackgroundImageLayout = ImageLayout.None;
            btnRecycle.FlatStyle = FlatStyle.Flat;
            btnRecycle.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecycle.ForeColor = Color.White;
            btnRecycle.Image = (Image)resources.GetObject("btnRecycle.Image");
            btnRecycle.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecycle.Location = new Point(3, 256);
            btnRecycle.Name = "btnRecycle";
            btnRecycle.Padding = new Padding(10, 0, 0, 0);
            btnRecycle.Size = new Size(307, 65);
            btnRecycle.TabIndex = 23;
            btnRecycle.Text = " RECYCLE";
            btnRecycle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecycle.UseVisualStyleBackColor = false;
            btnRecycle.Click += btnRecycle_Click;
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
            label1.Location = new Point(75, 110);
            label1.Name = "label1";
            label1.Size = new Size(139, 24);
            label1.TabIndex = 0;
            label1.Text = "< username >";
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
            // panel2
            // 
            panel2.Location = new Point(298, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(1154, 722);
            panel2.TabIndex = 22;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1452, 765);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnExit);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMin;
        private Button btnMax;
        private Button btnExit;
        private Panel panelMenu;
        private Panel panel1;
        private Button btnDashboard;
        private Button btnRecycle;
        private Button btnWallet;
        private Button btnHistory;
        private Button btnTransaction;
        private Panel panel2;
        private Button btnOut;
        private Button btnSettings;
        private PictureBox UserProfile;
        private Label label1;
    }
}