using Libary;
using System;
using System.Data;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string Codigo = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* Para que la casilla donde se ingres ala contraseña pueda ser visible 
               para el usuario */
            if (checkBox1.Checked == true)
            {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                }
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /* Se le asigna a CMD la sentencia y con DataSet de la libreria Utilidades se va a Ejecutar la sentencia 
                 * almacenada en CMD */
                string CMD = string.Format("SELECT * FROM usuarios WHERE nombreUsuario = '{0}' " +
                    "AND contraseñaUsuario = '{1}'", txtUser.Text.Trim(), txtPassword.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["idUsuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["nombreUsuario"].ToString().Trim();
                string passw = ds.Tables[0].Rows[0]["contraseñaUsuario"].ToString().Trim();

                /* Si los datos almacenados en las variables corresponden a los mismo que los ingresados en
                   las cajas de texto entonces nos lanza el formulario principal */
                if (cuenta == txtUser.Text.Trim() && passw == txtPassword.Text.Trim())
                {
                    Principal principal = new Principal();
                    principal.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos.");
            }
            Validarcampos();
        }
        /* Marcar error en caso de que que el usuario no llene alguna caja de texto */
        private bool Validarcampos()
        {
            bool ok = true;
            if (txtUser.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUser, "Ingrese cuenta");
            }
            if (txtPassword.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPassword, "Ingrese contraseña");
            }
            return ok;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.Show();
        }
    }

}
