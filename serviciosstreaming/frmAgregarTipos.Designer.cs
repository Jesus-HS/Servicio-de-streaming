﻿
namespace serviciosstreaming
{
    partial class frmAgregarTipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarTipos));
            this.txtTipos = new System.Windows.Forms.TextBox();
            this.btnAgregarTipos = new System.Windows.Forms.Button();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipos
            // 
            this.txtTipos.Location = new System.Drawing.Point(12, 12);
            this.txtTipos.Name = "txtTipos";
            this.txtTipos.Size = new System.Drawing.Size(100, 20);
            this.txtTipos.TabIndex = 0;
            // 
            // btnAgregarTipos
            // 
            this.btnAgregarTipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAgregarTipos.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
            this.btnAgregarTipos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
=======
            this.btnAgregarTipos.ForeColor = System.Drawing.Color.White;
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            this.btnAgregarTipos.Location = new System.Drawing.Point(12, 38);
            this.btnAgregarTipos.Name = "btnAgregarTipos";
            this.btnAgregarTipos.Size = new System.Drawing.Size(100, 24);
            this.btnAgregarTipos.TabIndex = 1;
            this.btnAgregarTipos.Text = "Agregar";
            this.btnAgregarTipos.UseVisualStyleBackColor = false;
            this.btnAgregarTipos.Click += new System.EventHandler(this.btnAgregarTipos_Click);
            // 
            // dgvTipos
            // 
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Location = new System.Drawing.Point(118, 12);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.RowHeadersVisible = false;
            this.dgvTipos.Size = new System.Drawing.Size(240, 150);
            this.dgvTipos.TabIndex = 2;
            // 
            // frmAgregarTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
=======
            this.BackColor = System.Drawing.Color.White;
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            this.ClientSize = new System.Drawing.Size(365, 177);
            this.Controls.Add(this.dgvTipos);
            this.Controls.Add(this.btnAgregarTipos);
            this.Controls.Add(this.txtTipos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
<<<<<<< HEAD
            this.Name = "frmAgregarTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Tipos";
=======
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar tipos";
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipos;
        private System.Windows.Forms.Button btnAgregarTipos;
        private System.Windows.Forms.DataGridView dgvTipos;
    }
}