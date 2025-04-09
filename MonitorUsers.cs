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
    public partial class MonitorUsers : Form
    {
        private AdminMain1 parentForm;
        public MonitorUsers(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void MonitorUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
