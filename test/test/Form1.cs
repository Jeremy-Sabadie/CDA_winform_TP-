namespace test
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

        private void btn_test_Click(object sender, EventArgs e)
        {
            btn_test.BackColor = Color.Blue;
            BackColor = Color.Red;
        }


        private void btn_test_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_test_MouseLeave(object sender, EventArgs e)
        {
            btn_test.Width -= 50;
            btn_test.Height -= +20;
        }

        private void btn_test_MouseEnter(object sender, EventArgs e)
        {
            btn_test.Width += 50;
            btn_test.Height += +20;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}