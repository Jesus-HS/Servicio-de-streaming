
namespace serviciosstreaming
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pBarrita = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.pCuerpo = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.ucLog1 = new Elementos.ucLog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBarrita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.pCuerpo.SuspendLayout();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBarrita
            // 
            this.pBarrita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pBarrita.Controls.Add(this.lblTitulo);
            this.pBarrita.Controls.Add(this.pbIcono);
            this.pBarrita.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarrita.Location = new System.Drawing.Point(0, 0);
            this.pBarrita.Name = "pBarrita";
            this.pBarrita.Size = new System.Drawing.Size(840, 41);
            this.pBarrita.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(44, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 15);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TITULO";
            // 
            // pbIcono
            // 
            this.pbIcono.Image = global::serviciosstreaming.Properties.Resources.icono;
            this.pbIcono.Location = new System.Drawing.Point(7, 8);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(24, 24);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcono.TabIndex = 0;
            this.pbIcono.TabStop = false;
            // 
            // pCuerpo
            // 
            this.pCuerpo.Controls.Add(this.lblBienvenido);
            this.pCuerpo.Controls.Add(this.panelInicio);
            this.pCuerpo.Controls.Add(this.pictureBox1);
            this.pCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCuerpo.Location = new System.Drawing.Point(0, 41);
            this.pCuerpo.Name = "pCuerpo";
            this.pCuerpo.Size = new System.Drawing.Size(840, 472);
            this.pCuerpo.TabIndex = 4;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.lblBienvenido.Location = new System.Drawing.Point(5, -1);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(427, 72);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "Bienvenido a";
            // 
            // panelInicio
            // 
<<<<<<< HEAD
            this.panelInicio.BackColor = System.Drawing.Color.White;
=======
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            this.panelInicio.Controls.Add(this.ucLog1);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInicio.Location = new System.Drawing.Point(447, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(393, 472);
            this.panelInicio.TabIndex = 4;
            // 
            // ucLog1
            // 
            this.ucLog1.BackColor = System.Drawing.Color.White;
            this.ucLog1.ForeColor = System.Drawing.SystemColors.ControlText;
<<<<<<< HEAD
            this.ucLog1.Location = new System.Drawing.Point(0, -1);
            this.ucLog1.Name = "ucLog1";
            this.ucLog1.Size = new System.Drawing.Size(393, 473);
            this.ucLog1.TabIndex = 0;
=======
            this.ucLog1.Location = new System.Drawing.Point(0, 0);
            this.ucLog1.Name = "ucLog1";
            this.ucLog1.Size = new System.Drawing.Size(1205, 504);
            this.ucLog1.TabIndex = 0;
            this.ucLog1.Load += new System.EventHandler(this.ucLog1_Load);
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::serviciosstreaming.Properties.Resources.claqueta;
            this.pictureBox1.Location = new System.Drawing.Point(6, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(840, 513);
            this.Controls.Add(this.pCuerpo);
            this.Controls.Add(this.pBarrita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios streaming";
            this.pBarrita.ResumeLayout(false);
            this.pBarrita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.pCuerpo.ResumeLayout(false);
            this.pCuerpo.PerformLayout();
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBarrita;
        private System.Windows.Forms.Panel pCuerpo;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbIcono;
        private Elementos.ucLog ucLog1;
    }
}

