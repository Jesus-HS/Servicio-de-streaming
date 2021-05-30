using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-560QHQJK;Integrated Security=SSPI;Initial Catalog=PeliculasWeb");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        private void button1_Click(object sender, EventArgs e)
        {
            //textodeformato (*.formato)|*.formato| otroformato (*.formato2*)|*.formato2
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Archivos jpg(*.jpg)|*.jpg| Archivos png(*.png)|*.png";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            MemoryStream ms = new MemoryStream();
            //Insertamos
            cmd.CommandText = "INSERT INTO peliculas VALUES('" + textBox1.Text + "','" + richTextBox1.Text + "',@portada)";
            pictureBox2.Image.Save(ms, ImageFormat.Jpeg);
            cmd.Parameters.Add(new SqlParameter("@portada", ms.GetBuffer()));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select portada from peliculas WHERE idPelicula = 5",cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet("peliculas");

            byte[] MisDatos = new byte[0];


            cn.Open();
            da.Fill(ds, "peliculas");
            dr = ds.Tables["peliculas"].Rows[0];
            MisDatos = (byte[])dr["portada"];
            MemoryStream ms = new MemoryStream(MisDatos);
            pictureBox3.Image = Image.FromStream(ms);
            ms.Position = 0;
            cn.Close();
        }
    }
}
