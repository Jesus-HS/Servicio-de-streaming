
namespace serviciosstreaming
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.pBarrita = new System.Windows.Forms.Panel();
            this.pCuerpo = new System.Windows.Forms.Panel();
            this.ucRegister1 = new Elementos.ucLog();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pBarrita.SuspendLayout();
            this.pCuerpo.SuspendLayout();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // pBarrita
            // 
            this.pBarrita.Controls.Add(this.lblTitulo);
            this.pBarrita.Controls.Add(this.pbIcono);
            this.pBarrita.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarrita.Location = new System.Drawing.Point(0, 0);
            this.pBarrita.Name = "pBarrita";
            this.pBarrita.Size = new System.Drawing.Size(840, 37);
            this.pBarrita.TabIndex = 3;
            // 
            // pCuerpo
            // 
            this.pCuerpo.Controls.Add(this.lblBienvenido);
            this.pCuerpo.Controls.Add(this.panelInicio);
            this.pCuerpo.Controls.Add(this.pictureBox1);
            this.pCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCuerpo.Location = new System.Drawing.Point(0, 37);
            this.pCuerpo.Name = "pCuerpo";
            this.pCuerpo.Size = new System.Drawing.Size(840, 476);
            this.pCuerpo.TabIndex = 4;
            // 
            // ucRegister1
            // 
            this.ucRegister1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ucRegister1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucRegister1.Location = new System.Drawing.Point(2, 0);
            this.ucRegister1.Name = "ucRegister1";
            this.ucRegister1.Size = new System.Drawing.Size(389, 476);
            this.ucRegister1.TabIndex = 3;
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
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.panelInicio.Controls.Add(this.ucRegister1);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInicio.Location = new System.Drawing.Point(447, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(393, 476);
            this.panelInicio.TabIndex = 4;
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
            // pbIcono
            // 
            this.pbIcono.Image = global::serviciosstreaming.Properties.Resources.claqueta;
            this.pbIcono.Location = new System.Drawing.Point(3, 3);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(30, 30);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcono.TabIndex = 0;
            this.pbIcono.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(39, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 15);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(840, 513);
            this.Controls.Add(this.pCuerpo);
            this.Controls.Add(this.pBarrita);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios streaming";
            this.pBarrita.ResumeLayout(false);
            this.pBarrita.PerformLayout();
            this.pCuerpo.ResumeLayout(false);
            this.pCuerpo.PerformLayout();
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBarrita;
        private System.Windows.Forms.Panel pCuerpo;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panelInicio;
        private Elementos.ucLog ucRegister1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbIcono;
    }
}

