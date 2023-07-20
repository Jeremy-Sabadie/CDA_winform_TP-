namespace fenetre_modale
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
            this.txtb_title = new System.Windows.Forms.TextBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_fille = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtb_title
            // 
            this.txtb_title.Location = new System.Drawing.Point(182, 24);
            this.txtb_title.Name = "txtb_title";
            this.txtb_title.Size = new System.Drawing.Size(203, 23);
            this.txtb_title.TabIndex = 0;
            this.txtb_title.TextChanged += new System.EventHandler(this.txtb_title_TextChanged);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(-2, 32);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(155, 15);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Veuillez saisir le titre de Fen2";
            // 
            // btn_fille
            // 
            this.btn_fille.Location = new System.Drawing.Point(159, 105);
            this.btn_fille.Name = "btn_fille";
            this.btn_fille.Size = new System.Drawing.Size(111, 23);
            this.btn_fille.TabIndex = 2;
            this.btn_fille.Text = "Fenêtre fille";
            this.btn_fille.UseVisualStyleBackColor = true;
            this.btn_fille.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_fille_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 155);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_fille);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.txtb_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtb_title;
        private Label lb_title;
        private Button btn_fille;
        private TextBox textBox1;
    }
}