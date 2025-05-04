using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class Wallet : Form
    {
        private UserMain1 parentForm;
        public string Email { get; set; }
        public double TotalPoints { get; set; }

        public Wallet(UserMain1 parent, string email, double totalPoints)
        {
            InitializeComponent();
            this.parentForm = parent;
            Email = email;
            TotalPoints = totalPoints;
        }

        private void panelWallet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Wallet_Load(object sender, EventArgs e)
        {
            lblEmail.Text = Email;
            lblTotal.Text = TotalPoints.ToString("F1");
        }

        private void FLPanelRewards_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
