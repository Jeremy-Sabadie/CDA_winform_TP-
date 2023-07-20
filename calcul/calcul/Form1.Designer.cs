namespace calcul
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstNb = new System.Windows.Forms.TextBox();
            this.secondNb = new System.Windows.Forms.TextBox();
            this.btnCe = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // firstNb
            // 
            this.firstNb.Location = new System.Drawing.Point(235, 44);
            this.firstNb.Multiline = true;
            this.firstNb.Name = "firstNb";
            this.firstNb.PlaceholderText = "Entrez un premier nombre";
            this.firstNb.Size = new System.Drawing.Size(364, 31);
            this.firstNb.TabIndex = 0;
            this.firstNb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.firstNb, "premier nmbre");
            this.firstNb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstNb_MouseClick);
            this.firstNb.TextChanged += new System.EventHandler(this.firstNb_TextChanged);
            // 
            // secondNb
            // 
            this.secondNb.Location = new System.Drawing.Point(246, 115);
            this.secondNb.Name = "secondNb";
            this.secondNb.PlaceholderText = "entrez le second numéro";
            this.secondNb.Size = new System.Drawing.Size(353, 31);
            this.secondNb.TabIndex = 1;
            this.secondNb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCe
            // 
            this.btnCe.Location = new System.Drawing.Point(665, 44);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(70, 34);
            this.btnCe.TabIndex = 2;
            this.btnCe.Text = "&ce";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(114, 170);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(112, 34);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.Location = new System.Drawing.Point(246, 204);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(353, 38);
            this.result.TabIndex = 4;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(232, 170);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(397, 25);
            this.line.TabIndex = 7;
            this.line.Text = "-------------------------------------------------------";
            // 
            // Form1
            // 
            this.AcceptButton = this.equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCe;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.line);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.secondNb);
            this.Controls.Add(this.firstNb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox secondNb;
        private Button btnCe;
        private Button equal;
        private Label result;
        private Label line;
        public TextBox firstNb;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}