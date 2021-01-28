namespace Programa10_04
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAlto = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(517, 347);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(13, 13);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(26, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(503, 12);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(26, 23);
            this.btnIr.TabIndex = 2;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(157, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(26, 23);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "H";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAlto
            // 
            this.btnAlto.Location = new System.Drawing.Point(125, 13);
            this.btnAlto.Name = "btnAlto";
            this.btnAlto.Size = new System.Drawing.Size(26, 23);
            this.btnAlto.TabIndex = 4;
            this.btnAlto.Text = "S";
            this.btnAlto.UseVisualStyleBackColor = true;
            this.btnAlto.Click += new System.EventHandler(this.btnAlto_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(93, 13);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(26, 23);
            this.btnRecargar.TabIndex = 5;
            this.btnRecargar.Text = "R";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(45, 13);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(26, 23);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(190, 13);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(307, 20);
            this.txtURL.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 409);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnAlto);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 64 --- WebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAlto;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtURL;
    }
}

