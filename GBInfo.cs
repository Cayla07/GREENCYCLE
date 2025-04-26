using System;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class GBInfo : Form
    {
        private readonly Recycle recycleForm;
        private readonly string materialName;

        public GBInfo(string material, Recycle parent)
        {
            InitializeComponent();
            materialName = material ?? throw new ArgumentNullException(nameof(material));
            recycleForm = parent ?? throw new ArgumentNullException(nameof(parent));
        }

        private void GBInfo_Load(object sender, EventArgs e)
        {
            // These should ideally be assigned in InitializeComponent() or constructor, not Load event.
            btnBack.Click += BtnBack_Click;
            btnProceed.Click += BtnProceed_Click;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxGBWeight.Text, out double weight) && weight > 0)
            {
                recycleForm.AddToRecycleBag(materialName, weight);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxGBWeight.Clear();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
