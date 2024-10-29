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
    public partial class pantallaNotificaciones : UserControl
    {
        public pantallaNotificaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pantallaNotificaciones_Load(object sender, EventArgs e)
        {
            dgvNotificaciones.Font = new Font("Footlight MT Light ", 12, FontStyle.Regular);
        }

        private void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
