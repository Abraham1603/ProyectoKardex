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
    public partial class frmmodificacalificacion : Form
    {
        BL bl = new BL();
        public frmmodificacalificacion()
        {
            InitializeComponent();
        }

        private void btnModificarCarrera_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            string cali = txtcali.Text;
            string uni = txtuni.Text;

            bl.ActualizaCalificacion(id, cali, uni);

            txtid.Clear();
            txtcali.Clear();
            txtuni.Clear();

            DataTable dt = bl.ConsultaCalificacion();

            if (dt.Rows.Count > 0)
            {
                dtcali.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay calificaciones con relaciones", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void frmmodificacalificacion_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.ConsultaCalificacion();

            if (dt.Rows.Count > 0)
            {
                dtcali.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay calificaciones con relaciones", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void gbCarrera_Enter(object sender, EventArgs e)
        {

        }

        private void dtcali_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dtcali.CurrentRow.Cells[0].Value.ToString();
            txtcali.Text = dtcali.CurrentRow.Cells[2].Value.ToString();
            txtuni.Text = dtcali.CurrentRow.Cells[3].Value.ToString();

        }

        private void txtcali_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
