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
    public partial class GBInfo : Form
    {
        public GBInfo()
        {
            InitializeComponent();
        }

        private void GBInfo_Load(object sender, EventArgs e)
        {
            btnBack.Click += new EventHandler(btnBack_Click);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxWeight_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
