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
    public partial class frmConsulta_relmatcarr_horario_maestro : Form
    {
        public frmConsulta_relmatcarr_horario_maestro()
        {
            InitializeComponent();
        }

        BL bl = new BL();

        

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            DataTable dt = bl.ConsultaRelmatcarr_horario_Maestro();

            if (dt.Rows.Count > 0)
            {
                dgvCarrera.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay  activas", "Aviso", MessageBoxButtons.OK);
            }

        }

        

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void dgvCarrera_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dgvCarrera.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres dar de baja esta relacion?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.BajaRelmatcarr_horario_maestro(eliminar);

                DataTable dt = bl.ConsultaRelmatcarr_horario_Maestro();

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay activos", "Aviso", MessageBoxButtons.OK);
                }

            }
        }

        private void dgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
