namespace modal2
{
    partial class Fen2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtF2To1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(218, 39);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(112, 25);
            this.text.TabIndex = 0;
            this.text.Text = "saisir un titre";
            this.text.Click += new System.EventHandler(this.lbFen2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(554, 139);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 34);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Valider";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtF2To1
            // 
            this.txtF2To1.Location = new System.Drawing.Point(302, 86);
            this.txtF2To1.Name = "txtF2To1";
            this.txtF2To1.Size = new System.Drawing.Size(291, 31);
            this.txtF2To1.TabIndex = 3;
            // 
            // Fen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 234);
            this.Controls.Add(this.txtF2To1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.text);
            this.Name = "Fen2";
            this.Text = "Fen2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label text;
        private Button btnCancel;
        private Button btnOk;
        private TextBox txtF2To1;
    }
}