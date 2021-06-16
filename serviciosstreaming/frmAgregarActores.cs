using System;
using System.Windows.Forms;
using Elementos;

namespace serviciosstreaming
{
    public partial class frmAgregarActores : Form
    {
        public frmAgregarActores()
        {
            InitializeComponent();
            dgvActores.DataSource = query.obtenerTabla("SELECT nombreActor 'Nombre del Actor' FROM actores");
        }
        Consultas query = new Consultas();
        private void btnAgregarActor_Click(object sender, EventArgs e)
        {
            query.Consulta("CALL insertarActor('" + txtActor.Text + "')");
            dgvActores.DataSource = query.obtenerTabla("SELECT nombreActor 'Nombre del Actor' FROM actores");
        }
    }
}
