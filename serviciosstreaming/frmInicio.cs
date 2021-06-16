using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            lblTitulo.Text = Text;
        }

        private void ucLog1_Load(object sender, EventArgs e)
        {

        }
    }
}
