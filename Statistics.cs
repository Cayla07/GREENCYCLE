using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GREENCYCLE
{
    public partial class Statistics : Form
    {
        private AdminMain1 parentForm;
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb";

        public Statistics(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }   
    }
}
