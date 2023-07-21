namespace image2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Fonction GreyBtn pour le grisage et dégrisage des boutons:
        private void IsGreyBtn()
        {
            btAdd.Enabled = (LbPath.Text.Length > 0);
            btDelete.Enabled = (PathList.SelectedIndex != -1);

            {




            }
            if (PathList.Items.Count < 0)
            {
                btDelete.Enabled = false;
                btClear.Enabled = false;
            }
            string selectedItem = LbPath.Text;
            //string Filename = Path.GetFileName(selectedItem);
            foreach (string element in PathList.Items)
            {
                if (Path.GetFileName(element) == Path.GetFileName(selectedItem))
                {
                    btAdd.Enabled = false;

                }



            }
        }
        private void Coice_Click(object sender, EventArgs e)
        {

            IsGreyBtn();
            OpenFileDialog ChooseFile = new();
            ChooseFile.Filter = "jpg files (*.jpeg)|*.png";
            //Overture de la fenêtre de choix:
            ChooseFile.ShowDialog();
            //Sauvegarde du chemin:
            string Path = ChooseFile.FileName.ToString();

            LbPath.Text = Path;
            //Définition des propriétés de la picturebox1
            //pictureBox1.Image = Path;
            //pictureBox1.Image = Properties.Resources(Path);
            //pictureBox1.Image = object.GetImage(Path);
            //pictureBox1.Image = Path;
            //pictureBox1.Size = new Size(210, 110);
            //pictureBox1.Load(Path);
            //pictureBox1.Image = Image.FromFile(Path);

            //Si l'utilisateur clique sur le bouton cancel de lafenêtre:
            if (DialogResult == DialogResult.Cancel && LbPath.Text == string.Empty)
            {
                IsGreyBtn();

            }
            else
            {
                if (LbPath.Text != string.Empty)
                {
                    IsGreyBtn();

                }
                else
                {
                    IsGreyBtn();

                }
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsGreyBtn();
            //int NbItems = PathList.Items.Count;
            {
                IsGreyBtn();


            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {



            //
            IsGreyBtn();

            string ItemToAdd = LbPath.Text;

            PathList.Items.Add(ItemToAdd);


            int nbItems = PathList.Items.Count;
            if (PathList.Items.Count > 1)
            {
                IsGreyBtn();

            }
            else
            {
                IsGreyBtn();

            }
        }
        private void BtClear_Click(object sender, EventArgs e)
        {

            PathList.Items.Clear();
            IsGreyBtn();
            if (PathList.SelectedItem == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Load(PathList.SelectedItem.ToString());
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            IsGreyBtn();
            if (PathList.Items.Count > 0)
            {
                IsGreyBtn();
                var selectedIndex = PathList.SelectedIndex;
                PathList.Items.RemoveAt(selectedIndex);
            }

            if (PathList.Items.Count < 1)
            {
                IsGreyBtn();
                //btClear.Enabled = false;
                //btDelete.Enabled = false;
            }

        }




        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbTitle.Text == string.Empty)
            {
                IsGreyBtn();
            }
            else
            {
                IsGreyBtn();
            }
        }

        private void PathList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PathList_SelectedIndexChanged_1(object sender, EventArgs e)
        {//La pictureBox est incluse dans le panel:
            panel1.Controls.Contains(pictureBox1);
            //Paramètre de la taille de l'image:

            //Définition du scroll sur le conteneur:


            //Si pas de chemin sélectionné, un message est affiché:
            if (PathList.SelectedItem == null)
            {
                pictureBox1.Image = null;
            }
            else
            {//Overture de la PictureBox acec le chemin sélectionné:
                pictureBox1.Load(PathList.SelectedItem.ToString());
            }





            //Apel de la fonction du grisage des boutons:
            IsGreyBtn();
        }


    }
}
