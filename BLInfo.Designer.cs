namespace GREENCYCLE
{
    partial class BLInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BLInfo));
            panel1 = new Panel();
            label4 = new Label();
            tbxBLWeight = new TextBox();
            btnProceed = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxBLWeight);
            panel1.Controls.Add(btnProceed);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(127, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 194);
            panel1.TabIndex = 33;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(231, 76);
            label4.Name = "label4";
            label4.Size = new Size(108, 24);
            label4.TabIndex = 4;
            label4.Text = "kilogram/s";
            // 
            // tbxBLWeight
            // 
            tbxBLWeight.Font = new Font("Arial Rounded MT Bold", 12F);
            tbxBLWeight.Location = new Point(120, 73);
            tbxBLWeight.Multiline = true;
            tbxBLWeight.Name = "tbxBLWeight";
            tbxBLWeight.Size = new Size(105, 32);
            tbxBLWeight.TabIndex = 3;
            tbxBLWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.DarkGreen;
            btnProceed.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProceed.ForeColor = Color.Lime;
            btnProceed.Location = new Point(120, 141);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(219, 34);
            btnProceed.TabIndex = 2;
            btnProceed.Text = "Add to Recycle Bag";
            btnProceed.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(89, 28);
            label3.Name = "label3";
            label3.Size = new Size(304, 23);
            label3.TabIndex = 0;
            label3.Text = "Please input material weight";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            label2.Location = new Point(296, 278);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 32;
            label2.Text = "Bottle Lids";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 310);
            label1.Name = "label1";
            label1.Size = new Size(376, 20);
            label1.TabIndex = 31;
            label1.Text = "Plastic caps from bottles. Collect separately.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(279, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.PaleTurquoise;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(44, 41);
            btnBack.TabIndex = 34;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // BLInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(737, 634);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BLInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BLInfo";
            Load += BLInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox tbxBLWeight;
        private Button btnProceed;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnBack;
    }
}