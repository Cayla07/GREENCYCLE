using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class MonitorUser : UserControl
    {
        private Label lblTitle;
        private Label lblTotalUsers;

        public MonitorUser()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = new Size(220, 90);

            lblTitle = new Label();
            lblTitle.Text = "Registered Users";
            lblTitle.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.AutoSize = true;

            lblTotalUsers = new Label();
            lblTotalUsers.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblTotalUsers.ForeColor = Color.Green;
            lblTotalUsers.Location = new Point(20, 40);
            lblTotalUsers.AutoSize = true;

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblTotalUsers);

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left, int top, int right, int bottom, int widthEllipse, int heightEllipse);

        // ✅ Fix: Use the correct label
        public void SetUserCount(int count)
        {
            lblTotalUsers.Text = count.ToString();
        }
    }
}
