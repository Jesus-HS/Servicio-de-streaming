﻿
namespace serviciosstreaming
{
    partial class frmAgregarPlataforma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPlataformas = new System.Windows.Forms.DataGridView();
            this.btnAgregarPlataforma = new System.Windows.Forms.Button();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlataformas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlataformas
            // 
            this.dgvPlataformas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlataformas.Location = new System.Drawing.Point(118, 12);
            this.dgvPlataformas.Name = "dgvPlataformas";
            this.dgvPlataformas.RowHeadersVisible = false;
            this.dgvPlataformas.Size = new System.Drawing.Size(208, 150);
            this.dgvPlataformas.TabIndex = 5;
            // 
            // btnAgregarPlataforma
            // 
            this.btnAgregarPlataforma.Location = new System.Drawing.Point(12, 38);
            this.btnAgregarPlataforma.Name = "btnAgregarPlataforma";
            this.btnAgregarPlataforma.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarPlataforma.TabIndex = 4;
            this.btnAgregarPlataforma.Text = "Agregar";
            this.btnAgregarPlataforma.UseVisualStyleBackColor = true;
            this.btnAgregarPlataforma.Click += new System.EventHandler(this.btnAgregarPlataforma_Click);
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Location = new System.Drawing.Point(12, 12);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(100, 20);
            this.txtPlataforma.TabIndex = 3;
            // 
            // frmAgregarPlataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 176);
            this.Controls.Add(this.dgvPlataformas);
            this.Controls.Add(this.btnAgregarPlataforma);
            this.Controls.Add(this.txtPlataforma);
            this.Name = "frmAgregarPlataforma";
            this.Text = "frmAgregarPlataforma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlataformas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlataformas;
        private System.Windows.Forms.Button btnAgregarPlataforma;
        private System.Windows.Forms.TextBox txtPlataforma;
    }
}