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
            dgvPlataformas.DataSource = query.obtenerTabla("SELECT nombrePlataforma 'Plataforma de Streaming' FROM plataformas");
        }
        Consultas query = new Consultas();
        private void btnAgregarPlataforma_Click(object sender, EventArgs e)
        {
            query.Consulta("CALL insertarPlataforma('" + txtPlataforma.Text + "')");
            dgvPlataformas.DataSource = query.obtenerTabla("SELECT nombrePlataforma 'Plataforma de Streaming' FROM plataformas");
        }
    }
}
