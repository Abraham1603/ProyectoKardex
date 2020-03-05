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
    public partial class FrmAltaPeriodo : Form
    {
        BL bl = new BL();
        public FrmAltaPeriodo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string carrera = txtPeriodo.Text.Trim();

            DateTime fechaalta = Convert.ToDateTime(dtpFechaAlta.Value.ToString());

            string fecha = Convert.ToString(fechaalta);


            DataTable dt = bl.validaperiodo("todas");
            if (dt.Rows.Count > 0)
            {
                dtca.DataSource = dt;
                /*string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

                if (a == carrera)
                {
                    MessageBox.Show("El Periodo ya existe");
                }*/
                MessageBox.Show("No pueden existir mas de un periodo activo");
            }
            else
            {



                DataTable dt2 = bl.validaperiodoinactivo(carrera);
                if (dt2.Rows.Count > 0)
                {
                    dtca2.DataSource = dt2;
                    string b = Convert.ToString(dtca2.Rows[0].Cells[0].Value.ToString());

                    if (b == carrera)
                    {
                        MessageBox.Show("El Periodo ya existe y se encuentra dada de baja");
                    }

                    MessageBox.Show("El Periodo ya existe y se encuentra dada de baja");

                }
                else
                {
                    bl.AltaPeriodo(carrera, fecha);
                }

               


            }

            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
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

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaAlta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gbAltaCarrera_Enter(object sender, EventArgs e)
        {

        }
    }
}
