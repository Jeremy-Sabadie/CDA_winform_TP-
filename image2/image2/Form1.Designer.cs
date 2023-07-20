namespace image2
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
            this.PathList = new System.Windows.Forms.ListBox();
            this.LbPath = new System.Windows.Forms.Label();
            this.btCoice = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PathList
            // 
            this.PathList.FormattingEnabled = true;
            this.PathList.ItemHeight = 15;
            this.PathList.Location = new System.Drawing.Point(190, 76);
            this.PathList.Name = "PathList";
            this.PathList.Size = new System.Drawing.Size(321, 139);
            this.PathList.TabIndex = 0;
            this.PathList.SelectedIndexChanged += new System.EventHandler(this.PathList_SelectedIndexChanged_1);
            // 
            // LbPath
            // 
            this.LbPath.AutoSize = true;
            this.LbPath.Location = new System.Drawing.Point(350, 41);
            this.LbPath.Name = "LbPath";
            this.LbPath.Size = new System.Drawing.Size(0, 15);
            this.LbPath.TabIndex = 1;
            // 
            // btCoice
            // 
            this.btCoice.Image = global::image2.Properties.Resources.loupe;
            this.btCoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCoice.Location = new System.Drawing.Point(101, 35);
            this.btCoice.Name = "btCoice";
            this.btCoice.Size = new System.Drawing.Size(68, 26);
            this.btCoice.TabIndex = 2;
            this.btCoice.Text = "      choisir une image";
            this.btCoice.UseVisualStyleBackColor = true;
            this.btCoice.Click += new System.EventHandler(this.Coice_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(241, 41);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(103, 15);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "chemin du fichier:";
            // 
            // btAdd
            // 
            this.btAdd.Image = global::image2.Properties.Resources.green_cross;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.Location = new System.Drawing.Point(517, 76);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(141, 27);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Ajouter le chemin";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = global::image2.Properties.Resources.res_cross;
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.Location = new System.Drawing.Point(517, 121);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(141, 35);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "effacer le chemin";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btClear
            // 
            this.btClear.Image = global::image2.Properties.Resources.cleaner;
            this.btClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClear.Location = new System.Drawing.Point(517, 177);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(141, 38);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "vider la liste";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 295);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(2, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 340);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btCoice);
            this.Controls.Add(this.LbPath);
            this.Controls.Add(this.PathList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox PathList;
        private Label LbPath;
        private Button btCoice;
        private Label lbTitle;
        private Button btAdd;
        private Button btDelete;
        private Button btClear;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}