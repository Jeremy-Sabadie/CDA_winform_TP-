namespace calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            firstNb.Clear();
            secondNb.Clear();
            result.Text = string.Empty;
            firstNb.Focus();

        }

        private void equal_Click(object sender, EventArgs e)
        {
            result.Text = (Convert.ToInt32(firstNb.Text) + Convert.ToInt32(secondNb.Text)).ToString();
        }

        private void firstNb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void firstNb_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                e.Handled = true;
                btnCe.PerformClick();
            }
        }
    }
}