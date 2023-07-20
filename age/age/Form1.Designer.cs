namespace age
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
            this.btSend = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDat = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.dateNaissTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(196, 175);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(113, 47);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "Calculer";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(193, 125);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PlaceholderText = "Entrez votre nom";
            this.nameTxt.Size = new System.Drawing.Size(100, 23);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameTxt_MouseClick);
            this.nameTxt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.nameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPress);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(196, 107);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(97, 15);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Entrez votre nom";
            this.lbName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbDat
            // 
            this.lbDat.AutoSize = true;
            this.lbDat.Location = new System.Drawing.Point(369, 107);
            this.lbDat.Name = "lbDat";
            this.lbDat.Size = new System.Drawing.Size(165, 15);
            this.lbDat.TabIndex = 4;
            this.lbDat.Text = "Entrez votre date de naissance";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(134, 286);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(38, 15);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "label1";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(390, 175);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(122, 47);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Fermer";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // dateNaissTimePicker1
            // 
            this.dateNaissTimePicker1.Location = new System.Drawing.Point(345, 125);
            this.dateNaissTimePicker1.Name = "dateNaissTimePicker1";
            this.dateNaissTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateNaissTimePicker1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 260);
            this.Controls.Add(this.dateNaissTimePicker1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbDat);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.btSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btSend;
        private TextBox nameTxt;
        private Label lbName;
        private Label lbDat;
        private Label lbResult;
        private Button btClose;
        private DateTimePicker dateNaissTimePicker1;
    }
}