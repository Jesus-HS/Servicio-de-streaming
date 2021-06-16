
namespace serviciosstreaming
{
    partial class frmAgregarPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarPeliculas));
            this.txtNomPelicula = new System.Windows.Forms.TextBox();
            this.richDescripcion = new System.Windows.Forms.RichTextBox();
            this.cbGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.btnCargarGeneros = new System.Windows.Forms.Button();
            this.ptbFotoPelicula = new System.Windows.Forms.PictureBox();
            this.btnCargarActores = new System.Windows.Forms.Button();
            this.cbActores = new System.Windows.Forms.ComboBox();
            this.cbActorPelicula = new System.Windows.Forms.ComboBox();
            this.btnCargarDirectores = new System.Windows.Forms.Button();
            this.cbDirectores = new System.Windows.Forms.ComboBox();
            this.cbDirectorPelicula = new System.Windows.Forms.ComboBox();
            this.btnCargarPlataforma = new System.Windows.Forms.Button();
            this.cbPlataformas = new System.Windows.Forms.ComboBox();
            this.cbPlataformaPelicula = new System.Windows.Forms.ComboBox();
            this.btnCargarPelicula = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomPelicula
            // 
            this.txtNomPelicula.Location = new System.Drawing.Point(226, 30);
            this.txtNomPelicula.Name = "txtNomPelicula";
            this.txtNomPelicula.Size = new System.Drawing.Size(158, 20);
            this.txtNomPelicula.TabIndex = 0;
            // 
            // richDescripcion
            // 
            this.richDescripcion.Location = new System.Drawing.Point(226, 69);
            this.richDescripcion.Name = "richDescripcion";
            this.richDescripcion.Size = new System.Drawing.Size(284, 107);
            this.richDescripcion.TabIndex = 1;
            this.richDescripcion.Text = "";
            // 
            // cbGeneroPelicula
            // 
            this.cbGeneroPelicula.FormattingEnabled = true;
            this.cbGeneroPelicula.Location = new System.Drawing.Point(226, 230);
            this.cbGeneroPelicula.Name = "cbGeneroPelicula";
            this.cbGeneroPelicula.Size = new System.Drawing.Size(121, 21);
            this.cbGeneroPelicula.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
            this.btnCargar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargar.Location = new System.Drawing.Point(12, 379);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(498, 47);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "C a r g a r  P e l i c u l a";
=======
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(12, 358);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(498, 47);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Location = new System.Drawing.Point(390, 230);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(120, 21);
            this.cbGeneros.TabIndex = 9;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(525, 30);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(158, 396);
            this.dgvPeliculas.TabIndex = 10;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnCargarFoto.FlatAppearance.BorderSize = 0;
            this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
            this.btnCargarFoto.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
