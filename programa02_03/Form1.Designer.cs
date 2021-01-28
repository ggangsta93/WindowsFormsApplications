namespace programa02_03
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnvio = new System.Windows.Forms.Button();
            this.btnEnvio2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(64, 49);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(100, 20);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnEnvio
            // 
            this.btnEnvio.Location = new System.Drawing.Point(199, 49);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(75, 23);
            this.btnEnvio.TabIndex = 1;
            this.btnEnvio.Text = "Envio 1";
            this.btnEnvio.UseVisualStyleBackColor = true;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // btnEnvio2
            // 
            this.btnEnvio2.Location = new System.Drawing.Point(199, 88);
            this.btnEnvio2.Name = "btnEnvio2";
            this.btnEnvio2.Size = new System.Drawing.Size(75, 23);
            this.btnEnvio2.TabIndex = 2;
            this.btnEnvio2.Text = "Envio 2";
            this.btnEnvio2.UseVisualStyleBackColor = true;
            this.btnEnvio2.Click += new System.EventHandler(this.btnEnvio2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 266);
            this.Controls.Add(this.btnEnvio2);
            this.Controls.Add(this.btnEnvio);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Tutorial Programación Windows Forms C# 10 --- Comunicación entre formas I";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnvio;
        private System.Windows.Forms.Button btnEnvio2;
    }
}

