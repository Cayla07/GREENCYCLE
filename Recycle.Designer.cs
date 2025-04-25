namespace GREENCYCLE
{
    partial class Recycle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recycle));
            btnPlastics = new Button();
            btnGlass = new Button();
            btnCans = new Button();
            btnCartons = new Button();
            btnPapers = new Button();
            btnLids = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlastics
            // 
            btnPlastics.BackColor = Color.LimeGreen;
            btnPlastics.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlastics.ForeColor = Color.DarkSlateGray;
            btnPlastics.Image = (Image)resources.GetObject("btnPlastics.Image");
            btnPlastics.Location = new Point(3, 3);
            btnPlastics.Name = "btnPlastics";
            btnPlastics.Size = new Size(370, 302);
            btnPlastics.TabIndex = 0;
            btnPlastics.Text = "Plastic Bottles";
            btnPlastics.TextAlign = ContentAlignment.BottomCenter;
            btnPlastics.UseVisualStyleBackColor = false;
            btnPlastics.Click += btnPlastics_Click;
            // 
            // btnGlass
            // 
            btnGlass.BackColor = Color.LimeGreen;
            btnGlass.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGlass.ForeColor = Color.DarkSlateGray;
            btnGlass.Image = (Image)resources.GetObject("btnGlass.Image");
            btnGlass.Location = new Point(379, 3);
            btnGlass.Name = "btnGlass";
            btnGlass.Size = new Size(370, 302);
            btnGlass.TabIndex = 1;
            btnGlass.Text = "Glass Bottles";
            btnGlass.TextAlign = ContentAlignment.BottomCenter;
            btnGlass.UseVisualStyleBackColor = false;
            btnGlass.Click += btnGlass_Click;
            // 
            // btnCans
            // 
            btnCans.BackColor = Color.LimeGreen;
            btnCans.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCans.ForeColor = Color.DarkSlateGray;
            btnCans.Image = (Image)resources.GetObject("btnCans.Image");
            btnCans.Location = new Point(755, 3);
            btnCans.Name = "btnCans";
            btnCans.Size = new Size(370, 302);
            btnCans.TabIndex = 2;
            btnCans.Text = " Drink Cans";
            btnCans.TextAlign = ContentAlignment.BottomCenter;
            btnCans.UseVisualStyleBackColor = false;
            btnCans.Click += btnCans_Click;
            // 
            // btnCartons
            // 
            btnCartons.BackColor = Color.LimeGreen;
            btnCartons.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCartons.ForeColor = Color.DarkSlateGray;
            btnCartons.Image = (Image)resources.GetObject("btnCartons.Image");
            btnCartons.Location = new Point(3, 311);
            btnCartons.Name = "btnCartons";
            btnCartons.Size = new Size(370, 302);
            btnCartons.TabIndex = 3;
            btnCartons.Text = "Drink Cartons";
            btnCartons.TextAlign = ContentAlignment.BottomCenter;
            btnCartons.UseVisualStyleBackColor = false;
            btnCartons.Click += btnCartons_Click;
            // 
            // btnPapers
            // 
            btnPapers.BackColor = Color.LimeGreen;
            btnPapers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPapers.ForeColor = Color.DarkSlateGray;
            btnPapers.Image = (Image)resources.GetObject("btnPapers.Image");
            btnPapers.Location = new Point(379, 311);
            btnPapers.Name = "btnPapers";
            btnPapers.Size = new Size(370, 302);
            btnPapers.TabIndex = 4;
            btnPapers.Text = "Recycled Papers";
            btnPapers.TextAlign = ContentAlignment.BottomCenter;
            btnPapers.UseVisualStyleBackColor = false;
            btnPapers.Click += btnPapers_Click;
            // 
            // btnLids
            // 
            btnLids.BackColor = Color.LimeGreen;
            btnLids.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLids.ForeColor = Color.DarkSlateGray;
            btnLids.Image = (Image)resources.GetObject("btnLids.Image");
            btnLids.Location = new Point(755, 311);
            btnLids.Name = "btnLids";
            btnLids.Size = new Size(370, 302);
            btnLids.TabIndex = 5;
            btnLids.Text = "Bottle Lids";
            btnLids.TextAlign = ContentAlignment.BottomCenter;
            btnLids.UseVisualStyleBackColor = false;
            btnLids.Click += btnLids_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnLids, 2, 1);
            tableLayoutPanel1.Controls.Add(btnPlastics, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPapers, 1, 1);
            tableLayoutPanel1.Controls.Add(btnGlass, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCartons, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCans, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1129, 617);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 22);
            label1.Name = "label1";
            label1.Size = new Size(533, 42);
            label1.TabIndex = 7;
            label1.Text = "RECYCLABLE MATERIALS";
            // 
            // Recycle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(2, 2);
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 709);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Recycle";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Recycle_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlastics;
        private Button btnGlass;
        private Button btnCans;
        private Button btnCartons;
        private Button btnPapers;
        private Button btnLids;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}