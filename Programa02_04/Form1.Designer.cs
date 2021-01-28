namespace Programa02_04
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnForma2 = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(22, 44);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(103, 13);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "================";
            // 
            // btnForma2
            // 
            this.btnForma2.Location = new System.Drawing.Point(168, 34);
            this.btnForma2.Name = "btnForma2";
            this.btnForma2.Size = new System.Drawing.Size(100, 23);
            this.btnForma2.TabIndex = 1;
            this.btnForma2.Text = "Abrir Forma 2";
            this.btnForma2.UseVisualStyleBackColor = true;
            this.btnForma2.Click += new System.EventHandler(this.btnForma2_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(25, 75);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(35, 13);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "label1";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(168, 139);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(100, 23);
            this.btnRecuperar.TabIndex = 3;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 217);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.btnForma2);
            this.Controls.Add(this.lblMensaje);
            this.Name = "Form1";
            this.Text = "Tutorial Programación Windows Forms C# 12-13 --- Comunicación entre formas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnForma2;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Button btnRecuperar;
    }
}