=======
            this.btnCargarFoto.ForeColor = System.Drawing.Color.White;
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            this.btnCargarFoto.Location = new System.Drawing.Point(12, 323);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(195, 29);
            this.btnCargarFoto.TabIndex = 11;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // btnCargarGeneros
            // 
            this.btnCargarGeneros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnCargarGeneros.FlatAppearance.BorderSize = 0;
            this.btnCargarGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarGeneros.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarGeneros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarGeneros.Location = new System.Drawing.Point(353, 230);
            this.btnCargarGeneros.Name = "btnCargarGeneros";
            this.btnCargarGeneros.Size = new System.Drawing.Size(31, 23);
            this.btnCargarGeneros.TabIndex = 12;
            this.btnCargarGeneros.Text = "<-";
            this.btnCargarGeneros.UseVisualStyleBackColor = false;
            this.btnCargarGeneros.Click += new System.EventHandler(this.btnCargarCategoria_Click);
            // 
            // ptbFotoPelicula
            // 
            this.ptbFotoPelicula.Image = global::serviciosstreaming.Properties.Resources.portada;
            this.ptbFotoPelicula.Location = new System.Drawing.Point(12, 12);
            this.ptbFotoPelicula.Name = "ptbFotoPelicula";
            this.ptbFotoPelicula.Size = new System.Drawing.Size(195, 305);
            this.ptbFotoPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFotoPelicula.TabIndex = 3;
            this.ptbFotoPelicula.TabStop = false;
            // 
            // btnCargarActores
            // 
            this.btnCargarActores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnCargarActores.FlatAppearance.BorderSize = 0;
            this.btnCargarActores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarActores.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarActores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarActores.Location = new System.Drawing.Point(353, 270);
            this.btnCargarActores.Name = "btnCargarActores";
            this.btnCargarActores.Size = new System.Drawing.Size(31, 23);
            this.btnCargarActores.TabIndex = 15;
            this.btnCargarActores.Text = "<-";
            this.btnCargarActores.UseVisualStyleBackColor = false;
            this.btnCargarActores.Click += new System.EventHandler(this.btnCargarActores_Click);
            // 
            // cbActores
            // 
            this.cbActores.FormattingEnabled = true;
            this.cbActores.Location = new System.Drawing.Point(390, 270);
            this.cbActores.Name = "cbActores";
            this.cbActores.Size = new System.Drawing.Size(120, 21);
            this.cbActores.TabIndex = 14;
            // 
            // cbActorPelicula
            // 
            this.cbActorPelicula.FormattingEnabled = true;
            this.cbActorPelicula.Location = new System.Drawing.Point(226, 270);
            this.cbActorPelicula.Name = "cbActorPelicula";
            this.cbActorPelicula.Size = new System.Drawing.Size(121, 21);
            this.cbActorPelicula.TabIndex = 13;
            // 
            // btnCargarDirectores
            // 
            this.btnCargarDirectores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnCargarDirectores.FlatAppearance.BorderSize = 0;
            this.btnCargarDirectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDirectores.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDirectores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarDirectores.Location = new System.Drawing.Point(353, 310);
            this.btnCargarDirectores.Name = "btnCargarDirectores";
            this.btnCargarDirectores.Size = new System.Drawing.Size(31, 23);
            this.btnCargarDirectores.TabIndex = 18;
            this.btnCargarDirectores.Text = "<-";
            this.btnCargarDirectores.UseVisualStyleBackColor = false;
            // 
            // cbDirectores
            // 
            this.cbDirectores.FormattingEnabled = true;
            this.cbDirectores.Location = new System.Drawing.Point(390, 310);
            this.cbDirectores.Name = "cbDirectores";
            this.cbDirectores.Size = new System.Drawing.Size(120, 21);
            this.cbDirectores.TabIndex = 17;
            // 
            // cbDirectorPelicula
            // 
            this.cbDirectorPelicula.FormattingEnabled = true;
            this.cbDirectorPelicula.Location = new System.Drawing.Point(226, 310);
            this.cbDirectorPelicula.Name = "cbDirectorPelicula";
            this.cbDirectorPelicula.Size = new System.Drawing.Size(121, 21);
            this.cbDirectorPelicula.TabIndex = 16;
            // 
            // btnCargarPlataforma
            // 
            this.btnCargarPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnCargarPlataforma.FlatAppearance.BorderSize = 0;
            this.btnCargarPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPlataforma.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPlataforma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarPlataforma.Location = new System.Drawing.Point(353, 350);
            this.btnCargarPlataforma.Name = "btnCargarPlataforma";
            this.btnCargarPlataforma.Size = new System.Drawing.Size(31, 23);
            this.btnCargarPlataforma.TabIndex = 21;
            this.btnCargarPlataforma.Text = "<-";
            this.btnCargarPlataforma.UseVisualStyleBackColor = false;
            this.btnCargarPlataforma.Click += new System.EventHandler(this.btnCargarPlataforma_Click);
            // 
            // cbPlataformas
            // 
            this.cbPlataformas.FormattingEnabled = true;
            this.cbPlataformas.Location = new System.Drawing.Point(390, 350);
            this.cbPlataformas.Name = "cbPlataformas";
            this.cbPlataformas.Size = new System.Drawing.Size(120, 21);
            this.cbPlataformas.TabIndex = 20;
            // 
            // cbPlataformaPelicula
            // 
            this.cbPlataformaPelicula.FormattingEnabled = true;
            this.cbPlataformaPelicula.Location = new System.Drawing.Point(226, 350);
            this.cbPlataformaPelicula.Name = "cbPlataformaPelicula";
            this.cbPlataformaPelicula.Size = new System.Drawing.Size(121, 21);
            this.cbPlataformaPelicula.TabIndex = 19;
            // 
            // btnCargarPelicula
            // 
            this.btnCargarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnCargarPelicula.FlatAppearance.BorderSize = 0;
            this.btnCargarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPelicula.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarPelicula.Location = new System.Drawing.Point(452, 30);
            this.btnCargarPelicula.Name = "btnCargarPelicula";
            this.btnCargarPelicula.Size = new System.Drawing.Size(58, 23);
            this.btnCargarPelicula.TabIndex = 22;
            this.btnCargarPelicula.Text = "<-";
            this.btnCargarPelicula.UseVisualStyleBackColor = false;
            this.btnCargarPelicula.Click += new System.EventHandler(this.btnCargarPelicula_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(226, 182);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(284, 23);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(228, 214);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(47, 13);
            this.lblGenero.TabIndex = 24;
            this.lblGenero.Text = "Generos";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(228, 254);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(43, 13);
            this.lblActor.TabIndex = 25;
            this.lblActor.Text = "Actores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Directores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Plataformas";
            // 
            // frmAgregarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(693, 440);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblActor);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCargarPelicula);
            this.Controls.Add(this.btnCargarPlataforma);
            this.Controls.Add(this.cbPlataformas);
            this.Controls.Add(this.cbPlataformaPelicula);
=======
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 413);
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            this.Controls.Add(this.btnCargarDirectores);
            this.Controls.Add(this.cbDirectores);
            this.Controls.Add(this.cbDirectorPelicula);
            this.Controls.Add(this.btnCargarActores);
            this.Controls.Add(this.cbActores);
            this.Controls.Add(this.cbActorPelicula);
            this.Controls.Add(this.btnCargarGeneros);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbFotoPelicula);
            this.Controls.Add(this.cbGeneroPelicula);
            this.Controls.Add(this.richDescripcion);
            this.Controls.Add(this.txtNomPelicula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
<<<<<<< HEAD
            this.Name = "frmAgregarPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Peliculas";
=======
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar peliculas";
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomPelicula;
        private System.Windows.Forms.RichTextBox richDescripcion;
        private System.Windows.Forms.ComboBox cbGeneroPelicula;
        private System.Windows.Forms.PictureBox ptbFotoPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Button btnCargarGeneros;
        private System.Windows.Forms.Button btnCargarActores;
        private System.Windows.Forms.ComboBox cbActores;
        private System.Windows.Forms.ComboBox cbActorPelicula;
        private System.Windows.Forms.Button btnCargarDirectores;
        private System.Windows.Forms.ComboBox cbDirectores;
        private System.Windows.Forms.ComboBox cbDirectorPelicula;
        private System.Windows.Forms.Button btnCargarPlataforma;
        private System.Windows.Forms.ComboBox cbPlataformas;
        private System.Windows.Forms.ComboBox cbPlataformaPelicula;
        private System.Windows.Forms.Button btnCargarPelicula;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}