namespace GREENCYCLE
{
    partial class MonitorUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorUser));
            btnUser = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Location = new Point(12, 35);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(271, 228);
            btnUser.TabIndex = 3;
            btnUser.UseVisualStyleBackColor = true;
        //    btnUser.Click += btnUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(300, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MonitorUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(btnUser);
            Controls.Add(pictureBox1);
            Name = "MonitorUser";
            Size = new Size(558, 298);
        //    Load += MonitorUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUser;
        private PictureBox pictureBox1;
    }
}
