namespace hello_wold
{
    partial class Frm_container
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_world = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1001, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_world
            // 
            this.lb_world.AutoSize = true;
            this.lb_world.Location = new System.Drawing.Point(73, 92);
            this.lb_world.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_world.Name = "lb_world";
            this.lb_world.Size = new System.Drawing.Size(121, 25);
            this.lb_world.TabIndex = 2;
            this.lb_world.Text = "Hello World !!";
            this.lb_world.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(216, 89);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(147, 31);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_quit_MouseClick_1);
            // 
            // Frm_container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 185);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.lb_world);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premier pas en Winform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_container_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label lb_world;
        private Button btn_quit;
        private Button btnQuit;
        private Label lbWorld;
    }
}