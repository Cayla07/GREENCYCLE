namespace GREENCYCLE
{
    partial class Statistics
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnYear = new Button();
            btnMonth = new Button();
            btnWeek = new Button();
            panel2 = new Panel();
            cbxMunicipality = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.61797762F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.91011F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.61797762F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.85393F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1129, 679);
            tableLayoutPanel1.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1123, 312);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 397);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1123, 279);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnYear);
            panel1.Controls.Add(btnMonth);
            panel1.Controls.Add(btnWeek);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 359);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 32);
            panel1.TabIndex = 4;
            // 
            // btnYear
            // 
            btnYear.Location = new Point(203, 3);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(94, 29);
            btnYear.TabIndex = 2;
            btnYear.Text = "Year";
            btnYear.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            btnMonth.Location = new Point(103, 3);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(94, 29);
            btnMonth.TabIndex = 1;
            btnMonth.Text = "Month";
            btnMonth.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            btnWeek.Location = new Point(3, 3);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(94, 29);
            btnWeek.TabIndex = 0;
            btnWeek.Text = "Week";
            btnWeek.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxMunicipality);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1123, 32);
            panel2.TabIndex = 5;
            // 
            // cbxMunicipality
            // 
            cbxMunicipality.FormattingEnabled = true;
            cbxMunicipality.Location = new Point(0, 3);
            cbxMunicipality.Name = "cbxMunicipality";
            cbxMunicipality.Size = new Size(151, 28);
            cbxMunicipality.TabIndex = 2;
            cbxMunicipality.Text = "Municipality";
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 703);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Statistics";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Statistics_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
       // private OxyPlot.WindowsForms.PlotView UsersPlot;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cbxMunicipality;
        private FlowLayoutPanel flowLayoutPanel2;
       // private OxyPlot.WindowsForms.PlotView plotView1;
        private Panel panel1;
        private Button btnWeek;
        private Panel panel2;
        private Button btnYear;
        private Button btnMonth;
    }
}