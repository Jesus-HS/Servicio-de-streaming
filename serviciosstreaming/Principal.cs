using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Diseno();
        }
        private void Diseno()
        {
            panel2.Visible = false;
        }
        private void hide()
        {
            if(panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
        private void Show(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hide();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Show(panel2);
        }
    }
}