using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GREENCYCLE
{
    public partial class UserTypePage : Form
    {
        public UserTypePage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Application Users");
            cmbType.Items.Add("Admin");
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem != null)
            {
                string selectedUserType = cmbType.SelectedItem.ToString();

                if (selectedUserType == "Application Users")
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }

            }
        }
    }
}

