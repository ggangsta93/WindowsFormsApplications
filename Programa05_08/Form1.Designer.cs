namespace Programa05_08
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
            this.lstvAlimentos = new System.Windows.Forms.ListView();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.gbGrupos = new System.Windows.Forms.GroupBox();
            this.rbtCarnes = new System.Windows.Forms.RadioButton();
            this.rbtFrutas = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblSelecionado = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvAlimentos
            // 
            this.lstvAlimentos.HideSelection = false;
            this.lstvAlimentos.Location = new System.Drawing.Point(26, 40);
            this.lstvAlimentos.Name = "lstvAlimentos";
            this.lstvAlimentos.Size = new System.Drawing.Size(354, 228);
            this.lstvAlimentos.TabIndex = 0;
            this.lstvAlimentos.UseCompatibleStateImageBehavior = false;
            this.lstvAlimentos.View = System.Windows.Forms.View.SmallIcon;
            this.lstvAlimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstvAlimentos_MouseClick);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(26, 288);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // gbGrupos
            // 
            this.gbGrupos.Controls.Add(this.rbtCarnes);
            this.gbGrupos.Controls.Add(this.rbtFrutas);
            this.gbGrupos.Location = new System.Drawing.Point(169, 288);
            this.gbGrupos.Name = "gbGrupos";
            this.gbGrupos.Size = new System.Drawing.Size(101, 69);
            this.gbGrupos.TabIndex = 2;
            this.gbGrupos.TabStop = false;
            this.gbGrupos.Text = "Grupos";
            // 
            // rbtCarnes
            // 
            this.rbtCarnes.AutoSize = true;
            this.rbtCarnes.Location = new System.Drawing.Point(6, 43);
            this.rbtCarnes.Name = "rbtCarnes";
            this.rbtCarnes.Size = new System.Drawing.Size(58, 17);
            this.rbtCarnes.TabIndex = 1;
            this.rbtCarnes.Text = "Carnes";
            this.rbtCarnes.UseVisualStyleBackColor = true;
            // 
            // rbtFrutas
            // 
            this.rbtFrutas.AutoSize = true;
            this.rbtFrutas.Checked = true;
            this.rbtFrutas.Location = new System.Drawing.Point(7, 20);
            this.rbtFrutas.Name = "rbtFrutas";
            this.rbtFrutas.Size = new System.Drawing.Size(54, 17);
            this.rbtFrutas.TabIndex = 0;
            this.rbtFrutas.TabStop = true;
            this.rbtFrutas.Text = "Frutas";
            this.rbtFrutas.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(305, 288);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(386, 69);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblSelecionado
            // 
            this.lblSelecionado.AutoSize = true;
            this.lblSelecionado.Location = new System.Drawing.Point(386, 53);
            this.lblSelecionado.Name = "lblSelecionado";
            this.lblSelecionado.Size = new System.Drawing.Size(35, 13);
            this.lblSelecionado.TabIndex = 5;
            this.lblSelecionado.Text = "label1";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(26, 331);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 6;
            this.txtImagen.Text = "0";
            this.txtImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(386, 107);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(26, 377);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 426);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.lblSelecionado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.gbGrupos);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lstvAlimentos);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 31-34 --- ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGrupos.ResumeLayout(false);
            this.gbGrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvAlimentos;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.GroupBox gbGrupos;
        private System.Windows.Forms.RadioButton rbtFrutas;
        private System.Windows.Forms.RadioButton rbtCarnes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblSelecionado;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

