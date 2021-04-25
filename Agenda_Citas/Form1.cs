using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Citas
{
    public partial class Form1 : Form
    {
        List<FlowLayoutPanel> listFlDay = new List<FlowLayoutPanel>();
        private DateTime diaactual = DateTime.Today;
        public Form1()
        {
            InitializeComponent();
        }
        private void GenerarDiasPanel(int diastotales)
        {
            flDias.Controls.Clear();
            listFlDay.Clear();
            for (int i = 1; i < diastotales; i++)
            {
                FlowLayoutPanel fl = new FlowLayoutPanel();
                fl.Name = $"flDay{i}";
                fl.Size = new Size(128,99);
                fl.BackColor = Color.White;
                fl.BorderStyle = BorderStyle.FixedSingle;
                flDias.Controls.Add(fl);
                listFlDay.Add(fl);
            }
        }
        private void Agregarlabelparalosdias(int inicia_dias, int diastotales)
        {
            for (int i = inicia_dias; i < diastotales; i++)
            {
                Label lbl = new Label();
                lbl.Name = $"lblDay{i}";
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(125, 22);
                lbl.Text = i.ToString();
                listFlDay[(i-1) + (inicia_dias-1)].Controls.Add(lbl);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarDiasPanel(42);
            Agregarlabelparalosdias(1,31);
        }
    }
}
