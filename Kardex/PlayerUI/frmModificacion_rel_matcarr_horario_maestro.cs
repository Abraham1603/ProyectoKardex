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
    public partial class frmModificacion_rel_matcarr_horario_maestro : Form
    {
        public frmModificacion_rel_matcarr_horario_maestro()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void frmModificacion_rel_matcarr_horario_maestro_Load(object sender, EventArgs e)
        {

        }

        private void frmModificacion_rel_matcarr_horario_maestro_Load_1(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadomatcarr_horario();

            if (dt.Rows.Count > 0)
            {
                dtmatcarrMa.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbmatcarrDo.Items.Add(dt.Rows[i]["Materia-Carrera-Grupo"]);
            }





            DataTable dt1 = bl.llenadomaestro();

            if (dt1.Rows.Count > 0)
            {
                dtMaestro.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay Maestro ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbMaestro.Items.Add(dt1.Rows[i]["nombre"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string matcarr = cbmatcarrDo.SelectedItem.ToString();

            string horario2 = cbMaestro.SelectedItem.ToString();




            bl.Actualizarel_matcarr_horario_maestro(id, matcarr, horario2);

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

        private void dgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvCarrera.CurrentRow.Cells[0].Value.ToString();
            cbmatcarrDo.Text = dgvCarrera.CurrentRow.Cells[2].Value.ToString();
            cbMaestro.Text = dgvCarrera.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
