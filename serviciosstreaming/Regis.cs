using Libary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class Regis : Form
    {
        public Regis()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-560QHQJK;Integrated Security=SSPI;Initial Catalog=PeliculasWeb");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Validarcampos();
                conexion.Open();

                SqlCommand altas = new SqlCommand("INSERT INTO usuarios (nombreUsuariO, contraseñaUsuario) VALUES (@nombreUsuario, @contraseñaUsuario)", conexion);

                altas.Parameters.AddWithValue("@nombreUsuario", txtUser.Text);
                altas.Parameters.AddWithValue("@contraseñaUsuario", txtPassword.Text);

                altas.ExecuteNonQuery();

                txtUser.Clear();
                txtPassword.Clear();

                MessageBox.Show("Se registro el usuario.");

                conexion.Close();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos.");
            }
            
        }
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
    }
}
