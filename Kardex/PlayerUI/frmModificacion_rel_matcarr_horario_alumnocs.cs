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
    public partial class frmModificacion_rel_matcarr_horario_alumnocs : Form
    {
        BL bl = new BL();
        public frmModificacion_rel_matcarr_horario_alumnocs()
        {
            InitializeComponent();
        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            DataTable dt = bl.ConsultaRelmatcarr_horario_alumno();

            if (dt.Rows.Count > 0)
            {
                dgvCarrera.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void frmModificacion_rel_matcarr_horario_alumnocs_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadomatcarr_horario();

            if (dt.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbmatcarr.Items.Add(dt.Rows[i]["Materia-Carrera-Grupo"]);
            }

            DataTable dt1 = bl.llenadoalumno();

            if (dt1.Rows.Count > 0)
            {
                dtalumno.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay alumnos ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbalumno.Items.Add(dt1.Rows[i]["nombre"]);
            }






        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbper_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string matcarr = cbmatcarr.SelectedItem.ToString();
         
            string horario2 = cbalumno.SelectedItem.ToString();
           



            bl.Actualizarel_matcarr_horario_alumno(id, matcarr, horario2);

            DataTable dt = bl.ConsultaRelmatcarr_horario_alumno();



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

        private void dgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvCarrera.CurrentRow.Cells[0].Value.ToString();
            cbmatcarr.Text = dgvCarrera.CurrentRow.Cells[2].Value.ToString();
            cbalumno.Text = dgvCarrera.CurrentRow.Cells[1].Value.ToString();
            
        }
    }
}
