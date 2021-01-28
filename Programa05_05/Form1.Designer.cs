namespace Programa05_05
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
            this.lstFrutas = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtFruta = new System.Windows.Forms.TextBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFrutas
            // 
            this.lstFrutas.FormattingEnabled = true;
            this.lstFrutas.Items.AddRange(new object[] {
            "Melon",
            "Manzana",
            "Aguacate"});
            this.lstFrutas.Location = new System.Drawing.Point(31, 155);
            this.lstFrutas.Name = "lstFrutas";
            this.lstFrutas.Size = new System.Drawing.Size(120, 95);
            this.lstFrutas.TabIndex = 0;
            this.lstFrutas.SelectedIndexChanged += new System.EventHandler(this.lstFrutas_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(159, 44);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtFruta
            // 
            this.txtFruta.Location = new System.Drawing.Point(31, 47);
            this.txtFruta.Name = "txtFruta";
            this.txtFruta.Size = new System.Drawing.Size(100, 20);
            this.txtFruta.TabIndex = 2;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(159, 110);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(35, 13);
            this.lblSeleccion.TabIndex = 3;
            this.lblSeleccion.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(255, 44);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 334);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.txtFruta);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lstFrutas);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 27 --- ListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFrutas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtFruta;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button btnEliminar;
    }
}

