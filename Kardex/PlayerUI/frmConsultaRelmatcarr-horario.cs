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
    public partial class frmConsultaRelmatcarr_horario : Form
    {
        BL bl = new BL();

        public frmConsultaRelmatcarr_horario()
        {
            InitializeComponent();
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);


        
                DataTable dt = bl.ConsultaRelmatcarr_horario();

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
                }
            
        }
    }
}
