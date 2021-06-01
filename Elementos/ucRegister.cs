using System;
using System.Windows.Forms;

namespace Elementos
{
    public partial class ucRegister : UserControl
    {
        public ucRegister()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();
        ErrorProvider ep = new ErrorProvider();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validarcampos())
                {
                    consulta.cn.Open();
                    consulta.Consulta("INSERT INTO usuarios (nombreUsuariO, contraseñaUsuario) VALUES ('" + txtUser.Text + "', '" + txtPassword.Text + "')");
                    MessageBox.Show("Se registro el usuario.");
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos.");
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
            {
                ep.SetError(txtUser, "Ingrese cuenta");
            }
            else if (txtPassword.Text == "" || txtPassword.Text == null)
            {
                ep.SetError(txtPassword, "Ingrese contraseña");
            }
            else if (txtPassword.Text != txtPasswordC.Text)
            {
                ep.SetError(txtPasswordC, "Las contraseñas no concuerdan.");
            }
            else
            {
                ok = true;
            }

            return ok;
        }
    }
}
