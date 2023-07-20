namespace modal2
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
            this.title1to2 = new System.Windows.Forms.Label();
            this.textBox1to2 = new System.Windows.Forms.TextBox();
            this.btnF1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title1to2
            // 
            this.title1to2.AutoSize = true;
            this.title1to2.Location = new System.Drawing.Point(237, 102);
            this.title1to2.Name = "title1to2";
            this.title1to2.Size = new System.Drawing.Size(170, 25);
            this.title1to2.TabIndex = 0;
            this.title1to2.Text = "saisir le titre de fen2";
            // 
            // textBox1to2
            // 
            this.textBox1to2.Location = new System.Drawing.Point(432, 96);
            this.textBox1to2.Name = "textBox1to2";
            this.textBox1to2.Size = new System.Drawing.Size(150, 31);
            this.textBox1to2.TabIndex = 1;
            // 
            // btnF1
            // 
            this.btnF1.Location = new System.Drawing.Point(339, 162);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(217, 34);
            this.btnF1.TabIndex = 2;
            this.btnF1.Text = "envoyer le titre à la fille";
            this.btnF1.UseVisualStyleBackColor = true;
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 263);
            this.Controls.Add(this.btnF1);
            this.Controls.Add(this.textBox1to2);
            this.Controls.Add(this.title1to2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title1to2;
        private TextBox textBox1to2;
        private Button btnF1;
    }
}