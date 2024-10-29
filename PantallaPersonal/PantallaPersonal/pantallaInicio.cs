using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaPersonal
{
    public partial class pantallaInicio : UserControl
    {
        public pantallaInicio()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PantallaEmeregencai frmlEmergencia = new PantallaEmeregencai();
            frmlEmergencia.Show();

           //Form1 inicio = new Form1();
           // inicio.panel4.Controls.Clear();      
           //frmlEmergencia.Dock = DockStyle.Fill;
           //inicio.panel4.Controls.Add(frmlEmergencia);
           //frmlEmergencia.Show();

        }

        private void panel45645_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emergencia registrada", "Atencion",MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TareasRealizadas pantallaTareasRealizadas = new TareasRealizadas();
            pantallaTareasRealizadas.Show();
        }

        private void panel78_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
