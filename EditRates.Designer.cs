namespace GREENCYCLE
{
    partial class EditRates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRates));
            label10 = new Label();
            dgvEditRates = new DataGridView();
            tbxPoints = new TextBox();
            label3 = new Label();
            tbxMaterial = new TextBox();
            label2 = new Label();
            btnLoadFile = new Button();
            btnConnection = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            tbxID = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEditRates).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(244, 74);
            label10.Name = "label10";
            label10.Size = new Size(160, 32);
            label10.TabIndex = 68;
            label10.Text = "Edit Rates";
            // 
            // dgvEditRates
            // 
            dgvEditRates.Anchor = AnchorStyles.None;
            dgvEditRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditRates.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEditRates.BackgroundColor = Color.LemonChiffon;
            dgvEditRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditRates.Location = new Point(604, 64);
            dgvEditRates.Name = "dgvEditRates";
            dgvEditRates.RowHeadersWidth = 51;
            dgvEditRates.Size = new Size(439, 362);
            dgvEditRates.TabIndex = 78;
            dgvEditRates.CellContentClick += dgvEditRates_CellContentClick;
            // 
            // tbxPoints
            // 
            tbxPoints.Location = new Point(246, 285);
            tbxPoints.Name = "tbxPoints";
            tbxPoints.Size = new Size(158, 27);
            tbxPoints.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(159, 289);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 81;
            label3.Text = "Points:";
            // 
            // tbxMaterial
            // 
            tbxMaterial.Location = new Point(329, 239);
            tbxMaterial.Name = "tbxMaterial";
            tbxMaterial.Size = new Size(195, 27);
            tbxMaterial.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(159, 243);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 79;
            label2.Text = "Material Name:";
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.Salmon;
            btnLoadFile.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadFile.Location = new Point(568, 568);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(173, 54);
            btnLoadFile.TabIndex = 86;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Salmon;
            btnConnection.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(387, 568);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(173, 54);
            btnConnection.TabIndex = 85;
            btnConnection.Text = "Connection Test";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Salmon;
            btnUpdate.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(216, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 37);
            btnUpdate.TabIndex = 87;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(386, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 37);
            btnDelete.TabIndex = 88;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbxID
            // 
            tbxID.Location = new Point(295, 156);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(98, 27);
            tbxID.TabIndex = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(159, 160);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 89;
            label1.Text = "Material ID:";
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(390, 156);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(31, 27);
            btnSearch.TabIndex = 91;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // EditRates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 703);
            Controls.Add(btnSearch);
            Controls.Add(tbxID);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoadFile);
            Controls.Add(btnConnection);
            Controls.Add(tbxPoints);
            Controls.Add(label3);
            Controls.Add(tbxMaterial);
            Controls.Add(label2);
            Controls.Add(dgvEditRates);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditRates";
            StartPosition = FormStartPosition.CenterScreen;
            Load += EditRates_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditRates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private DataGridView dgvEditRates;
        private TextBox tbxPoints;
        private Label label3;
        private TextBox tbxMaterial;
        private Label label2;
        private Button btnLoadFile;
        private Button btnConnection;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox tbxID;
        private Label label1;
        private Button btnSearch;
    }
}