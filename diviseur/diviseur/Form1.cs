namespace diviseur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void divisé_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void btn_calc_Click(object sender, EventArgs e)
        {//Vérification au clic sur le boutton q'aucun des champs n'est égal à 0:


            if ((numerateur.Text == "" || denominateur.Text == "") || (numerateur.Text == "0" || denominateur.Text == "0"))
            {//Si s'est le cas un message est affiché dans une fenêtre:
                MessageBox.Show("Aucune des deux valeurs ne peux être 0");
            }

        }
    }
}