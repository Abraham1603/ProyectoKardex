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
            string id = txtid.Text;
            string c1 = p1.Text;
            string c2 = p2.Text;
            string c3 = p3.Text;
            string calf = cf.Text;



            bl.ActualizaCalificacion(id, c1,c2,c3,calf);

            txtid.Clear();
            txtal.Clear();
            p1.Clear();
            p2.Clear();
            p3.Clear();
            cf.Clear();


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
            txtal.Text = dtcali.CurrentRow.Cells[1].Value.ToString();
            p1.Text = dtcali.CurrentRow.Cells[2].Value.ToString();
            p2.Text = dtcali.CurrentRow.Cells[3].Value.ToString();
            p3.Text = dtcali.CurrentRow.Cells[4].Value.ToString();
            cf.Text = dtcali.CurrentRow.Cells[5].Value.ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {

            float op;
            float op2;

            float c1 = float.Parse(p1.Text);
            float c2 = float.Parse(p2.Text);
            float c3 = float.Parse(p3.Text);

            op = c1 + c2 + c3;
            op2 = op / 3;
            
            if((Convert.ToInt32(p1.Text) < 0) || (Convert.ToInt32(p2.Text) < 0) || (Convert.ToInt32(p3.Text) < 0))
            {
                MessageBox.Show("Ingresa valores mayores a 0");
            }
            else
            {
                cf.Text = Convert.ToString(op2);
            }
          
        }
    }
}
