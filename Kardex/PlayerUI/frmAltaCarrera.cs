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
                DataTable dt2 = bl.validacarrerainactivo(carrera);
                if (dt2.Rows.Count > 0)
                {
                    dtca2.DataSource = dt2;
                    string b = Convert.ToString(dtca2.Rows[0].Cells[0].Value.ToString());

                    if (b == carrera)
                    {
                        MessageBox.Show("La carrera ya existe y se encuentra dada de baja");
                    }

                }
                else
                {
                    bl.AltaCarrera(carrera, fecha);
                }
                
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
