using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Elementos
{
    class Consultas
    {
        public SqlConnection cn;
        public SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;

        /// <summary> 
        /// Realiza una conexion a la tabla
        /// </summary>
        public Consultas()
        {
            try
            {
                cn = new SqlConnection("Data Source=LAPTOP-L0KF26J2\\SQLEXPRESS; Initial Catalog=peliculasweb; Integrated Security=True");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se logro acceder a la base de datos" + ex);
            }
        }
        /// <summary> 
        /// Metodo para mostrar o buscar dentro de una tabla, recibe DataGridView para actualizar y una consulta
        /// </summary>
        public void Consulta(DataGridView dgv, string consulta)
        {
            try
            {
                da = new SqlDataAdapter(consulta, cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido mostrar la tabla, código de error: \n" + ex);
            }
        }
       
        /// <summary> 
        /// Recibe solo 1 parametro, para consulta sobre insertar, borrar o modificar
        /// </summary>
        public void Consulta(string consulta)
        {
            try
            {
                cmd = new SqlCommand(consulta, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro insertar:" + ex);
            }
        }
    }
}
