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
    public partial class pantallaAI : UserControl
    {
        public pantallaAI()
        {
            InitializeComponent();
        }

        private void pantallaAI_Load(object sender, EventArgs e)
        {
            dgvAsistenciaInstitucion.Font = new Font("Footlight MT Light ", 12, FontStyle.Regular);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
