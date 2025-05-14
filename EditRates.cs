using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class EditRates : Form
    {
        private AdminMain1 parentForm;
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;

        public EditRates(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void EditRates_Load(object sender, EventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
            myConn.Open();
            MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            LoadMaterialPoints();
        }

        private void LoadMaterialPoints()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
            da = new OleDbDataAdapter("SELECT * FROM MaterialPoints", myConn);
            ds = new DataSet();

            myConn.Open();
            da.Fill(ds, "MaterialPoints");
            dgvEditRates.DataSource = ds.Tables["MaterialPoints"];
            myConn.Close();

            dgvEditRates.Columns["ID"].Visible = false; // Hide ID
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
            string query = "UPDATE MaterialPoints SET MaterialName = @MaterialName, Points = @Points WHERE ID = @ID";

            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@MaterialName", tbxMaterial.Text);
            cmd.Parameters.AddWithValue("@Points", float.Parse(tbxPoints.Text));
            cmd.Parameters.AddWithValue("@ID", int.Parse(tbxID.Text));

            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

            MessageBox.Show("Record updated successfully!");
            LoadMaterialPoints(); 
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxID.Text))
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
                string query = "DELETE FROM MaterialPoints WHERE ID = @ID";

                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbxID.Text));

                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();

                MessageBox.Show("Record deleted successfully!");
                LoadMaterialPoints(); 
            }
        }

        private void dgvEditRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dgvEditRates.Rows[indexRow];

                tbxID.Text = row.Cells["ID"].Value.ToString();
                tbxMaterial.Text = row.Cells["MaterialName"].Value.ToString();
                tbxPoints.Text = row.Cells["Points"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            tbxID.Clear();
            tbxMaterial.Clear();
            tbxPoints.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = tbxID.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchID))
            {
                return;
            }

            try
            {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;";

                string query = "SELECT MaterialID, MaterialName, Points FROM MaterialPoints WHERE MaterialID = ?";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", searchID);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "MaterialSearch");

                        dgvEditRates.DataSource = ds.Tables["MaterialSearch"];
                        dgvEditRates.Columns["MaterialID"].Visible = false; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching material: " + ex.Message);
            }
        }
    }
}
