using System;
using System.Data;
using System.Windows.Forms;

namespace Elementos
{
    public partial class ucLogin: UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                /* Se le asigna a CMD la sentencia y con DataSet de la libreria Utilidades se va a Ejecutar la sentencia 
                 * almacenada en CMD */
                string CMD = string.Format("SELECT * FROM usuarios WHERE nombreUsuario = '{0}' " +
                    "AND contraseñaUsuario = '{1}'", txtUser.Text.Trim(), txtPassword.Text.Trim());
                //DataSet ds = Utilidades.Ejecutar(CMD);

                //Codigo = ds.Tables[0].Rows[0]["idUsuario"].ToString().Trim();

                //string cuenta = ds.Tables[0].Rows[0]["nombreUsuario"].ToString().Trim();
                //string passw = ds.Tables[0].Rows[0]["contraseñaUsuario"].ToString().Trim();

                /* Si los datos almacenados en las variables corresponden a los mismo que los ingresados en
                   las cajas de texto entonces nos lanza el formulario principal */
                //if (cuenta == txtUser.Text.Trim() && passw == txtPassword.Text.Trim())
                //{
                    
                    
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos.");
            }
        }
    }
}
