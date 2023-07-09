using System.Drawing.Drawing2D;

namespace TrabalhoFinalED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Grafo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Grafo
            // 
            this.Grafo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Grafo.BackgroundImage")));
            this.Grafo.Location = new System.Drawing.Point(12, 31);
            this.Grafo.Name = "Grafo";
            this.Grafo.Size = new System.Drawing.Size(1336, 613);
            this.Grafo.TabIndex = 2;
            this.Grafo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 731);
            this.Controls.Add(this.Grafo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Grafo;
    }
}