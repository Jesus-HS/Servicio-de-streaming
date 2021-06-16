using System;
using System.Windows.Forms;
using Elementos;

namespace serviciosstreaming
{
    public partial class frmAgregarTipos : Form
    {
        public frmAgregarTipos()
        {
            InitializeComponent();
            dgvTipos.DataSource = query.obtenerTabla("SELECT nombreTipo 'Tipo' FROM tipos");
        }
        Consultas query = new Consultas();
        private void btnAgregarTipos_Click(object sender, EventArgs e)
        {
            query.Consulta("CALL insertarTipo('" + txtTipos.Text + "')");
            dgvTipos.DataSource = query.obtenerTabla("SELECT nombreTipo 'Tipo' FROM tipos");
        }
    }
}
