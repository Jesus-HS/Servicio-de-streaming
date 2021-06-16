using Elementos;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class frmMostrarPelicula : Form
    {
        string _idUsuario, _idPelicula;
        public frmMostrarPelicula(string idPelicula, string idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _idPelicula = idPelicula;
            cargarPortada(idPelicula);
            cargarComentarios(idPelicula);
            cargarInformacion(idPelicula);
        }
        Consultas query = new Consultas();
        void cargarPortada(string id)
        {
            DataTable dt = new DataTable();
            dt = query.obtenerTabla("SELECT idPelicula, portadaPelicula FROM peliculas WHERE idPelicula ="+ id);
            pbPortada.Name = id;
            
            byte[] MisDatos = (byte[])dt.Rows[0]["portadaPelicula"];
            MemoryStream ms = new MemoryStream(MisDatos);
            pbPortada.Image = Image.FromStream(ms);
        }
        void cargarComentarios(string id)
        {
            //Obtenemos la tabla
            DataTable dt = query.obtenerTabla("SELECT *FROM comentarios WHERE idPelicula = " + id);
            //Usamos la cantidad de renglones en contador para asi imprimir uno por uno
            int contador = dt.Rows.Count;
            //Comenzamos a imprimir los comentarios
            for (int i = 0; i < contador; i++)
            {
                //declaramos un comentario nuevo
                //Asi no usamos uno solo para estar sobreescribiendo
                ucComentarios comentario = new ucComentarios();
                //obtenemos la tabla para imprimir el primer comentario
                dt = query.obtenerTabla("SELECT *FROM comentarios WHERE idPelicula = " + id);
                //asignamos el primer comentario al atributo comentario de nuestro control
                comentario.Comentario = dt.Rows[i]["comentario"].ToString();

                //obtenemos la tabla del usuario que comento
                dt = query.obtenerTabla("SELECT *FROM usuarios WHERE idUsuario =" + dt.Rows[i]["idUsuario"].ToString());
                //aqui usamos un ciclo aparte porque la tabla de usuario siempre tendra 1 solo valor porque es el que comento 1 por el id
                for (int j = 0; j < 1; j++)
                {
                    //obtenemos el unico valor de la tabla en el atributo usuario
                    comentario.Usuario = dt.Rows[j]["nombreUsuario"].ToString();
                }
                //Agregar el control (comentario)
                panelComentarios.Controls.Add(comentario);
            }
        }

        void cargarInformacion(string id)
        {
            DataTable dt = query.obtenerTabla("SELECT *FROM peliculas WHERE idPelicula = " + id);
            lblPelicula.Text = dt.Rows[0]["nombrePelicula"].ToString();
            txtDescripcion.Text = dt.Rows[0]["descripcionPelicula"].ToString();

            //Plataforma
            dt = query.obtenerTabla("CALL mostrarPlataformas(" + id + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformas.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            //Generos
            dt = query.obtenerTabla("CALL mostrarGeneros("+id+")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneros.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            //Actores
            dt = query.obtenerTabla("CALL mostrarActores(" + id + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbActores.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            //Directores
            dt = query.obtenerTabla("CALL mostrarDirectores(" + id + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbDirectores.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }
        private void btnPublicar_Click(object sender, System.EventArgs e)
        {
            panelComentarios.Controls.Clear();
            query.Consulta("CALL insertarComentario(" + _idUsuario + ",'" + richComentar.Text + "', " + _idPelicula + ")");
            cargarComentarios(_idPelicula);
        }
    }
}