
namespace serviciosstreaming
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuarioLogeado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTipos = new System.Windows.Forms.Button();
            this.btnActores = new System.Windows.Forms.Button();
            this.btnPlataforma = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnDirectores = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.flpPeliculas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnUsuarioLogeado);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnUsuarioLogeado
            // 
            this.btnUsuarioLogeado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnUsuarioLogeado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUsuarioLogeado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUsuarioLogeado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarioLogeado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioLogeado.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioLogeado.Location = new System.Drawing.Point(657, 0);
            this.btnUsuarioLogeado.Name = "btnUsuarioLogeado";
            this.btnUsuarioLogeado.Size = new System.Drawing.Size(144, 69);
            this.btnUsuarioLogeado.TabIndex = 3;
            this.btnUsuarioLogeado.Text = "Usuario";
            this.btnUsuarioLogeado.UseVisualStyleBackColor = true;
            this.btnUsuarioLogeado.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTipos);
            this.panel2.Controls.Add(this.btnActores);
            this.panel2.Controls.Add(this.btnPlataforma);
            this.panel2.Controls.Add(this.btnCategorias);
            this.panel2.Controls.Add(this.btnDirectores);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btnPeliculas);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(667, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 218);
            this.panel2.TabIndex = 1;
            // 
            // btnTipos
            // 
            this.btnTipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTipos.FlatAppearance.BorderSize = 0;
            this.btnTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnTipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipos.ForeColor = System.Drawing.Color.White;
            this.btnTipos.Location = new System.Drawing.Point(0, 175);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTipos.Size = new System.Drawing.Size(142, 35);
            this.btnTipos.TabIndex = 10;
            this.btnTipos.Text = "Tipos";
            this.btnTipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipos.UseVisualStyleBackColor = true;
            this.btnTipos.Click += new System.EventHandler(this.btnTipos_Click);
            // 
            // btnActores
            // 
            this.btnActores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActores.FlatAppearance.BorderSize = 0;
            this.btnActores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnActores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActores.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActores.ForeColor = System.Drawing.Color.White;
            this.btnActores.Location = new System.Drawing.Point(0, 140);
            this.btnActores.Name = "btnActores";
            this.btnActores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActores.Size = new System.Drawing.Size(142, 35);
            this.btnActores.TabIndex = 9;
            this.btnActores.Text = "Actores";
            this.btnActores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActores.UseVisualStyleBackColor = true;
            this.btnActores.Click += new System.EventHandler(this.btnActores_Click);
            // 
            // btnPlataforma
            // 
            this.btnPlataforma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlataforma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlataforma.FlatAppearance.BorderSize = 0;
            this.btnPlataforma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPlataforma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlataforma.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlataforma.ForeColor = System.Drawing.Color.White;
            this.btnPlataforma.Location = new System.Drawing.Point(0, 105);
            this.btnPlataforma.Name = "btnPlataforma";
            this.btnPlataforma.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlataforma.Size = new System.Drawing.Size(142, 35);
            this.btnPlataforma.TabIndex = 8;
            this.btnPlataforma.Text = "Plataforma";
            this.btnPlataforma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlataforma.UseVisualStyleBackColor = true;
            this.btnPlataforma.Click += new System.EventHandler(this.btnPlataforma_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(0, 70);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(142, 35);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnDirectores
            // 
            this.btnDirectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirectores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDirectores.FlatAppearance.BorderSize = 0;
            this.btnDirectores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDirectores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDirectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectores.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectores.ForeColor = System.Drawing.Color.White;
            this.btnDirectores.Location = new System.Drawing.Point(0, 35);
            this.btnDirectores.Name = "btnDirectores";
            this.btnDirectores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDirectores.Size = new System.Drawing.Size(142, 35);
            this.btnDirectores.TabIndex = 6;
            this.btnDirectores.Text = "Directores";
            this.btnDirectores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectores.UseVisualStyleBackColor = true;
            this.btnDirectores.Click += new System.EventHandler(this.btnDirectores_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 35);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(142, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "Actores";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeliculas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculas.ForeColor = System.Drawing.Color.White;
            this.btnPeliculas.Location = new System.Drawing.Point(0, 0);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPeliculas.Size = new System.Drawing.Size(142, 35);
            this.btnPeliculas.TabIndex = 4;
            this.btnPeliculas.Text = "Peliculas";
            this.btnPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeliculas.UseVisualStyleBackColor = true;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // flpPeliculas
            // 
            this.flpPeliculas.Location = new System.Drawing.Point(12, 312);
            this.flpPeliculas.Name = "flpPeliculas";
            this.flpPeliculas.Size = new System.Drawing.Size(915, 185);
            this.flpPeliculas.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(818, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 69);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
<<<<<<< HEAD:serviciosstreaming/frmPrincipal.Designer.cs
            this.Name = "frmPrincipal";
=======
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e:serviciosstreaming/Principal.Designer.cs
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUsuarioLogeado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPlataforma;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnDirectores;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.FlowLayoutPanel flpPeliculas;
        private System.Windows.Forms.Button btnTipos;
        private System.Windows.Forms.Button btnActores;
        private System.Windows.Forms.Button btnSalir;
    }
}