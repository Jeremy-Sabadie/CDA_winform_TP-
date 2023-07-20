namespace diviseur
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numerateur = new System.Windows.Forms.TextBox();
            this.denominateur = new System.Windows.Forms.TextBox();
            this.lbtext = new System.Windows.Forms.Label();
            this.numérateur_prop = new System.Windows.Forms.Label();
            this.lb_line = new System.Windows.Forms.Label();
            this.lb_line2 = new System.Windows.Forms.Label();
            this.dénominateur_prop = new System.Windows.Forms.Label();
            this.vivisé_prop = new System.Windows.Forms.Label();
            this.diviseur_prop = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saisir1 = new System.Windows.Forms.Label();
            this.saisir2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numerateur
            // 
            this.numerateur.Location = new System.Drawing.Point(433, 21);
            this.numerateur.Name = "numerateur";
            this.numerateur.Size = new System.Drawing.Size(100, 23);
            this.numerateur.TabIndex = 0;
            this.numerateur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.divisé_KeyPress);
            // 
            // denominateur
            // 
            this.denominateur.Location = new System.Drawing.Point(433, 82);
            this.denominateur.Name = "denominateur";
            this.denominateur.Size = new System.Drawing.Size(100, 23);
            this.denominateur.TabIndex = 1;
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.Location = new System.Drawing.Point(197, 163);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(158, 15);
            this.lbtext.TabIndex = 2;
            this.lbtext.Text = "Résultat après simplification:";
            // 
            // numérateur_prop
            // 
            this.numérateur_prop.AutoSize = true;
            this.numérateur_prop.Location = new System.Drawing.Point(357, 187);
            this.numérateur_prop.Name = "numérateur_prop";
            this.numérateur_prop.Size = new System.Drawing.Size(72, 15);
            this.numérateur_prop.TabIndex = 3;
            this.numérateur_prop.Text = "numérateur:";
            // 
            // lb_line
            // 
            this.lb_line.Location = new System.Drawing.Point(419, 56);
            this.lb_line.Name = "lb_line";
            this.lb_line.Size = new System.Drawing.Size(137, 23);
            this.lb_line.TabIndex = 4;
            this.lb_line.Text = "--------------------------------------------";
            // 
            // lb_line2
            // 
            this.lb_line2.Location = new System.Drawing.Point(419, 202);
            this.lb_line2.Name = "lb_line2";
            this.lb_line2.Size = new System.Drawing.Size(100, 23);
            this.lb_line2.TabIndex = 5;
            this.lb_line2.Text = "---------------------------------";
            // 
            // dénominateur_prop
            // 
            this.dénominateur_prop.AutoSize = true;
            this.dénominateur_prop.Location = new System.Drawing.Point(344, 219);
            this.dénominateur_prop.Name = "dénominateur_prop";
            this.dénominateur_prop.Size = new System.Drawing.Size(85, 15);
            this.dénominateur_prop.TabIndex = 6;
            this.dénominateur_prop.Text = "dénominateur:";
            // 
            // vivisé_prop
            // 
            this.vivisé_prop.AutoEllipsis = true;
            this.vivisé_prop.AutoSize = true;
            this.vivisé_prop.Location = new System.Drawing.Point(451, 189);
            this.vivisé_prop.Name = "vivisé_prop";
            this.vivisé_prop.Size = new System.Drawing.Size(0, 15);
            this.vivisé_prop.TabIndex = 7;
            // 
            // diviseur_prop
            // 
            this.diviseur_prop.AutoSize = true;
            this.diviseur_prop.Location = new System.Drawing.Point(456, 226);
            this.diviseur_prop.Name = "diviseur_prop";
            this.diviseur_prop.Size = new System.Drawing.Size(0, 15);
            this.diviseur_prop.TabIndex = 8;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(382, 132);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 9;
            this.btn_calc.Text = "Calculer";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // saisir1
            // 
            this.saisir1.AutoSize = true;
            this.saisir1.Location = new System.Drawing.Point(241, 29);
            this.saisir1.Name = "saisir1";
            this.saisir1.Size = new System.Drawing.Size(155, 15);
            this.saisir1.TabIndex = 11;
            this.saisir1.Text = "Veuillez saisir le numérateur:";
            // 
            // saisir2
            // 
            this.saisir2.AutoSize = true;
            this.saisir2.Location = new System.Drawing.Point(228, 90);
            this.saisir2.Name = "saisir2";
            this.saisir2.Size = new System.Drawing.Size(168, 15);
            this.saisir2.TabIndex = 12;
            this.saisir2.Text = "Veuillez saisir le dénominateur:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 249);
            this.Controls.Add(this.saisir2);
            this.Controls.Add(this.saisir1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.diviseur_prop);
            this.Controls.Add(this.vivisé_prop);
            this.Controls.Add(this.dénominateur_prop);
            this.Controls.Add(this.lb_line2);
            this.Controls.Add(this.lb_line);
            this.Controls.Add(this.numérateur_prop);
            this.Controls.Add(this.lbtext);
            this.Controls.Add(this.denominateur);
            this.Controls.Add(this.numerateur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox denominateur;
        private Label lbtext;
        private Label numérateur_prop;
        private Label lb_line;
        private Label lb_line2;
        private Label dénominateur_prop;
        private Label vivisé_prop;
        private Label diviseur_prop;
        private Button btn_calc;
        private Label label1;
        private Label saisir1;
        private Label saisir2;
        public TextBox numerateur;
    }
}