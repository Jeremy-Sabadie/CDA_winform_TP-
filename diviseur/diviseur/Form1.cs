namespace diviseur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void divis�_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void btn_calc_Click(object sender, EventArgs e)
        {//V�rification au clic sur le boutton q'aucun des champs n'est �gal � 0:


            if ((numerateur.Text == "" || denominateur.Text == "") || (numerateur.Text == "0" || denominateur.Text == "0"))
            {//Si s'est le cas un message est affich� dans une fen�tre:
                MessageBox.Show("Aucune des deux valeurs ne peux �tre 0");
            }

        }
    }
}