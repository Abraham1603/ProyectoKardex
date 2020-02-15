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
    public partial class FrmAltaMaestro : Form
    {
        BL bl = new BL();
        public FrmAltaMaestro()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.ToString();
            string telefono = txtTelefono.Text.ToString();
            string pass = txtPass.Text.ToString();

            DateTime fechaalta = Convert.ToDateTime(dtpFechaAlta.Value.ToString());

            string fecha = Convert.ToString(fechaalta);


            DataTable dt = bl.validamaestro(nombre);
            if (dt.Rows.Count > 0)
            {
                dtca.DataSource = dt;
                string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

                if (a == nombre)
                {
                    MessageBox.Show("El maestro ya existe");
                }
                MessageBox.Show("El maestro ya existe");
            }
            else
            {
                bl.AltaMaestro(nombre,direccion, telefono, pass, fecha );

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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gbAltaMaestro_Enter(object sender, EventArgs e)
        {

        }
    }
}
