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
    public partial class ReactivarRel_Matcarr_horario_alumno : Form
    {
        BL bl = new BL();
        public ReactivarRel_Matcarr_horario_alumno()
        {
            InitializeComponent();
        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {

        }

        
        





        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
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


            if (MessageBox.Show("Seguro que quieres dar de alta esta relacion?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarRelmatcarr_horario_alumno(eliminar);

                DataTable dt = bl.ConsultaRelmatcarr_horario_alumnoinactivo();

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay periodos activos", "Aviso", MessageBoxButtons.OK);
                }

            }
        }

        private void btnConsultaCarrera_Click_1(object sender, EventArgs e)
        {
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);



            DataTable dt = bl.ConsultaRelmatcarr_horario_alumnoinactivo();

            if (dt.Rows.Count > 0)
            {
                dgvCarrera.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void dgvCarrera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dgvCarrera.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres dar de alta esta relacion?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarRelmatcarr_horario_alumno(eliminar);

                DataTable dt = bl.ConsultaRelmatcarr_horario_alumnoinactivo();

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay periodos activos", "Aviso", MessageBoxButtons.OK);
                }

            }
        }
    }
}
