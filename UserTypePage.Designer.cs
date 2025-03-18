namespace GREENCYCLE
{
    partial class UserTypePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTypePage));
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            btnProceed = new Button();
            cmbType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGreen;
            label1.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(473, 115);
            label1.Name = "label1";
            label1.Size = new Size(376, 85);
            label1.TabIndex = 2;
            label1.Text = "WELCOME";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1186, 7);
            button2.Name = "button2";
            button2.Size = new Size(38, 34);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1230, 9);
            button1.Name = "button1";
            button1.Size = new Size(29, 30);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PaleGreen;
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1274, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(27, 25);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(btnProceed);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(423, 454);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 194);
            panel1.TabIndex = 12;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.DarkGreen;
            btnProceed.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.ForeColor = Color.Lime;
            btnProceed.Location = new Point(372, 136);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(103, 43);
            btnProceed.TabIndex = 2;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(50, 77);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(343, 27);
            cmbType.TabIndex = 1;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(50, 36);
            label2.Name = "label2";
            label2.Size = new Size(246, 24);
            label2.TabIndex = 0;
            label2.Text = "Please select a user type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleGreen;
            label3.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(423, 319);
            label3.Name = "label3";
            label3.Size = new Size(490, 85);
            label3.TabIndex = 13;
            label3.Text = "GREENCYCLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleGreen;
            label4.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(589, 213);
            label4.Name = "label4";
            label4.Size = new Size(128, 85);
            label4.TabIndex = 14;
            label4.Text = "TO";
            // 
            // UserTypePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1313, 736);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserTypePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Button btnExit;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private Label label4;
        private Button btnProceed;
    }
}