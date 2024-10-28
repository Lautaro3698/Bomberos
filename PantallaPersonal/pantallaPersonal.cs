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
    public partial class pantallaPersonal : UserControl
    {
        public pantallaPersonal()
        {
            InitializeComponent();
        }

        private void pantallaPersonal_Load(object sender, EventArgs e)
        {
            dgvPersonal.Font = new Font("Footlight MT Light ", 12, FontStyle.Regular);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
