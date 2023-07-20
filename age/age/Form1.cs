namespace age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            //Vérification de l'état non vide des champs texte pour griser ou non le boutton calculer:
            if (string.IsNullOrEmpty(nameTxt.Text))
            {
                btSend.Enabled = false;
            }
            else btSend.Enabled = true;

        }



        private void BtClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void BtSend_Click(object sender, EventArgs e)
        {
            //Récupération du nom:
            string name = nameTxt.Text;
            //Rangement de la date actuelle dans la variable today:
            DateTime today = DateTime.UtcNow;
            //Transformation del'entréee utilisateur dans le champ texte en date:
            DateTime born = dateNaissTimePicker1.Value;
            //Calcul de l'age de l'utilisateur:
            int age = today.Year - born.Year;
            //Arrondi de l'age à l'année:
            if (born > DateTime.Now)
                age--;
            //Affichage des infos dans une messageBox:
            string errorMsg = "La date sélectionnée ne peut pas être supérieure à la date du jour!";
            if (dateNaissTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show(errorMsg);
            }
            else
            {
                MessageBox.Show("Bonjour " + name + " vous avez: " + age + ".");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string defaultName = Properties.Settings.Default.userName;
            DateTime Defaultdate = Properties.Settings.Default.userDate;
            nameTxt.Text = defaultName;
            dateNaissTimePicker1.Value = Defaultdate;

            nameTxt.Focus();
            if (string.IsNullOrEmpty(dateNaissTimePicker1.Value.ToString()))
            {
                btSend.Enabled = false;
            }
            else btSend.Enabled = true;
        }

        private void DatTxt_TextChanged(object sender, EventArgs e)
        {
            //    if
            //    {
            //        btSend.Enabled = false;
            //    }
            //    else btSend.Enabled = true;
        }

        private void NameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void DatTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NameTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(string.IsNullOrEmpty(nameTxt.Text)))
            {
                nameTxt.Clear();

            }
        }

        private void DatTxt_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!(string.IsNullOrEmpty(datTxt.Text)))
            //{
            //    datTxt.Clear();
            //}
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.userName = nameTxt.Text;
            Properties.Settings.Default.userDate = dateNaissTimePicker1.Value;



            Properties.Settings.Default.Save();
        }

    }
}