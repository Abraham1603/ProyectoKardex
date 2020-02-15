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
    public partial class frmAltaMateria : Form
    {
        BL bl = new BL();
        public frmAltaMateria()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string materia = txtMateria.Text.Trim();

            DateTime fechaalta = Convert.ToDateTime(dtpFechaAlta.Value.ToString());

            string fecha = Convert.ToString(fechaalta);

            DataTable dt = bl.validamateria(materia);
            if (dt.Rows.Count > 0)
            {
                dtma.DataSource = dt;
                string a = Convert.ToString(dtma.Rows[0].Cells[0].Value.ToString());

                if (a == materia)
                {
                    MessageBox.Show("La materia ya existe");
                }

            }
            else
            {

                bl.AltaMateria(materia, fecha);

            }
         
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void TxtMateria_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gbAltaCarrera_Enter(object sender, EventArgs e)
        {

        }
    }
}
