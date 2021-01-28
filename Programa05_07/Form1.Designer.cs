namespace Programa05_07
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imglFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnCambio = new System.Windows.Forms.Button();
            this.pcbimagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imglFotos
            // 
            this.imglFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglFotos.ImageStream")));
            this.imglFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglFotos.Images.SetKeyName(0, "6.jpg");
            this.imglFotos.Images.SetKeyName(1, "2.jpg");
            this.imglFotos.Images.SetKeyName(2, "4.jpg");
            this.imglFotos.Images.SetKeyName(3, "7.jpg");
            this.imglFotos.Images.SetKeyName(4, "1.jpg");
            this.imglFotos.Images.SetKeyName(5, "3.jpg");
            this.imglFotos.Images.SetKeyName(6, "5.jpg");
            this.imglFotos.Images.SetKeyName(7, "Bitmap1.bmp");
            // 
            // lblFoto
            // 
            this.lblFoto.ImageIndex = 0;
            this.lblFoto.ImageList = this.imglFotos;
            this.lblFoto.Location = new System.Drawing.Point(55, 37);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(220, 176);
            this.lblFoto.TabIndex = 2;
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(103, 231);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(112, 23);
            this.btnCambio.TabIndex = 3;
            this.btnCambio.Text = "Cambiar imagen";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // pcbimagen
            // 
            this.pcbimagen.Location = new System.Drawing.Point(315, 37);
            this.pcbimagen.Name = "pcbimagen";
            this.pcbimagen.Size = new System.Drawing.Size(220, 176);
            this.pcbimagen.TabIndex = 4;
            this.pcbimagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 430);
            this.Controls.Add(this.pcbimagen);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.lblFoto);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 29-30 --- ImageList ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglFotos;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.PictureBox pcbimagen;
    }
}

