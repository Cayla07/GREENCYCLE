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
    public partial class UserSignUp1 : Form
    {
        public UserSignUp1()
        {
            InitializeComponent();
        }

        private void UserSignUp1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            tbxFullName.KeyDown += new KeyEventHandler(tbxFullName_KeyDown);
            tbxAge.KeyDown += new KeyEventHandler(tbxAge_KeyDown);

            cbxPayMeth.Items.Add("Gcash");
            cbxBarangay.Items.Add("Umapad");
            cbxBarangay.Items.Add("Opao");
            cbxMunicipality.Items.Add("Mandaue");
            cbxProvince.Items.Add("Cebu");
        }

        private void tbxFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxAge.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbxAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxPhoneNum.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (this.ParentForm is Main0 functionalityForm)
            {
                functionalityForm.LoadFormIntoPanel(new UserSignUp());
            }
        }

        private void linkUserLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Main0 functionalityForm)
            {
                functionalityForm.LoadFormIntoPanel(new UserLogIn());
            }
        }
    }
}
