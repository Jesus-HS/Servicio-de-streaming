
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
            this.cbGeneroPelicula.Location = new System.Drawing.Point(226, 182);
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
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(12, 358);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(498, 47);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Location = new System.Drawing.Point(390, 182);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(120, 21);
            this.cbGeneros.TabIndex = 9;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(565, 12);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(158, 202);
            this.dgvPeliculas.TabIndex = 10;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnCargarFoto.FlatAppearance.BorderSize = 0;
            this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFoto.ForeColor = System.Drawing.Color.White;
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
            this.btnCargarGeneros.Location = new System.Drawing.Point(353, 182);
            this.btnCargarGeneros.Name = "btnCargarGeneros";
            this.btnCargarGeneros.Size = new System.Drawing.Size(31, 23);
            this.btnCargarGeneros.TabIndex = 12;
            this.btnCargarGeneros.Text = "<-";
            this.btnCargarGeneros.UseVisualStyleBackColor = true;
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
            this.btnCargarActores.Location = new System.Drawing.Point(353, 209);
            this.btnCargarActores.Name = "btnCargarActores";
            this.btnCargarActores.Size = new System.Drawing.Size(31, 23);
            this.btnCargarActores.TabIndex = 15;
            this.btnCargarActores.Text = "<-";
            this.btnCargarActores.UseVisualStyleBackColor = true;
            // 
            // cbActores
            // 
            this.cbActores.FormattingEnabled = true;
            this.cbActores.Location = new System.Drawing.Point(390, 209);
            this.cbActores.Name = "cbActores";
            this.cbActores.Size = new System.Drawing.Size(120, 21);
            this.cbActores.TabIndex = 14;
            // 
            // cbActorPelicula
            // 
            this.cbActorPelicula.FormattingEnabled = true;
            this.cbActorPelicula.Location = new System.Drawing.Point(226, 209);
            this.cbActorPelicula.Name = "cbActorPelicula";
            this.cbActorPelicula.Size = new System.Drawing.Size(121, 21);
            this.cbActorPelicula.TabIndex = 13;
            // 
            // btnCargarDirectores
            // 
            this.btnCargarDirectores.Location = new System.Drawing.Point(353, 236);
            this.btnCargarDirectores.Name = "btnCargarDirectores";
            this.btnCargarDirectores.Size = new System.Drawing.Size(31, 23);
            this.btnCargarDirectores.TabIndex = 18;
            this.btnCargarDirectores.Text = "<-";
            this.btnCargarDirectores.UseVisualStyleBackColor = true;
            // 
            // cbDirectores
            // 
            this.cbDirectores.FormattingEnabled = true;
            this.cbDirectores.Location = new System.Drawing.Point(390, 236);
            this.cbDirectores.Name = "cbDirectores";
            this.cbDirectores.Size = new System.Drawing.Size(120, 21);
            this.cbDirectores.TabIndex = 17;
            // 
            // cbDirectorPelicula
            // 
            this.cbDirectorPelicula.FormattingEnabled = true;
            this.cbDirectorPelicula.Location = new System.Drawing.Point(226, 236);
            this.cbDirectorPelicula.Name = "cbDirectorPelicula";
            this.cbDirectorPelicula.Size = new System.Drawing.Size(121, 21);
            this.cbDirectorPelicula.TabIndex = 16;
            // 
            // frmAgregarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 413);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar peliculas";
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
    }
}