namespace GREENCYCLE
{
    partial class Wallet
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
            tlpWallet = new TableLayoutPanel();
            panelWallet = new Panel();
            btnRedeem = new Button();
            label2 = new Label();
            lblTotal = new Label();
            lblEmail = new Label();
            FLPanelRewards = new FlowLayoutPanel();
            tlpWallet.SuspendLayout();
            panelWallet.SuspendLayout();
            SuspendLayout();
            // 
            // tlpWallet
            // 
            tlpWallet.ColumnCount = 1;
            tlpWallet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpWallet.Controls.Add(panelWallet, 0, 1);
            tlpWallet.Controls.Add(FLPanelRewards, 0, 0);
            tlpWallet.Location = new Point(12, 12);
            tlpWallet.Name = "tlpWallet";
            tlpWallet.RowCount = 2;
            tlpWallet.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpWallet.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpWallet.Size = new Size(1129, 685);
            tlpWallet.TabIndex = 0;
            // 
            // panelWallet
            // 
            panelWallet.Anchor = AnchorStyles.None;
            panelWallet.Controls.Add(btnRedeem);
            panelWallet.Controls.Add(label2);
            panelWallet.Controls.Add(lblTotal);
            panelWallet.Controls.Add(lblEmail);
            panelWallet.Location = new Point(277, 352);
            panelWallet.Name = "panelWallet";
            panelWallet.Size = new Size(574, 322);
            panelWallet.TabIndex = 1;
            // 
            // btnRedeem
            // 
            btnRedeem.BackColor = Color.Red;
            btnRedeem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedeem.Location = new Point(470, 283);
            btnRedeem.Name = "btnRedeem";
            btnRedeem.Size = new Size(101, 36);
            btnRedeem.TabIndex = 4;
            btnRedeem.Text = "Redeem";
            btnRedeem.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 114);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 3;
            label2.Text = "TotalPoints";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(202, 201);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(164, 62);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Points";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(13, 33);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // FLPanelRewards
            // 
            FLPanelRewards.AutoScroll = true;
            FLPanelRewards.FlowDirection = FlowDirection.TopDown;
            FLPanelRewards.Location = new Point(3, 3);
            FLPanelRewards.Name = "FLPanelRewards";
            FLPanelRewards.Size = new Size(1123, 336);
            FLPanelRewards.TabIndex = 0;
            // 
            // Wallet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 709);
            Controls.Add(tlpWallet);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Wallet";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Wallet_Load;
            tlpWallet.ResumeLayout(false);
            panelWallet.ResumeLayout(false);
            panelWallet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpWallet;
        private FlowLayoutPanel FLPanelRewards;
        private Panel panelWallet;
        private Label lblEmail;
        private Label label2;
        private Label lblTotal;
        private Button btnRedeem;
    }
}