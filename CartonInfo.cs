using System;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class CartonInfo : Form
    {
        private readonly Recycle recycleForm;
        private readonly string materialName;

        public CartonInfo(string material, Recycle parent)
        {
            InitializeComponent();
            materialName = material ?? throw new ArgumentNullException(nameof(material));
            recycleForm = parent ?? throw new ArgumentNullException(nameof(parent));
        }

        private void CartonInfo_Load(object sender, EventArgs e)
        {
            btnBack.Click += BtnBack_Click;
            btnProceed.Click += BtnProceed_Click;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxCWeight.Text, out double weight) && weight > 0)
            {
                recycleForm.AddToRecycleBag(materialName, weight);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCWeight.Clear();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
