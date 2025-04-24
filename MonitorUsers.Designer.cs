namespace GREENCYCLE
{
    partial class MonitorUsers
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
            dataGridView1 = new DataGridView();
            btnConnection = new Button();
            btnLoadFile = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1129, 511);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Salmon;
            btnConnection.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(12, 637);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(173, 54);
            btnConnection.TabIndex = 1;
            btnConnection.Text = "Connection Test";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.Salmon;
            btnLoadFile.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadFile.Location = new Point(191, 637);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(173, 54);
            btnLoadFile.TabIndex = 2;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 3;
            label1.Text = "USERLIST";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LemonChiffon;
            comboBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 31);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "       Province";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LemonChiffon;
            comboBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(190, 50);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(174, 31);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "       Province";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.LemonChiffon;
            comboBox3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(370, 50);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(174, 31);
            comboBox3.TabIndex = 7;
            comboBox3.Text = "       Province";
            // 
            // MonitorUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 703);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnLoadFile);
            Controls.Add(btnConnection);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonitorUsers";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += MonitorUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnConnection;
        private Button btnLoadFile;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}