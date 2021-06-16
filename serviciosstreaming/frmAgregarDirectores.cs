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
    public partial class frmAgregarDirectores : Form
    {
        public frmAgregarDirectores()
        {
            InitializeComponent();
            dgvDirectores.DataSource = query.obtenerTabla("SELECT nombreDirector 'Nombre del Director' FROM directores");
        }
        Consultas query = new Consultas();
        private void btnAgregarDirector_Click(object sender, EventArgs e)
        {
            query.Consulta("CALL insertarDirector('" + txtDirector.Text + "')");
            dgvDirectores.DataSource = query.obtenerTabla("SELECT nombreDirector 'Nombre del Director' FROM directores");
        }
    }
}
