using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Elementos
{
    public partial class ucRegister : UserControl
    {
        public ucRegister()
        {
            InitializeComponent();
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, 0);
            panel3.Location = new Point(0, 0);
        }
        Consultas query = new Consultas();
        ErrorProvider ep = new ErrorProvider();

        public object id { get; private set; }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validarcampos())
            {
                query.Consulta("INSERT INTO usuarios (nombreUsuariO, contraseñaUsuario) VALUES ('" + txtUser.Text + "', '" + txtPassword.Text + "')");
                MessageBox.Show("Se registro el usuario.");
            }
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

        private bool Validarcampos()
        {
            bool ok = false;
            if (txtUser.Text == "" || txtUser.Text == null)
                ep.SetError(txtUser, "Ingrese cuenta");
            else if (txtPassword.Text == "" || txtPassword.Text == null)
                ep.SetError(txtPassword, "Ingrese contraseña");
            else if (txtPassword.Text != txtPasswordC.Text)
                ep.SetError(txtPasswordC, "Las contraseñas no concuerdan.");
            else
                ok = true;

            return ok;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("SELECT * FROM usuarios WHERE nombreUsuario = '{0}' " +
                "AND contraseñaUsuario = '{1}'", txtUser.Text.Trim(), txtPassword.Text.Trim());
            
            id = query.Consulta("idUsuario", consulta);

            string account = query.Consulta("nombreUsuario", consulta);
            string pass = query.Consulta("contrasenaUsuario", consulta);

            /* Si los datos almacenados en las variables corresponden a los mismo que los ingresados en
               las cajas de texto entonces nos lanza el formulario principal */
            if (account == txtUser.Text.Trim() && pass == txtPassword.Text.Trim())
            {
                
            }
        }
    }
}
