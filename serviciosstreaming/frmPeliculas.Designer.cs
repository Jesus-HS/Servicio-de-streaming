
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
            this.cbGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.ptbFotoPelicula = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.btnCargarGeneros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomPelicula
            // 
            this.txtNomPelicula.Location = new System.Drawing.Point(226, 30);
            this.txtNomPelicula.Name = "txtNomPelicula";
            this.txtNomPelicula.Size = new System.Drawing.Size(121, 20);
            this.txtNomPelicula.TabIndex = 0;
            // 
            // richDescripcion
            // 
            this.richDescripcion.Location = new System.Drawing.Point(226, 69);
            this.richDescripcion.Name = "richDescripcion";
            this.richDescripcion.Size = new System.Drawing.Size(121, 107);
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
            // ptbFotoPelicula
            // 
            this.ptbFotoPelicula.Location = new System.Drawing.Point(12, 12);
            this.ptbFotoPelicula.Name = "ptbFotoPelicula";
            this.ptbFotoPelicula.Size = new System.Drawing.Size(195, 305);
            this.ptbFotoPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFotoPelicula.TabIndex = 3;
            this.ptbFotoPelicula.TabStop = false;
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
            this.label3.Text = "Descripcion";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(24, 437);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(282, 47);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Location = new System.Drawing.Point(390, 182);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(120, 21);
            this.cbGeneros.TabIndex = 9;
            // 
            // dgvInformacion
            // 
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Location = new System.Drawing.Point(435, 262);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.Size = new System.Drawing.Size(198, 202);
            this.dgvInformacion.TabIndex = 10;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(12, 323);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(195, 23);
            this.btnCargarFoto.TabIndex = 11;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
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
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 563);
            this.Controls.Add(this.btnCargarGeneros);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.dgvInformacion);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbFotoPelicula);
            this.Controls.Add(this.cbGeneroPelicula);
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
        private System.Windows.Forms.ComboBox cbGeneroPelicula;
        private System.Windows.Forms.PictureBox ptbFotoPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Button btnCargarGeneros;
    }
}