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
        //Si l'utilisateur ne saisit pas un nombre, un message d'erreur sera affiché, le champ de saisie sera effacé et le focus sera replacé dans le champ.
        private void equal_Click(object sender, EventArgs e)
        {

            if (int.TryParse(firstNb.Text, out int Valeur))
            {
                var res = (Convert.ToInt32(firstNb) + Convert.ToInt32(secondNb.Text)).ToString();
                result.Text = res;
            }
            else
            {
                //Un message d'erreur sera affiché:
                MessageBox.Show("La saisie n'est pas un entier valide !");
                //l
                //Le champ de saisie sera effacé:
                firstNb.Clear();
                //Le focus sera replacé dans le champ:
                firstNb.Focus();
            }

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

        private void secondNb_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondNb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (secondNb.Text.Contains(','))
            {
                e.Handled = true;

            }


            //Remplace les points par des irgules:
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';

            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back) { e.Handled = true; }



        }

        private void firstNb_KeyPress(object sender, KeyPressEventArgs e)
        {//Autorisation d'une seule virgule dans le champ:
            if (firstNb.Text.Contains(','))
            {
                e.Handled = true;

            }
            ///Remplacement des points entrés par  des virgules:
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';

            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back) { e.Handled = true; }
        }

        private void firstNb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}