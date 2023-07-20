namespace hello_wold
{
    public partial class Frm_container : Form
    {
        public Frm_container()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_container_Load(object sender, EventArgs e)
        {

        }

        private void btn_quit_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_quit_MouseClick_1(object sender, MouseEventArgs e)
        {
            DialogResult res = MessageBox.Show("confirmez vous la fermeture de l'application ?", "title", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Frm_container_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("confirmez vous la fermeture de l'application ?", "title", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
            else e.Cancel;


        }
    }
}