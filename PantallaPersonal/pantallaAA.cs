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
    public partial class pantallaAA : UserControl
    {
        public pantallaAA()
        {
            InitializeComponent();
        }
        
        private void dgvAsistenciaArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pantallaAA_Load(object sender, EventArgs e)
        {
            dgvAsistenciaArea.Font = new Font("Footlight MT Light ", 12, FontStyle.Regular);
        }
    }
}
