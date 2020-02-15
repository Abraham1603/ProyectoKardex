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
    public partial class frmconsultacalificaciones : Form
    {
        BL bl = new BL();

        public frmconsultacalificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void frmconsultacalificaciones_Load(object sender, EventArgs e)
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
    }
}
