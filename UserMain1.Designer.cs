namespace GREENCYCLE
{
    partial class UserMain1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain1));
            panelMenu = new Panel();
            btnHome = new Button();
            btnOut = new Button();
            btnSettings = new Button();
            btnWallet = new Button();
            btnHistory = new Button();
            btnTransaction = new Button();
            btnRecycle = new Button();
            btnDashboard = new Button();
            paneldisplayDB = new Panel();
            btnMin = new Button();
            btnExit = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Green;
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnOut);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnWallet);
            panelMenu.Controls.Add(btnHistory);
            panelMenu.Controls.Add(btnTransaction);
            panelMenu.Controls.Add(btnRecycle);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.ForestGreen;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(299, 765);
            panelMenu.TabIndex = 21;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Green;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(299, 218);
            btnHome.TabIndex = 0;
            btnHome.Text = "GREENCYCLE";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnOut
            // 
            btnOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOut.BackColor = Color.Transparent;
            btnOut.BackgroundImageLayout = ImageLayout.None;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Font = new Font("Cooper Black", 12F);
            btnOut.ForeColor = Color.White;
            btnOut.Image = (Image)resources.GetObject("btnOut.Image");
            btnOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnOut.Location = new Point(107, 712);
            btnOut.Name = "btnOut";
            btnOut.Padding = new Padding(10, 0, 0, 0);
            btnOut.Size = new Size(200, 53);
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
            btnSettings.Font = new Font("Cooper Black", 12F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(107, 663);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(200, 53);
            btnSettings.TabIndex = 27;
            btnSettings.Text = " PROFILE";
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
            btnWallet.Font = new Font("Cooper Black", 12F);
            btnWallet.ForeColor = Color.White;
            btnWallet.Image = (Image)resources.GetObject("btnWallet.Image");
            btnWallet.ImageAlign = ContentAlignment.MiddleLeft;
            btnWallet.Location = new Point(0, 366);
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
            btnHistory.Font = new Font("Cooper Black", 12F);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 508);
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
            btnTransaction.Font = new Font("Cooper Black", 12F);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.Image = (Image)resources.GetObject("btnTransaction.Image");
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(0, 437);
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
            btnRecycle.Font = new Font("Cooper Black", 12F);
            btnRecycle.ForeColor = Color.White;
            btnRecycle.Image = (Image)resources.GetObject("btnRecycle.Image");
            btnRecycle.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecycle.Location = new Point(0, 295);
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
            btnDashboard.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 224);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(307, 65);
            btnDashboard.TabIndex = 22;
            btnDashboard.Text = "   DASHBOARD";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // paneldisplayDB
            // 
            paneldisplayDB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paneldisplayDB.BackColor = Color.PaleGreen;
            paneldisplayDB.Location = new Point(299, 56);
            paneldisplayDB.Name = "paneldisplayDB";
            paneldisplayDB.Size = new Size(1153, 709);
            paneldisplayDB.TabIndex = 26;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.PaleGreen;
            btnMin.BackgroundImageLayout = ImageLayout.Center;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(1369, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(38, 34);
            btnMin.TabIndex = 25;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click_1;
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
            btnExit.Click += btnExit_Click_1;
            // 
            // UserMain1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1452, 765);
            Controls.Add(paneldisplayDB);
            Controls.Add(btnMin);
            Controls.Add(btnExit);
            Controls.Add(panelMenu);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMain1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += UserMain1_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button btnDashboard;
        private Button btnRecycle;
        private Button btnWallet;
        private Button btnHistory;
        private Button btnTransaction;
        private Button btnOut;
        private Button btnSettings;
        private Panel paneldisplayDB;
        private Button btnHome;
        private Button btnMin;
        private Button btnExit;
    }
}