namespace GREENCYCLE
{
    partial class Rewards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rewards));
            dgvReward = new DataGridView();
            btnLoadFile = new Button();
            btnConnection = new Button();
            btnSearch = new Button();
            tbxItemID = new TextBox();
            tbxPoints = new TextBox();
            label3 = new Label();
            tbxItem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReward).BeginInit();
            SuspendLayout();
            // 
            // dgvReward
            // 
            dgvReward.Anchor = AnchorStyles.None;
            dgvReward.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReward.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReward.BackgroundColor = Color.LemonChiffon;
            dgvReward.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReward.Location = new Point(458, 12);
            dgvReward.Name = "dgvReward";
            dgvReward.RowHeadersWidth = 51;
            dgvReward.Size = new Size(683, 611);
            dgvReward.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.Salmon;
            btnLoadFile.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadFile.Location = new Point(639, 629);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(173, 54);
            btnLoadFile.TabIndex = 57;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Salmon;
            btnConnection.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(458, 629);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(173, 54);
            btnConnection.TabIndex = 56;
            btnConnection.Text = "Connection Test";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(245, 150);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(31, 27);
            btnSearch.TabIndex = 83;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbxItemID
            // 
            tbxItemID.Location = new Point(147, 150);
            tbxItemID.Name = "tbxItemID";
            tbxItemID.Size = new Size(102, 27);
            tbxItemID.TabIndex = 82;
            tbxItemID.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxPoints
            // 
            tbxPoints.Location = new Point(143, 243);
            tbxPoints.Name = "tbxPoints";
            tbxPoints.Size = new Size(253, 27);
            tbxPoints.TabIndex = 81;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(56, 247);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 80;
            label3.Text = "Points:";
            // 
            // tbxItem
            // 
            tbxItem.Location = new Point(129, 210);
            tbxItem.Name = "tbxItem";
            tbxItem.Size = new Size(292, 27);
            tbxItem.TabIndex = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(56, 214);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 78;
            label2.Text = "Item:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(56, 152);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 77;
            label1.Text = "Item ID:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Salmon;
            btnUpdate.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(77, 347);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 39);
            btnUpdate.TabIndex = 84;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(261, 347);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 39);
            btnDelete.TabIndex = 85;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Salmon;
            btnInsert.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(77, 417);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(122, 39);
            btnInsert.TabIndex = 86;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Salmon;
            btnClear.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(261, 417);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 39);
            btnClear.TabIndex = 87;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Rewards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 703);
            Controls.Add(btnClear);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(tbxItemID);
            Controls.Add(tbxPoints);
            Controls.Add(label3);
            Controls.Add(tbxItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadFile);
            Controls.Add(btnConnection);
            Controls.Add(dgvReward);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rewards";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Rewards_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReward).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReward;
        private Button btnLoadFile;
        private Button btnConnection;
        private Button btnSearch;
        private TextBox tbxItemID;
        private TextBox tbxPoints;
        private Label label3;
        private TextBox tbxItem;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnClear;
    }
}