
namespace serviciosstreaming
{
    partial class frmAgregarActores
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
            this.txtActor = new System.Windows.Forms.TextBox();
            this.btnAgregarActor = new System.Windows.Forms.Button();
            this.dgvActores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(12, 12);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(100, 20);
            this.txtActor.TabIndex = 0;
            // 
            // btnAgregarActor
            // 
            this.btnAgregarActor.Location = new System.Drawing.Point(12, 38);
            this.btnAgregarActor.Name = "btnAgregarActor";
            this.btnAgregarActor.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarActor.TabIndex = 1;
            this.btnAgregarActor.Text = "Agregar";
            this.btnAgregarActor.UseVisualStyleBackColor = true;
            this.btnAgregarActor.Click += new System.EventHandler(this.btnAgregarActor_Click);
            // 
            // dgvActores
            // 
            this.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActores.Location = new System.Drawing.Point(118, 12);
            this.dgvActores.Name = "dgvActores";
            this.dgvActores.RowHeadersVisible = false;
            this.dgvActores.Size = new System.Drawing.Size(208, 150);
            this.dgvActores.TabIndex = 2;
            // 
            // frmAgregarActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 174);
            this.Controls.Add(this.dgvActores);
            this.Controls.Add(this.btnAgregarActor);
            this.Controls.Add(this.txtActor);
            this.Name = "frmAgregarActores";
            this.Text = "frmAgregarActores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Button btnAgregarActor;
        private System.Windows.Forms.DataGridView dgvActores;
    }
}