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
    public partial class frmAltaGrupos : Form
    {
        BL bl = new BL();
        public frmAltaGrupos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string carrera = txtCarrera.Text.Trim();

            DateTime fechaalta = Convert.ToDateTime(dtpFechaAlta.Value.ToString());

            string fecha = Convert.ToString(fechaalta);


            DataTable dt = bl.validagrupo(carrera);
            if (dt.Rows.Count > 0)
            {
                dtca.DataSource = dt;
                string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

                if (a == carrera)
                {
                    MessageBox.Show("El grupo ya existe");
                }
                MessageBox.Show("El grupo ya existe");
            }
            else
            {


                DataTable dt2 = bl.validagrupoinactivo(carrera);
                if (dt2.Rows.Count > 0)
                {
                    dtca2.DataSource = dt2;
                    string b = Convert.ToString(dtca2.Rows[0].Cells[0].Value.ToString());

                    if (b == carrera)
                    {
                        MessageBox.Show("El grupo ya existe y se encuentra dada de baja");
                    }
                    MessageBox.Show("El grupo ya existe y se encuentra dada de baja");

                }
                else
                {
                    bl.AltaGrupo(carrera, fecha);
                }
                


            }

            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
