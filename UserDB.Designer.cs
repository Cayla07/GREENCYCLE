namespace GREENCYCLE
{
    partial class UserDB
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
            UsersPlot = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(UsersPlot, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.891016F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.28277F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel1.Size = new Size(1129, 679);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UsersPlot
            // 
            UsersPlot.Anchor = AnchorStyles.None;
            UsersPlot.BackColor = Color.LightCyan;
            UsersPlot.Location = new Point(4, 46);
            UsersPlot.Name = "UsersPlot";
            UsersPlot.PanCursor = Cursors.Hand;
            UsersPlot.Size = new Size(555, 342);
            UsersPlot.TabIndex = 0;
            UsersPlot.Text = "UsersPlot";
            UsersPlot.ZoomHorizontalCursor = Cursors.SizeWE;
            UsersPlot.ZoomRectangleCursor = Cursors.SizeNWSE;
            UsersPlot.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // UserDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 703);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDB";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += UserDB_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private OxyPlot.WindowsForms.PlotView UsersPlot;
    }
}