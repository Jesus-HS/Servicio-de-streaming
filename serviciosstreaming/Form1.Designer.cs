﻿
namespace serviciosstreaming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelInicio = new System.Windows.Forms.Panel();
            this.ucRegister1 = new Elementos.ucLog();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.panelInicio.Controls.Add(this.ucRegister1);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInicio.Location = new System.Drawing.Point(454, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(389, 504);
            this.panelInicio.TabIndex = 0;
            // 
            // ucRegister1
            // 
            this.ucRegister1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ucRegister1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucRegister1.Location = new System.Drawing.Point(3, 0);
            this.ucRegister1.Name = "ucRegister1";
            this.ucRegister1.Size = new System.Drawing.Size(383, 504);
            this.ucRegister1.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.lblBienvenido.Location = new System.Drawing.Point(12, 26);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(427, 72);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido a";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::serviciosstreaming.Properties.Resources.claqueta;
            this.pictureBox1.Location = new System.Drawing.Point(3, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(843, 504);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios streaming";
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Elementos.ucLog ucRegister1;
    }
}

