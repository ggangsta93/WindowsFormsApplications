namespace Programa08_02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCiruela = new System.Windows.Forms.RadioButton();
            this.rbtPera = new System.Windows.Forms.RadioButton();
            this.rbtManzana = new System.Windows.Forms.RadioButton();
            this.chkImportado = new System.Windows.Forms.CheckBox();
            this.chkOrganico = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(53, 45);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(200, 20);
            this.txtMensaje.TabIndex = 0;
            this.txtMensaje.TextChanged += new System.EventHandler(this.txtMensaje_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtCiruela);
            this.groupBox1.Controls.Add(this.rbtPera);
            this.groupBox1.Controls.Add(this.rbtManzana);
            this.groupBox1.Location = new System.Drawing.Point(53, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fruticas";
            // 
            // rbtCiruela
            // 
            this.rbtCiruela.AutoSize = true;
            this.rbtCiruela.Location = new System.Drawing.Point(7, 66);
            this.rbtCiruela.Name = "rbtCiruela";
            this.rbtCiruela.Size = new System.Drawing.Size(57, 17);
            this.rbtCiruela.TabIndex = 2;
            this.rbtCiruela.Text = "Ciruela";
            this.rbtCiruela.UseVisualStyleBackColor = true;
            this.rbtCiruela.CheckedChanged += new System.EventHandler(this.rbtCiruela_CheckedChanged);
            // 
            // rbtPera
            // 
            this.rbtPera.AutoSize = true;
            this.rbtPera.Location = new System.Drawing.Point(6, 43);
            this.rbtPera.Name = "rbtPera";
            this.rbtPera.Size = new System.Drawing.Size(47, 17);
            this.rbtPera.TabIndex = 1;
            this.rbtPera.Text = "Pera";
            this.rbtPera.UseVisualStyleBackColor = true;
            this.rbtPera.CheckedChanged += new System.EventHandler(this.rbtPera_CheckedChanged);
            // 
            // rbtManzana
            // 
            this.rbtManzana.AutoSize = true;
            this.rbtManzana.Checked = true;
            this.rbtManzana.Location = new System.Drawing.Point(7, 20);
            this.rbtManzana.Name = "rbtManzana";
            this.rbtManzana.Size = new System.Drawing.Size(69, 17);
            this.rbtManzana.TabIndex = 0;
            this.rbtManzana.TabStop = true;
            this.rbtManzana.Text = "Manzana";
            this.rbtManzana.UseVisualStyleBackColor = true;
            this.rbtManzana.CheckedChanged += new System.EventHandler(this.rbtManzana_CheckedChanged);
            // 
            // chkImportado
            // 
            this.chkImportado.AutoSize = true;
            this.chkImportado.Location = new System.Drawing.Point(300, 86);
            this.chkImportado.Name = "chkImportado";
            this.chkImportado.Size = new System.Drawing.Size(73, 17);
            this.chkImportado.TabIndex = 2;
            this.chkImportado.Text = "Importado";
            this.chkImportado.UseVisualStyleBackColor = true;
            this.chkImportado.CheckStateChanged += new System.EventHandler(this.chkImportado_CheckStateChanged);
            // 
            // chkOrganico
            // 
            this.chkOrganico.AutoSize = true;
            this.chkOrganico.Location = new System.Drawing.Point(300, 109);
            this.chkOrganico.Name = "chkOrganico";
            this.chkOrganico.Size = new System.Drawing.Size(69, 17);
            this.chkOrganico.TabIndex = 3;
            this.chkOrganico.Text = "Organico";
            this.chkOrganico.UseVisualStyleBackColor = true;
            this.chkOrganico.CheckStateChanged += new System.EventHandler(this.chkOrganico_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 210);
            this.Controls.Add(this.chkOrganico);
            this.Controls.Add(this.chkImportado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 50 --- Salvando user settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCiruela;
        private System.Windows.Forms.RadioButton rbtPera;
        private System.Windows.Forms.RadioButton rbtManzana;
        private System.Windows.Forms.CheckBox chkImportado;
        private System.Windows.Forms.CheckBox chkOrganico;
    }
}

