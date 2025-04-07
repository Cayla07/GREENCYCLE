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
    public partial class Recycle : Form
    {
        private UserMain1 parentForm;
        public Recycle(UserMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }
    private void Recycle_Load(object sender, EventArgs e)
        {

        }
    }
}
