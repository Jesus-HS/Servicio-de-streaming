using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elementos;
using MySql.Data.MySqlClient;

namespace serviciosstreaming
{
    public partial class frmPeliculas : Form
    {
        string[] categorias;
        Consultas consultas = new Consultas();
        DataTable dt;
        public frmPeliculas()
        {
            InitializeComponent();
            dt = new DataTable();
            dt = consultas.obtenerTabla("SELECT nombreGenero FROM generos");
            categorias = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbGeneros.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }
        }

        
        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            consultas.cmd.Connection = consultas.cn;
            MemoryStream ms = new MemoryStream();

            //Insertamos
            consultas.cmd.CommandText = "CALL insertarPelicula ('" + txtNomPelicula.Text + "','" + richDescripcion.Text + "',@portada)";
            ptbFotoPelicula.Image.Save(ms, ImageFormat.Jpeg);
            consultas.cmd.Parameters.Add(new MySqlParameter("@portada", ms.GetBuffer()));
            consultas.cn.Open();
            consultas.cmd.ExecuteNonQuery();
            consultas.cn.Close();          



        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            //textodeformato(*.formato) | *.formato | otroformato(*.formato2 *) | *.formato2
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Archivos jpg(*.jpg)|*.jpg| Archivos png(*.png)|*.png";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ptbFotoPelicula.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnCargarCategoria_Click(object sender, EventArgs e)
        {
            
            
            //cargar a lista
            //mostrar lista
        }
    }
}
