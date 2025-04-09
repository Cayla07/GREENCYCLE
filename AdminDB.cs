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
    public partial class AdminDB : Form
    {
        private AdminMain1 parentForm;
        public AdminDB(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void AdminDB_Load(object sender, EventArgs e)
        {

        }
    }
}
