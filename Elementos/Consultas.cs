using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elementos
{
    class Consultas
    {
        MySqlConnection cn;
        MySqlCommand cmd;
        DataTable dt;
        MySqlDataAdapter da;
        DataSet ds;


        /// <summary> 
        /// Realiza una conexion a la tabla
        /// </summary>
        public Consultas()
        {
            try
            {
                cn = new MySqlConnection("server=usla641.gamedata.io; database=ni5508816_1_DB; Uid=ni5508816_1_DB; pwd=y0GuL29g; ");
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
                da = new MySqlDataAdapter(consulta, cn);
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
                cmd = new MySqlCommand(consulta, cn);
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
            da = new MySqlDataAdapter(consulta, cn);
            da.Fill(ds);
            return ds.Tables[0].Rows[0][columna].ToString().Trim();
        }
    }
}
