
namespace serviciosstreaming
{
    partial class frmPeliculas
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
            this.txtNomPelicula = new System.Windows.Forms.TextBox();
            this.richDescripcion = new System.Windows.Forms.RichTextBox();
            this.cbCategoriasPeliculas = new System.Windows.Forms.ComboBox();
            this.ptbFotoPelicula = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.btnCargarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomPelicula
            // 
            this.txtNomPelicula.Location = new System.Drawing.Point(72, 30);
            this.txtNomPelicula.Name = "txtNomPelicula";
            this.txtNomPelicula.Size = new System.Drawing.Size(121, 20);
            this.txtNomPelicula.TabIndex = 0;
            // 
            // richDescripcion
            // 
            this.richDescripcion.Location = new System.Drawing.Point(72, 75);
            this.richDescripcion.Name = "richDescripcion";
            this.richDescripcion.Size = new System.Drawing.Size(121, 107);
            this.richDescripcion.TabIndex = 1;
            this.richDescripcion.Text = "";
            // 
            // cbCategoriasPeliculas
            // 
            this.cbCategoriasPeliculas.FormattingEnabled = true;
            this.cbCategoriasPeliculas.Location = new System.Drawing.Point(72, 211);
            this.cbCategoriasPeliculas.Name = "cbCategoriasPeliculas";
            this.cbCategoriasPeliculas.Size = new System.Drawing.Size(121, 21);
            this.cbCategoriasPeliculas.TabIndex = 2;
            // 
            // ptbFotoPelicula
            // 
            this.ptbFotoPelicula.Location = new System.Drawing.Point(218, 30);
            this.ptbFotoPelicula.Name = "ptbFotoPelicula";
            this.ptbFotoPelicula.Size = new System.Drawing.Size(136, 202);
            this.ptbFotoPelicula.TabIndex = 3;
            this.ptbFotoPelicula.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Foto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 305);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(282, 47);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(482, 238);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(171, 21);
            this.cbCategorias.TabIndex = 9;
            // 
            // dgvInformacion
            // 
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Location = new System.Drawing.Point(360, 30);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.Size = new System.Drawing.Size(293, 202);
            this.dgvInformacion.TabIndex = 10;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(251, 236);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnCargarFoto.TabIndex = 11;
            this.btnCargarFoto.Text = "button1";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // btnCargarCategoria
            // 
            this.btnCargarCategoria.Location = new System.Drawing.Point(482, 265);
            this.btnCargarCategoria.Name = "btnCargarCategoria";
            this.btnCargarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCargarCategoria.TabIndex = 12;
            this.btnCargarCategoria.Text = "button1";
            this.btnCargarCategoria.UseVisualStyleBackColor = true;
            this.btnCargarCategoria.Click += new System.EventHandler(this.btnCargarCategoria_Click);
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 411);
            this.Controls.Add(this.btnCargarCategoria);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.dgvInformacion);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbFotoPelicula);
            this.Controls.Add(this.cbCategoriasPeliculas);
            this.Controls.Add(this.richDescripcion);
            this.Controls.Add(this.txtNomPelicula);
            this.Name = "frmPeliculas";
            this.Text = "frmPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomPelicula;
        private System.Windows.Forms.RichTextBox richDescripcion;
        private System.Windows.Forms.ComboBox cbCategoriasPeliculas;
        private System.Windows.Forms.PictureBox ptbFotoPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Button btnCargarCategoria;
    }
}