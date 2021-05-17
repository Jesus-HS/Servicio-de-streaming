using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Agenda_Citas
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayudaDeAgendaSpaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Abrir pdf de MANUAL DE USUARIO 
               falta checar bien la ruta */
            Process pro = new Process();
            pro.StartInfo.FileName = (@"C:\Users\melis\OneDrive\Escritorio\MANUAL DE USUARIO.pdf");
            pro.Start();
        }

        private void acercaDeAgendaSpaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.Show();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas();
            herramientas.Show();
        }
    }
}
