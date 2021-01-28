namespace Programa10_03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtContenidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(32, 30);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(35, 13);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "label1";
            // 
            // txtContenidos
            // 
            this.txtContenidos.AllowDrop = true;
            this.txtContenidos.Location = new System.Drawing.Point(35, 63);
            this.txtContenidos.Multiline = true;
            this.txtContenidos.Name = "txtContenidos";
            this.txtContenidos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContenidos.Size = new System.Drawing.Size(416, 327);
            this.txtContenidos.TabIndex = 1;
            this.txtContenidos.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtContenidos_DragDrop);
            this.txtContenidos.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtContenidos_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 426);
            this.Controls.Add(this.txtContenidos);
            this.Controls.Add(this.lblArchivo);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 63 --- Drag & Drop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtContenidos;
    }
}

