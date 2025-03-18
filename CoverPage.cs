namespace GREENCYCLE
{
    public partial class CoverPage : Form
    {
        public CoverPage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UserTypePage form2 = new UserTypePage();
            form2.Show();
            this.Hide();
        }
    }
}
