
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
            this.richDescripcion = new System.Windows.Forms.RichTextBox();
            this.panelActores = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDirectores = new System.Windows.Forms.FlowLayoutPanel();
            this.panelComentarios = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.panelComentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(270, 12);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(68, 13);
            this.lblPelicula.TabIndex = 1;
            this.lblPelicula.Text = "titulo pelicula";
            // 
            // richDescripcion
            // 
            this.richDescripcion.Location = new System.Drawing.Point(273, 58);
            this.richDescripcion.Name = "richDescripcion";
            this.richDescripcion.Size = new System.Drawing.Size(255, 100);
            this.richDescripcion.TabIndex = 2;
            this.richDescripcion.Text = "";
            // 
            // panelActores
            // 
            this.panelActores.Location = new System.Drawing.Point(273, 200);
            this.panelActores.Name = "panelActores";
            this.panelActores.Size = new System.Drawing.Size(201, 30);
            this.panelActores.TabIndex = 4;
            // 
            // panelDirectores
            // 
            this.panelDirectores.Location = new System.Drawing.Point(273, 164);
            this.panelDirectores.Name = "panelDirectores";
            this.panelDirectores.Size = new System.Drawing.Size(201, 30);
            this.panelDirectores.TabIndex = 5;
            // 
            // panelComentarios
            // 
            this.panelComentarios.AutoScroll = true;
            this.panelComentarios.Controls.Add(this.richTextBox1);
            this.panelComentarios.Controls.Add(this.button1);
            this.panelComentarios.Location = new System.Drawing.Point(12, 420);
            this.panelComentarios.Name = "panelComentarios";
            this.panelComentarios.Size = new System.Drawing.Size(516, 251);
            this.panelComentarios.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 48);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // frmMostrarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 683);
            this.Controls.Add(this.panelComentarios);
            this.Controls.Add(this.panelDirectores);
            this.Controls.Add(this.panelActores);
            this.Controls.Add(this.richDescripcion);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.pbPortada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelicula";
            this.panelComentarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.RichTextBox richDescripcion;
        private System.Windows.Forms.FlowLayoutPanel panelActores;
        private System.Windows.Forms.FlowLayoutPanel panelDirectores;
        private System.Windows.Forms.FlowLayoutPanel panelComentarios;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}