namespace modal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            string title = (string)btnF1.Text;
            Fen2 fen = new Fen2();
            fen.ShowDialog();
            fen.Text = title;

        }
    }
}