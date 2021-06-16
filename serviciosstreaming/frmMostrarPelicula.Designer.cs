
namespace serviciosstreaming
{
    partial class frmMostrarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarPelicula));
            this.lblPelicula = new System.Windows.Forms.Label();
            this.panelComentarios = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.richComentar = new System.Windows.Forms.RichTextBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblDirectores = new System.Windows.Forms.Label();
            this.lblActores = new System.Windows.Forms.Label();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.lblPlataformas = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbDirectores = new System.Windows.Forms.ComboBox();
            this.cbActores = new System.Windows.Forms.ComboBox();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.cbPlataformas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(272, 20);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(68, 13);
            this.lblPelicula.TabIndex = 1;
            this.lblPelicula.Text = "titulo pelicula";
            // 
            // panelComentarios
            // 
            this.panelComentarios.AutoScroll = true;
            this.panelComentarios.Location = new System.Drawing.Point(12, 473);
            this.panelComentarios.Name = "panelComentarios";
            this.panelComentarios.Size = new System.Drawing.Size(516, 198);
            this.panelComentarios.TabIndex = 6;
            // 
            // pbPortada
            // 
            this.pbPortada.Image = global::serviciosstreaming.Properties.Resources.portada;
            this.pbPortada.Location = new System.Drawing.Point(12, 12);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(252, 371);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // richComentar
            // 
            this.richComentar.Location = new System.Drawing.Point(12, 389);
            this.richComentar.Name = "richComentar";
            this.richComentar.Size = new System.Drawing.Size(392, 48);
            this.richComentar.TabIndex = 5;
            this.richComentar.Text = "";
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPublicar.Location = new System.Drawing.Point(410, 389);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(109, 48);
            this.btnPublicar.TabIndex = 6;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(12, 447);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(65, 13);
            this.lblComentarios.TabIndex = 7;
            this.lblComentarios.Text = "Comentarios";
            // 
            // lblDirectores
            // 
            this.lblDirectores.AutoSize = true;
            this.lblDirectores.Location = new System.Drawing.Point(273, 146);
            this.lblDirectores.Name = "lblDirectores";
            this.lblDirectores.Size = new System.Drawing.Size(55, 13);
            this.lblDirectores.TabIndex = 8;
            this.lblDirectores.Text = "Directores";
            // 
            // lblActores
            // 
            this.lblActores.AutoSize = true;
            this.lblActores.Location = new System.Drawing.Point(272, 192);
            this.lblActores.Name = "lblActores";
            this.lblActores.Size = new System.Drawing.Size(43, 13);
            this.lblActores.TabIndex = 9;
            this.lblActores.Text = "Actores";
            // 
            // lblGeneros
            // 
            this.lblGeneros.AutoSize = true;
            this.lblGeneros.Location = new System.Drawing.Point(270, 239);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(47, 13);
            this.lblGeneros.TabIndex = 10;
            this.lblGeneros.Text = "Generos";
            // 
            // lblPlataformas
            // 
            this.lblPlataformas.AutoSize = true;
            this.lblPlataformas.Location = new System.Drawing.Point(267, 286);
            this.lblPlataformas.Name = "lblPlataformas";
            this.lblPlataformas.Size = new System.Drawing.Size(62, 13);
            this.lblPlataformas.TabIndex = 11;
            this.lblPlataformas.Text = "Plataformas";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(273, 40);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(201, 93);
            this.txtDescripcion.TabIndex = 12;
            // 
            // cbDirectores
            // 
            this.cbDirectores.FormattingEnabled = true;
            this.cbDirectores.Location = new System.Drawing.Point(273, 162);
            this.cbDirectores.Name = "cbDirectores";
            this.cbDirectores.Size = new System.Drawing.Size(201, 21);
            this.cbDirectores.TabIndex = 13;
            // 
            // cbActores
            // 
            this.cbActores.FormattingEnabled = true;
            this.cbActores.Location = new System.Drawing.Point(273, 208);
            this.cbActores.Name = "cbActores";
            this.cbActores.Size = new System.Drawing.Size(201, 21);
            this.cbActores.TabIndex = 14;
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Location = new System.Drawing.Point(270, 255);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(201, 21);
            this.cbGeneros.TabIndex = 15;
            // 
            // cbPlataformas
            // 
            this.cbPlataformas.FormattingEnabled = true;
            this.cbPlataformas.Location = new System.Drawing.Point(270, 303);
            this.cbPlataformas.Name = "cbPlataformas";
            this.cbPlataformas.Size = new System.Drawing.Size(201, 21);
            this.cbPlataformas.TabIndex = 16;
            // 
            // frmMostrarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 683);
            this.Controls.Add(this.cbPlataformas);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.cbActores);
            this.Controls.Add(this.cbDirectores);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPlataformas);
            this.Controls.Add(this.lblGeneros);
            this.Controls.Add(this.lblActores);
            this.Controls.Add(this.lblDirectores);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.richComentar);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.panelComentarios);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.pbPortada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
<<<<<<< HEAD
            this.Name = "frmMostrarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarPelicula";
=======
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelicula";
            this.panelComentarios.ResumeLayout(false);
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.FlowLayoutPanel panelComentarios;
        private System.Windows.Forms.RichTextBox richComentar;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblDirectores;
        private System.Windows.Forms.Label lblActores;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.Label lblPlataformas;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbDirectores;
        private System.Windows.Forms.ComboBox cbActores;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.ComboBox cbPlataformas;
    }
}