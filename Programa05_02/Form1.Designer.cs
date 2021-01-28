namespace Programa05_02
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
            this.cmbAlimentos = new System.Windows.Forms.ComboBox();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAlimentos
            // 
            this.cmbAlimentos.FormattingEnabled = true;
            this.cmbAlimentos.Items.AddRange(new object[] {
            "Frijol",
            "Tomate"});
            this.cmbAlimentos.Location = new System.Drawing.Point(33, 40);
            this.cmbAlimentos.Name = "cmbAlimentos";
            this.cmbAlimentos.Size = new System.Drawing.Size(121, 21);
            this.cmbAlimentos.TabIndex = 0;
            this.cmbAlimentos.Text = "Alimentos";
            this.cmbAlimentos.SelectedIndexChanged += new System.EventHandler(this.cmbAlimentos_SelectedIndexChanged);
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(33, 124);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(100, 20);
            this.txtAlimento.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(155, 120);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(30, 89);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(36, 13);
            this.lblIndice.TabIndex = 3;
            this.lblIndice.Text = "Indice";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(194, 89);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 325);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.cmbAlimentos);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 24 --- ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlimentos;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblTexto;
    }
}

