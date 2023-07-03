
namespace CursoCsharp.Ejercicios
{
    partial class Ejercicio3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblejercicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblejercicio
            // 
            this.lblejercicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblejercicio.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblejercicio.ForeColor = System.Drawing.Color.White;
            this.lblejercicio.Location = new System.Drawing.Point(0, 0);
            this.lblejercicio.Name = "lblejercicio";
            this.lblejercicio.Size = new System.Drawing.Size(890, 80);
            this.lblejercicio.TabIndex = 2;
            this.lblejercicio.Text = "Ejercicio 3";
            this.lblejercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lblejercicio);
            this.Name = "Ejercicio3";
            this.Size = new System.Drawing.Size(890, 588);
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblejercicio;
    }
}
