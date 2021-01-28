namespace Programa08_03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBeep = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnTocar = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnTono = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.txtDura = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Freq";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dura";
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(345, 53);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(75, 23);
            this.btnBeep.TabIndex = 2;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(117, 225);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnTocar
            // 
            this.btnTocar.Location = new System.Drawing.Point(345, 225);
            this.btnTocar.Name = "btnTocar";
            this.btnTocar.Size = new System.Drawing.Size(75, 23);
            this.btnTocar.TabIndex = 4;
            this.btnTocar.Text = "Tocar";
            this.btnTocar.UseVisualStyleBackColor = true;
            this.btnTocar.Click += new System.EventHandler(this.btnTocar_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.Location = new System.Drawing.Point(345, 148);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(75, 23);
            this.btnSistema.TabIndex = 5;
            this.btnSistema.Text = "Sistema";
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnTono
            // 
            this.btnTono.Location = new System.Drawing.Point(345, 110);
            this.btnTono.Name = "btnTono";
            this.btnTono.Size = new System.Drawing.Size(75, 23);
            this.btnTono.TabIndex = 6;
            this.btnTono.Text = "Tono";
            this.btnTono.UseVisualStyleBackColor = true;
            this.btnTono.Click += new System.EventHandler(this.btnTono_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(114, 265);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(35, 13);
            this.lblRuta.TabIndex = 7;
            this.lblRuta.Text = "label3";
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(117, 59);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(100, 20);
            this.txtFreq.TabIndex = 8;
            this.txtFreq.Text = "3000";
            // 
            // txtDura
            // 
            this.txtDura.Location = new System.Drawing.Point(117, 113);
            this.txtDura.Name = "txtDura";
            this.txtDura.Size = new System.Drawing.Size(100, 20);
            this.txtDura.TabIndex = 9;
            this.txtDura.Text = "200";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Wav|*.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 359);
            this.Controls.Add(this.txtDura);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnTono);
            this.Controls.Add(this.btnSistema);
            this.Controls.Add(this.btnTocar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnBeep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 51 --- Tocar Audio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnTocar;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnTono;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.TextBox txtDura;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

