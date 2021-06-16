
namespace serviciosstreaming
{
    partial class frmAgregarDirectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarDirectores));
            this.dgvDirectores = new System.Windows.Forms.DataGridView();
            this.btnAgregarDirector = new System.Windows.Forms.Button();
            this.txtDirector = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDirectores
            // 
            this.dgvDirectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectores.Location = new System.Drawing.Point(118, 12);
            this.dgvDirectores.Name = "dgvDirectores";
            this.dgvDirectores.RowHeadersVisible = false;
            this.dgvDirectores.Size = new System.Drawing.Size(208, 150);
            this.dgvDirectores.TabIndex = 5;
            // 
            // btnAgregarDirector
            // 
            this.btnAgregarDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAgregarDirector.FlatAppearance.BorderSize = 0;
            this.btnAgregarDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
            this.btnAgregarDirector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
=======
            this.btnAgregarDirector.ForeColor = System.Drawing.Color.White;
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            this.btnAgregarDirector.Location = new System.Drawing.Point(12, 38);
            this.btnAgregarDirector.Name = "btnAgregarDirector";
            this.btnAgregarDirector.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarDirector.TabIndex = 4;
            this.btnAgregarDirector.Text = "Agregar";
            this.btnAgregarDirector.UseVisualStyleBackColor = false;
            this.btnAgregarDirector.Click += new System.EventHandler(this.btnAgregarDirector_Click);
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(12, 12);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(100, 20);
            this.txtDirector.TabIndex = 3;
            // 
            // frmAgregarDirectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 174);
            this.Controls.Add(this.dgvDirectores);
            this.Controls.Add(this.btnAgregarDirector);
            this.Controls.Add(this.txtDirector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
<<<<<<< HEAD
            this.Name = "frmAgregarDirectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Directores";
=======
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarDirectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar directores";
            this.Load += new System.EventHandler(this.frmAgregarDirectores_Load);
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDirectores;
        private System.Windows.Forms.Button btnAgregarDirector;
        private System.Windows.Forms.TextBox txtDirector;
    }
}