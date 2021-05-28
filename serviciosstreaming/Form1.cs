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
        SqlConnection cn = new SqlConnection("Data Source = LAPTOP-L0KF26J2\\SQLEXPRESS; Initial Catalog = PeliculasWeb; Integrated Security = True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
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
            pictureBox2.Image.Save(ms, ImageFormat.Jpeg);
            //Insertamos
            cmd.CommandText = "INSERT INTO peliculas VALUES('" + textBox1.Text + "','" + richTextBox1.Text + "', '"+ ms.GetBuffer() + "')";
       
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            da = new SqlDataAdapter("SELECT *FROM peliculas", cn);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}
