using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kardex.Layers;

namespace PlayerUI
{
    public partial class frmConsultaCampus : Form
    {
        BL bl = new BL();
        public frmConsultaCampus()
        {
            InitializeComponent();
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvCarrera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaCarrera_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
