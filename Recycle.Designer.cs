namespace GREENCYCLE
{
    partial class Recycle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recycle));
            btnPlastics = new Button();
            btnGlass = new Button();
            btnCans = new Button();
            btnCartons = new Button();
            btnPapers = new Button();
            btnLids = new Button();
            SuspendLayout();
            // 
            // btnPlastics
            // 
            btnPlastics.BackColor = Color.LimeGreen;
            btnPlastics.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlastics.ForeColor = Color.DarkSlateGray;
            btnPlastics.Image = (Image)resources.GetObject("btnPlastics.Image");
            btnPlastics.Location = new Point(63, 25);
            btnPlastics.Name = "btnPlastics";
            btnPlastics.Size = new Size(313, 275);
            btnPlastics.TabIndex = 0;
            btnPlastics.Text = "Plastic Bottles";
            btnPlastics.TextAlign = ContentAlignment.BottomCenter;
            btnPlastics.UseVisualStyleBackColor = false;
            // 
            // btnGlass
            // 
            btnGlass.BackColor = Color.LimeGreen;
            btnGlass.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGlass.ForeColor = Color.DarkSlateGray;
            btnGlass.Image = (Image)resources.GetObject("btnGlass.Image");
            btnGlass.Location = new Point(412, 25);
            btnGlass.Name = "btnGlass";
            btnGlass.Size = new Size(313, 275);
            btnGlass.TabIndex = 1;
            btnGlass.Text = "Glass Bottles";
            btnGlass.TextAlign = ContentAlignment.BottomCenter;
            btnGlass.UseVisualStyleBackColor = false;
            // 
            // btnCans
            // 
            btnCans.BackColor = Color.LimeGreen;
            btnCans.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCans.ForeColor = Color.DarkSlateGray;
            btnCans.Image = (Image)resources.GetObject("btnCans.Image");
            btnCans.Location = new Point(771, 25);
            btnCans.Name = "btnCans";
            btnCans.Size = new Size(313, 275);
            btnCans.TabIndex = 2;
            btnCans.Text = "Drink Cans";
            btnCans.TextAlign = ContentAlignment.BottomCenter;
            btnCans.UseVisualStyleBackColor = false;
            // 
            // btnCartons
            // 
            btnCartons.BackColor = Color.LimeGreen;
            btnCartons.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCartons.ForeColor = Color.DarkSlateGray;
            btnCartons.Image = (Image)resources.GetObject("btnCartons.Image");
            btnCartons.Location = new Point(63, 354);
            btnCartons.Name = "btnCartons";
            btnCartons.Size = new Size(313, 275);
            btnCartons.TabIndex = 3;
            btnCartons.Text = "Drink Cartons";
            btnCartons.TextAlign = ContentAlignment.BottomCenter;
            btnCartons.UseVisualStyleBackColor = false;
            // 
            // btnPapers
            // 
            btnPapers.BackColor = Color.LimeGreen;
            btnPapers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPapers.ForeColor = Color.DarkSlateGray;
            btnPapers.Image = (Image)resources.GetObject("btnPapers.Image");
            btnPapers.Location = new Point(412, 354);
            btnPapers.Name = "btnPapers";
            btnPapers.Size = new Size(313, 275);
            btnPapers.TabIndex = 4;
            btnPapers.Text = "Recycled Papers";
            btnPapers.TextAlign = ContentAlignment.BottomCenter;
            btnPapers.UseVisualStyleBackColor = false;
            // 
            // btnLids
            // 
            btnLids.BackColor = Color.LimeGreen;
            btnLids.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLids.ForeColor = Color.DarkSlateGray;
            btnLids.Image = (Image)resources.GetObject("btnLids.Image");
            btnLids.Location = new Point(771, 354);
            btnLids.Name = "btnLids";
            btnLids.Size = new Size(313, 275);
            btnLids.TabIndex = 5;
            btnLids.Text = "Bottle Lids";
            btnLids.TextAlign = ContentAlignment.BottomCenter;
            btnLids.UseVisualStyleBackColor = false;
            // 
            // Recycle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1153, 700);
            Controls.Add(btnLids);
            Controls.Add(btnPapers);
            Controls.Add(btnCartons);
            Controls.Add(btnCans);
            Controls.Add(btnGlass);
            Controls.Add(btnPlastics);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Recycle";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
          //  Load += Recycle_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlastics;
        private Button btnGlass;
        private Button btnCans;
        private Button btnCartons;
        private Button btnPapers;
        private Button btnLids;
    }
}