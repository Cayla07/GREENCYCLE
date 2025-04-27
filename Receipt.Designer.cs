namespace GREENCYCLE
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelTotal = new Panel();
            lblTotal = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblFullName = new Label();
            lblEmail = new Label();
            panel4 = new Panel();
            btnExit = new Button();
            panelReceipt = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panelTotal.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(188, 20);
            label1.Name = "label1";
            label1.Size = new Size(264, 39);
            label1.TabIndex = 1;
            label1.Text = "GREENCYCLE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 3);
            tableLayoutPanel1.Controls.Add(panelTotal, 0, 5);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panelReceipt, 0, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.35551643F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.513134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.95972F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.30472851F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.7092819F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0518246F));
            tableLayoutPanel1.Size = new Size(557, 596);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 31);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.Location = new Point(483, 7);
            label4.Name = "label4";
            label4.Size = new Size(45, 18);
            label4.TabIndex = 2;
            label4.Text = "Point";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(243, 8);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 1;
            label3.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(2, 7);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 0;
            label2.Text = "Material";
            // 
            // panelTotal
            // 
            panelTotal.Controls.Add(lblTotal);
            panelTotal.Controls.Add(label5);
            panelTotal.Dock = DockStyle.Fill;
            panelTotal.Location = new Point(3, 536);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(551, 57);
            panelTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.PaleGreen;
            lblTotal.Font = new Font("Arial", 13.5F, FontStyle.Bold);
            lblTotal.Location = new Point(469, 16);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(79, 27);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "label4";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PaleGreen;
            label5.Font = new Font("Arial", 13.5F, FontStyle.Bold);
            label5.Location = new Point(313, 14);
            label5.Name = "label5";
            label5.Size = new Size(152, 27);
            label5.TabIndex = 4;
            label5.Text = "Total Points:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 98);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblFullName);
            panel2.Controls.Add(lblEmail);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 71);
            panel2.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.PaleGreen;
            lblFullName.Font = new Font("Arial", 13.5F, FontStyle.Bold);
            lblFullName.Location = new Point(3, 9);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 27);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "label2";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.PaleGreen;
            lblEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(3, 47);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 17);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label3";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnExit);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(551, 37);
            panel4.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PaleGreen;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(504, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(44, 31);
            btnExit.TabIndex = 35;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelReceipt
            // 
            panelReceipt.Dock = DockStyle.Fill;
            panelReceipt.FlowDirection = FlowDirection.TopDown;
            panelReceipt.Location = new Point(3, 264);
            panelReceipt.Name = "panelReceipt";
            panelReceipt.Size = new Size(551, 266);
            panelReceipt.TabIndex = 6;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(581, 620);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label lblEmail;
        private Label lblFullName;
        private Panel panel3;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panelTotal;
        private Label lblTotal;
        private Label label5;
        private Button btnExit;
        private Panel panel4;
        private FlowLayoutPanel panelReceipt;
    }
}