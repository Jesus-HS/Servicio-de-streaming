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
        string idPelicula;
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

            //CARGAR PLATAFORMAS
            dt = consultas.obtenerTabla("SELECT nombrePlataforma FROM plataformas");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformas.Items.Add(dt.Rows[i].ItemArray[0].ToString());

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

            dt = consultas.obtenerTabla("CALL mostrarGeneros("+idPelicula+")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneroPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
<<<<<<< HEAD
        }

        private void btnCargarPlataforma_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT idPlataforma FROM plataformas WHERE nombrePlataforma = '" + cbPlataformas.Text + "'";
            DataTable dt = consultas.obtenerTabla(consulta);
            string idPlataforma = dt.Rows[0].ItemArray[0].ToString().Trim();

            consulta = "SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + txtNomPelicula.Text + "'";
            dt = consultas.obtenerTabla(consulta);
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            consulta = "CALL insertarContiene(" + idPelicula + "," + idPlataforma + ")";
            consultas.Consulta(consulta);

            cbPlataformaPelicula.Items.Clear();

            dt = consultas.obtenerTabla("CALL mostrarPlataformas("+idPelicula+")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformaPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void btnCargarPelicula_Click(object sender, EventArgs e)
        {
            txtNomPelicula.Text = dgvPeliculas.CurrentCell.Value.ToString();
            DataTable dt = consultas.obtenerTabla("SELECT *FROM peliculas WHERE nombrePelicula = '" + txtNomPelicula.Text + "'");
            idPelicula = dt.Rows[0]["idPelicula"].ToString().Trim();
            richDescripcion.Text = dt.Rows[0]["descripcionPelicula"].ToString();

            dt = consultas.obtenerTabla("CALL mostrarPlataformas(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformaPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = consultas.obtenerTabla("CALL mostrarGeneros(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneroPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            consultas.Consulta("UPDATE peliculas SET nombrePelicula = '" + txtNomPelicula.Text + "', descripcionPelicula = '" + richDescripcion.Text + "' WHERE idPelicula =" + idPelicula);
        }

        private void btnCargarActores_Click(object sender, EventArgs e)
        {
            //OBTENEMOS ID DEL ACTOR
            string consulta = "SELECT idActores FROM plataformas WHERE nombreActor = '" + cbActores.Text + "'";
            DataTable dt = consultas.obtenerTabla(consulta);
            string idActor = dt.Rows[0].ItemArray[0].ToString().Trim();

            //OBTENEMOS ID DE LA PELICULA
            consulta = "SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + txtNomPelicula.Text + "'";
            dt = consultas.obtenerTabla(consulta);
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            //INGRESAMOS los valores a
            consulta = "CALL insertarInterpretes(" + idActor + "," + idPelicula + ")";
            consultas.Consulta(consulta);

            cbPlataformaPelicula.Items.Clear();

            dt = consultas.obtenerTabla("CALL mostrarPlataformas(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformaPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
=======
>>>>>>> 37963eaa9110dd0fa6608ce883e6b728e04aa62e
        }
    }
}