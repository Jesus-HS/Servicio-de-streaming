
namespace serviciosstreaming
{
    partial class frmAgregarGeneros
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
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.btnAgregarGenero = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneros.Location = new System.Drawing.Point(118, 12);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.RowHeadersVisible = false;
            this.dgvGeneros.Size = new System.Drawing.Size(208, 150);
            this.dgvGeneros.TabIndex = 5;
            // 
            // btnAgregarGenero
            // 
            this.btnAgregarGenero.Location = new System.Drawing.Point(12, 38);
            this.btnAgregarGenero.Name = "btnAgregarGenero";
            this.btnAgregarGenero.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarGenero.TabIndex = 4;
            this.btnAgregarGenero.Text = "Agregar";
            this.btnAgregarGenero.UseVisualStyleBackColor = true;
            this.btnAgregarGenero.Click += new System.EventHandler(this.btnAgregarGenero_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(12, 12);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 3;
            // 
            // frmAgregarGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 173);
            this.Controls.Add(this.dgvGeneros);
            this.Controls.Add(this.btnAgregarGenero);
            this.Controls.Add(this.txtGenero);
            this.Name = "frmAgregarGeneros";
            this.Text = "frmAgregarGeneros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.Button btnAgregarGenero;
        private System.Windows.Forms.TextBox txtGenero;
    }
}