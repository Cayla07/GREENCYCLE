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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorUsers));
            label8 = new Label();
            panel7 = new Panel();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(115, 94);
            label8.Name = "label8";
            label8.Size = new Size(188, 48);
            label8.TabIndex = 33;
            label8.Text = "User List";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(108, 167);
            panel7.Name = "panel7";
            panel7.Size = new Size(1097, 475);
            panel7.TabIndex = 32;
            // 
            // MonitorUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 736);
            Controls.Add(label8);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonitorUsers";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Panel panel7;
    }
}