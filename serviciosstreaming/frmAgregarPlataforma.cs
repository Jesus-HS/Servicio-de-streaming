using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elementos;

namespace serviciosstreaming
{
    public partial class frmAgregarPlataforma : Form
    {
        public frmAgregarPlataforma()
        {
            InitializeComponent();
            mostrar();
            label1.Text = this.Text;
        }
        Consultas query = new Consultas();
        private void mostrar()
        {
            dgv.DataSource = query.obtenerTabla("SELECT nombrePlataforma 'Plataforma' FROM plataformas");
            dgv.Columns[0].Width = 180;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            query.Consulta("CALL insertarPlataforma('" + txtTexto.Text + "')");
            mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            query.Consulta("DELETE FROM plataformas WHERE nombrePlataforma = '" + dgv.CurrentCell.Value + "'");
            mostrar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            query.Consulta("UPDATE plataformas set nombrePlataforma = '" + txtTexto.Text + "' WHERE nombrePlataforma ='" + dgv.CurrentCell.Value + "'");
            mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = query.obtenerTabla("SELECT nombrePlataforma FROM plataformas WHERE nombrePlataforma ='" + txtTexto.Text + "'");
        }

        private void txtTexto_MouseLeave(object sender, EventArgs e)
        {
            if (txtTexto.Text == "") txtTexto.Text = "Plataforma";
        }

        private void txtTexto_MouseEnter(object sender, EventArgs e)
        {
            if(txtTexto.Text == "Plataforma") txtTexto.Clear();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Para mover la forma sin borde
        int posicion_x = 0, posicion_y = 0;
        private void frmAgregarPlataforma_MouseMove(object sender, MouseEventArgs e)
        {
            //Si Boton izquierdo esta activo
            if (e.Button != MouseButtons.Left)
            {
                //Posicion del boton se mandara a posicion de la ventana respecto a la pantalla
                posicion_x = e.X;
                posicion_y = e.Y;
            }
            else
            {
                Left = Left + (e.X - posicion_x);
                Top = Top + (e.Y - posicion_y);
            }
        }
    }
}
