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
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(FLPanelUser, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
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
            FLPanelUser.Anchor = AnchorStyles.None;
            FLPanelUser.AutoScroll = true;
            FLPanelUser.BackColor = Color.PaleTurquoise;
            FLPanelUser.FlowDirection = FlowDirection.TopDown;
            FLPanelUser.Location = new Point(3, 39);
            FLPanelUser.Name = "FLPanelUser";
            FLPanelUser.Size = new Size(1123, 297);
            FLPanelUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 3);
            label1.Name = "label1";
            label1.Size = new Size(120, 29);
            label1.TabIndex = 1;
            label1.Text = "UserList";
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
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel FLPanelUser;
        private Label label1;
    }
}