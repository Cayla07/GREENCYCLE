﻿namespace GREENCYCLE
{
    partial class GBInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GBInfo));
            panel1 = new Panel();
            label4 = new Label();
            tbxGBWeight = new TextBox();
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
            panel1.Controls.Add(tbxGBWeight);
            panel1.Controls.Add(btnProceed);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(122, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 194);
            panel1.TabIndex = 17;
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
            // tbxGBWeight
            // 
            tbxGBWeight.Font = new Font("Arial Rounded MT Bold", 12F);
            tbxGBWeight.Location = new Point(120, 73);
            tbxGBWeight.Multiline = true;
            tbxGBWeight.Name = "tbxGBWeight";
            tbxGBWeight.Size = new Size(105, 32);
            tbxGBWeight.TabIndex = 3;
            tbxGBWeight.TextAlign = HorizontalAlignment.Center;
           // tbxGBWeight.TextChanged += tbxWeight_TextChanged;
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
           // btnProceed.Click += btnProceed_Click;
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
            label2.Location = new Point(274, 272);
            label2.Name = "label2";
            label2.Size = new Size(182, 32);
            label2.TabIndex = 16;
            label2.Text = "Glass Bottles";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 313);
            label1.Name = "label1";
            label1.Size = new Size(428, 40);
            label1.TabIndex = 15;
            label1.Text = "Clear or colored bottles from beverages or sauces. \r\n                            Avoid broken pieces.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
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
            btnBack.TabIndex = 19;
            btnBack.UseVisualStyleBackColor = false;
          //  btnBack.Click += btnBack_Click;
            // 
            // GBInfo
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
            Name = "GBInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += GBInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox tbxGBWeight;
        private Button btnProceed;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnBack;
    }
}