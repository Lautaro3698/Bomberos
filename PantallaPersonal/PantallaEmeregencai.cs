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
    public partial class PantallaEmeregencai : Form
    {
        public PantallaEmeregencai()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PantallaEmeregencai_Load(object sender, EventArgs e)
        {
            dgvEmergencia.Rows.Add("0001", "12/9/2024", "20:30");
         }
    }
}
