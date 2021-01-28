namespace Programa07_08
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnAdicionaNodo = new System.Windows.Forms.Button();
            this.btnEliminaNodo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAdicionaElemento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(44, 51);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 218);
            this.treeView1.TabIndex = 0;
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(212, 51);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 1;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(212, 91);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 2;
            // 
            // btnAdicionaNodo
            // 
            this.btnAdicionaNodo.Location = new System.Drawing.Point(370, 51);
            this.btnAdicionaNodo.Name = "btnAdicionaNodo";
            this.btnAdicionaNodo.Size = new System.Drawing.Size(127, 23);
            this.btnAdicionaNodo.TabIndex = 3;
            this.btnAdicionaNodo.Text = "Adiciona nodo";
            this.btnAdicionaNodo.UseVisualStyleBackColor = true;
            this.btnAdicionaNodo.Click += new System.EventHandler(this.btnAdicionaNodo_Click);
            // 
            // btnEliminaNodo
            // 
            this.btnEliminaNodo.Location = new System.Drawing.Point(370, 169);
            this.btnEliminaNodo.Name = "btnEliminaNodo";
            this.btnEliminaNodo.Size = new System.Drawing.Size(127, 23);
            this.btnEliminaNodo.TabIndex = 4;
            this.btnEliminaNodo.Text = "Elimina Nodo";
            this.btnEliminaNodo.UseVisualStyleBackColor = true;
            this.btnEliminaNodo.Click += new System.EventHandler(this.btnEliminaNodo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(370, 127);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpia arbol";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAdicionaElemento
            // 
            this.btnAdicionaElemento.Location = new System.Drawing.Point(370, 88);
            this.btnAdicionaElemento.Name = "btnAdicionaElemento";
            this.btnAdicionaElemento.Size = new System.Drawing.Size(127, 23);
            this.btnAdicionaElemento.TabIndex = 6;
            this.btnAdicionaElemento.Text = "Adiciona Elemento";
            this.btnAdicionaElemento.UseVisualStyleBackColor = true;
            this.btnAdicionaElemento.Click += new System.EventHandler(this.btnAdicionaElemento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 402);
            this.Controls.Add(this.btnAdicionaElemento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminaNodo);
            this.Controls.Add(this.btnAdicionaNodo);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 48 --- TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnAdicionaNodo;
        private System.Windows.Forms.Button btnEliminaNodo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAdicionaElemento;
    }
}

