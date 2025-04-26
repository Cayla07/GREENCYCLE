using System;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class PBInfo : Form
    {
        private readonly Recycle recycleForm;
        private readonly string materialName;

        public PBInfo(string material, Recycle parent)
        {
            InitializeComponent();
            materialName = material ?? throw new ArgumentNullException(nameof(material));
            recycleForm = parent ?? throw new ArgumentNullException(nameof(parent));
        }

        private void PBInfo_Load(object sender, EventArgs e)
        {
            // These should ideally be assigned in InitializeComponent() or constructor, not Load event.
            btnBack.Click += BtnBack_Click;
            btnProceed.Click += BtnProceed_Click;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxPBWeight.Text, out double weight) && weight > 0)
            {
                recycleForm.AddToRecycleBag(materialName, weight);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxPBWeight.Clear();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxPBWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
