﻿namespace Programa08_01
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAbrirNotepad = new System.Windows.Forms.Button();
            this.btnCerrarNotepad = new System.Windows.Forms.Button();
            this.prcNotepad = new System.Diagnostics.Process();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(50, 80);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Esperando";
            // 
            // btnAbrirNotepad
            // 
            this.btnAbrirNotepad.Location = new System.Drawing.Point(130, 49);
            this.btnAbrirNotepad.Name = "btnAbrirNotepad";
            this.btnAbrirNotepad.Size = new System.Drawing.Size(119, 23);
            this.btnAbrirNotepad.TabIndex = 1;
            this.btnAbrirNotepad.Text = "Abrir Notepad";
            this.btnAbrirNotepad.UseVisualStyleBackColor = true;
            this.btnAbrirNotepad.Click += new System.EventHandler(this.btnAbrirNotepad_Click);
            // 
            // btnCerrarNotepad
            // 
            this.btnCerrarNotepad.Location = new System.Drawing.Point(130, 100);
            this.btnCerrarNotepad.Name = "btnCerrarNotepad";
            this.btnCerrarNotepad.Size = new System.Drawing.Size(119, 23);
            this.btnCerrarNotepad.TabIndex = 2;
            this.btnCerrarNotepad.Text = "Cerrar Notepad";
            this.btnCerrarNotepad.UseVisualStyleBackColor = true;
            this.btnCerrarNotepad.Click += new System.EventHandler(this.btnCerrarNotepad_Click);
            // 
            // prcNotepad
            // 
            this.prcNotepad.StartInfo.Domain = "";
            this.prcNotepad.StartInfo.FileName = "notepad.exe";
            this.prcNotepad.StartInfo.LoadUserProfile = false;
            this.prcNotepad.StartInfo.Password = null;
            this.prcNotepad.StartInfo.StandardErrorEncoding = null;
            this.prcNotepad.StartInfo.StandardOutputEncoding = null;
            this.prcNotepad.StartInfo.UserName = "";
            this.prcNotepad.StartInfo.WorkingDirectory = "%system%system32";
            this.prcNotepad.SynchronizingObject = this;
            this.prcNotepad.Exited += new System.EventHandler(this.prcNotepad_Exited);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.esconderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // esconderToolStripMenuItem
            // 
            this.esconderToolStripMenuItem.Name = "esconderToolStripMenuItem";
            this.esconderToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esconderToolStripMenuItem.Text = "Esconder";
            this.esconderToolStripMenuItem.Click += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Abre Aplicaciones";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 225);
            this.Controls.Add(this.btnCerrarNotepad);
            this.Controls.Add(this.btnAbrirNotepad);
            this.Controls.Add(this.lblEstado);
            this.Name = "Form1";
            this.Text = "Programación Windows Forms C# 49 --- Process y NotifyIcon";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAbrirNotepad;
        private System.Windows.Forms.Button btnCerrarNotepad;
        private System.Diagnostics.Process prcNotepad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esconderToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

