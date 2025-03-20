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
            panel1 = new Panel();
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
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 765);
            panel1.TabIndex = 21;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1452, 765);
            Controls.Add(panel1);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion
        private Button btnMin;
        private Button btnMax;
        private Button btnExit;
        private Panel panel1;
    }
}