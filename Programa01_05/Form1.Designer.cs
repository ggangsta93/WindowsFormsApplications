namespace Programa01_05
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMulti = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.gboxOperaciones = new System.Windows.Forms.GroupBox();
            this.gboxOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(28, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(148, 20);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(28, 69);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(148, 20);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(205, 45);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 25);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(236, 101);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "label1";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Checked = true;
            this.rbSuma.Location = new System.Drawing.Point(6, 19);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(52, 17);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(6, 42);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(53, 17);
            this.rbResta.TabIndex = 1;
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            this.rbMulti.AutoSize = true;
            this.rbMulti.Location = new System.Drawing.Point(6, 65);
            this.rbMulti.Name = "rbMulti";
            this.rbMulti.Size = new System.Drawing.Size(72, 17);
            this.rbMulti.TabIndex = 2;
            this.rbMulti.Text = "Multiplicar";
            this.rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Location = new System.Drawing.Point(6, 83);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(54, 17);
            this.rbDiv.TabIndex = 3;
            this.rbDiv.Text = "Dividir";
            this.rbDiv.UseVisualStyleBackColor = true;
            // 
            // gboxOperaciones
            // 
            this.gboxOperaciones.Controls.Add(this.rbDiv);
            this.gboxOperaciones.Controls.Add(this.rbMulti);
            this.gboxOperaciones.Controls.Add(this.rbResta);
            this.gboxOperaciones.Controls.Add(this.rbSuma);
            this.gboxOperaciones.Location = new System.Drawing.Point(28, 123);
            this.gboxOperaciones.Name = "gboxOperaciones";
            this.gboxOperaciones.Size = new System.Drawing.Size(154, 114);
            this.gboxOperaciones.TabIndex = 3;
            this.gboxOperaciones.TabStop = false;
            this.gboxOperaciones.Text = "Operaciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 249);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gboxOperaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Tutorial Programación Windows Forms C# 7 --- RadioButton y GroupBox";
            this.gboxOperaciones.ResumeLayout(false);
            this.gboxOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbMulti;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.GroupBox gboxOperaciones;
    }
}

