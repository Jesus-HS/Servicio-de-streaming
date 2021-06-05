using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Elementos
{
    class Consultas
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;


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
        
        /// <summary>
        /// Recibe 2 parametros, la columna del dato que se quiere recibir y la consulta
        /// </sumary>
        public string Consulta(string columna,string consulta)
        {
            da = new SqlDataAdapter(consulta, cn);
            da.Fill(ds);
            return ds.Tables[0].Rows[0][columna].ToString().Trim();
        }
    }
}
