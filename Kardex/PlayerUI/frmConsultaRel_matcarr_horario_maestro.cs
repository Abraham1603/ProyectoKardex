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
    public partial class frmConsultaRel_matcarr_horario_maestro : Form
    {
        public frmConsultaRel_matcarr_horario_maestro()
        {
            InitializeComponent();
        }

        BL bl = new BL();
        

        private void BtnConsultaMaestro_Click(object sender, EventArgs e)
        {
            dgvCarreraMaestro.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            DataTable dt = bl.ConsultaRelmatcarr_horario_Maestro();

            if (dt.Rows.Count > 0)
            {
                dgvCarreraMaestro.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
}
