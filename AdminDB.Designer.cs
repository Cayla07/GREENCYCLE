namespace GREENCYCLE
{
    partial class AdminDB
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
            FLPanelUser = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(FLPanelUser, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.357231F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.64402F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.35723066F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6415176F));
            tableLayoutPanel1.Size = new Size(1129, 679);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FLPanelUser
            // 
            FLPanelUser.AutoScroll = true;
            FLPanelUser.Location = new Point(3, 378);
            FLPanelUser.Name = "FLPanelUser";
            FLPanelUser.Size = new Size(558, 298);
            FLPanelUser.TabIndex = 0;
            // 
            // AdminDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 703);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDB";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += AdminDB_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel FLPanelUser;
    }
}