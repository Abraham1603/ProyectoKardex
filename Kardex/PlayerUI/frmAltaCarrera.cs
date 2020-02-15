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
    public partial class frmAltaCarrera : Form
    {
        BL bl = new BL();
        public Form1 frmconscarr;
        public frmAltaCarrera()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string carrera = txtCarrera.Text.Trim();

            DateTime fechaalta = Convert.ToDateTime(dtpFechaAlta.Value.ToString());

            string fecha = Convert.ToString(fechaalta);


            DataTable dt = bl.validacarrera(carrera);
            if (dt.Rows.Count > 0)
            {
                dtca.DataSource = dt;
                string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());
                
                if(a == carrera)
                {
                    MessageBox.Show("La carrera ya existe");
                }

            }
            else
            {
                bl.AltaCarrera(carrera, fecha);
                
            }
            
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void TxtCarrera_KeyPress(object sender, KeyPressEventArgs e)
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
