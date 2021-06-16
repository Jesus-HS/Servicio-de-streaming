using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Elementos;
using MySql.Data.MySqlClient;

namespace serviciosstreaming
{
    public partial class frmAgregarPeliculas : Form
    {
        Consultas consultas = new Consultas();
        DataTable dt;
        public frmAgregarPeliculas()
        {
            InitializeComponent();
            //Carga categorias, actores, directores
            cargarElementos();
            
        }
        void cargarElementos()
        {
            dt = new DataTable();

            //CARGAR GENEROS
            dt = consultas.obtenerTabla("SELECT nombreGenero FROM generos");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneros.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            //CARGAR ACTORES
            dt = consultas.obtenerTabla("SELECT nombreActor FROM actores");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbActores.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            //CARGAR DIRECTORES
            dt = consultas.obtenerTabla("SELECT nombreDirector FROM directores");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbDirectores.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dgvPeliculas.DataSource = consultas.obtenerTabla("SELECT nombrePelicula FROM peliculas");
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar la pelicula");
                throw;
            }
            finally
            {
                MessageBox.Show("Se logro insertar la pelicula");
                txtNomPelicula.Clear();
                richDescripcion.Clear();
                cbActorPelicula.Items.Clear();
                cbDirectorPelicula.Items.Clear();
                cbGeneroPelicula.Items.Clear();
            }
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
            string consulta = "SELECT idGenero FROM generos WHERE nombreGenero = '" + cbGeneros.Text + "'";
            DataTable dt = consultas.obtenerTabla(consulta);
            string idGenero = dt.Rows[0].ItemArray[0].ToString().Trim();

            consulta = "SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + txtNomPelicula.Text + "'";
            dt = consultas.obtenerTabla(consulta);
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            consulta = "CALL insertarCategoria(" + idPelicula + "," + idGenero + ")";
            consultas.Consulta(consulta);

            cbGeneroPelicula.Items.Clear();

            dt = consultas.obtenerTabla("SELECT nombreGenero FROM generos");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneroPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

        }
    }
}
