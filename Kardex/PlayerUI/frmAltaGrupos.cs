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

            }
            else
            {
                bl.AltaGrupo(carrera, fecha);


            }

            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
