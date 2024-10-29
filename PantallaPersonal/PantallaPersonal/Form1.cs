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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pantallaInicio Inicio = new pantallaInicio();
            panel4.Controls.Clear();
            Inicio.Dock = DockStyle.Fill;
            panel4.Controls.Add(Inicio);
            Inicio.Show();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            pantallaInicio Inicio = new pantallaInicio();
            panel4.Controls.Clear();
            Inicio.Dock = DockStyle.Fill;
            panel4.Controls.Add(Inicio);
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
             Áreas pantallaAreas = new Áreas();
            panel4.Controls.Clear();
            pantallaAreas.Dock = DockStyle.Fill; 
            panel4.Controls.Add(pantallaAreas);
            pantallaAreas.Show();
        }

        private void btnAsistenciaArea_Click(object sender, EventArgs e)
        {
            pantallaAA asisteciasAreas = new pantallaAA();
            panel4.Controls.Clear();
            asisteciasAreas.Dock = DockStyle.Fill;
            panel4.Controls.Add(asisteciasAreas);
            asisteciasAreas.Show();
        }

        private void btnAsistenciaInstitucion_Click(object sender, EventArgs e)
        {
            pantallaAI pantallaInstitucion = new pantallaAI();
            panel4.Controls.Clear();
            pantallaInstitucion.Dock = DockStyle.Fill;
            panel4.Controls.Add(pantallaInstitucion);
            pantallaInstitucion.Show();

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            pantallaPersonal pantallaPersonal = new pantallaPersonal();
            panel4.Controls.Clear();
            pantallaPersonal.Dock = DockStyle.Fill;
            panel4.Controls.Add(pantallaPersonal);
            pantallaPersonal.Show();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            pantallaNotificaciones notificaciones = new pantallaNotificaciones();
            panel4.Controls.Clear();
            notificaciones.Dock = DockStyle.Fill;
            panel4.Controls.Add(notificaciones);
            notificaciones.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
