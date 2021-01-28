namespace Programa04_01
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
            this.tmrPrueba = new System.Windows.Forms.Timer(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.tbrIntervalo = new System.Windows.Forms.TrackBar();
            this.lblTValor = new System.Windows.Forms.Label();
            this.pbrTrabajo = new System.Windows.Forms.ProgressBar();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrPrueba
            // 
            this.tmrPrueba.Tick += new System.EventHandler(this.tmrPrueba_Tick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(180, 21);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "label1";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(303, 10);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(303, 39);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // tbrIntervalo
            // 
            this.tbrIntervalo.Location = new System.Drawing.Point(74, 83);
            this.tbrIntervalo.Maximum = 1000;
            this.tbrIntervalo.Minimum = 100;
            this.tbrIntervalo.Name = "tbrIntervalo";
            this.tbrIntervalo.Size = new System.Drawing.Size(391, 45);
            this.tbrIntervalo.TabIndex = 3;
            this.tbrIntervalo.Tag = "";
            this.tbrIntervalo.TickFrequency = 100;
            this.tbrIntervalo.Value = 100;
            this.tbrIntervalo.Scroll += new System.EventHandler(this.tbrIntervalo_Scroll);
            // 
            // lblTValor
            // 
            this.lblTValor.AutoSize = true;
            this.lblTValor.Location = new System.Drawing.Point(232, 131);
            this.lblTValor.Name = "lblTValor";
            this.lblTValor.Size = new System.Drawing.Size(35, 13);
            this.lblTValor.TabIndex = 4;
            this.lblTValor.Text = "label1";
            // 
            // pbrTrabajo
            // 
            this.pbrTrabajo.Location = new System.Drawing.Point(86, 177);
            this.pbrTrabajo.Name = "pbrTrabajo";
            this.pbrTrabajo.Size = new System.Drawing.Size(379, 23);
            this.pbrTrabajo.TabIndex = 5;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(232, 203);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(35, 13);
            this.lblProgreso.TabIndex = 6;
            this.lblProgreso.Text = "label1";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(303, 206);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 7;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 240);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.pbrTrabajo);
            this.Controls.Add(this.lblTValor);
            this.Controls.Add(this.tbrIntervalo);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 20-22 --- Timer, TrackBar y ProgressBar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbrIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrPrueba;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.TrackBar tbrIntervalo;
        private System.Windows.Forms.Label lblTValor;
        private System.Windows.Forms.ProgressBar pbrTrabajo;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Button btnCalculo;
    }
}

