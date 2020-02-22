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
    public partial class frmModificacion_rel_matcarr_horario : Form
    {
        BL bl = new BL();
        public frmModificacion_rel_matcarr_horario()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmModificacion_rel_matcarr_horario_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadomatcar();

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
                cbmatcarr.Items.Add(dt.Rows[i]["Materia-Carrera"]);
            }

            DataTable dt1 = bl.llenadoperiodo();

            if (dt1.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbper.Items.Add(dt1.Rows[i]["periodo"]);
            }

            DataTable dt2 = bl.llenadogrupo();

            if (dt2.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cbgrupo.Items.Add(dt2.Rows[i]["grupo"]);
            }


            DataTable dt3 = bl.llenadohorario();

            if (dt3.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt3;
            }
            else
            {
                MessageBox.Show("No hay horarios ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                cbhorario.Items.Add(dt3.Rows[i]["horario"]);
            }

            DataTable dt4 = bl.llenadohorario();

            if (dt4.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt4;
            }
            else
            {
                MessageBox.Show("No hay horarios ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                cbhorario2.Items.Add(dt4.Rows[i]["horario"]);
            }
        }

        private void dgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvCarrera.CurrentRow.Cells[0].Value.ToString();
            cbmatcarr.Text = dgvCarrera.CurrentRow.Cells[1].Value.ToString();
            cbhorario.Text = dgvCarrera.CurrentRow.Cells[2].Value.ToString();
            cbhorario2.Text = dgvCarrera.CurrentRow.Cells[3].Value.ToString();
            cbper.Text = dgvCarrera.CurrentRow.Cells[4].Value.ToString();
            cbgrupo.Text = dgvCarrera.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string matcarr = cbmatcarr.SelectedItem.ToString();
            string horario = cbhorario.SelectedItem.ToString();
            string horario2 = cbhorario2.SelectedItem.ToString();
            string periodo = cbper.SelectedItem.ToString();
            string grupo = cbgrupo.SelectedItem.ToString();



            bl.Actualizarel_matcarr_horario(id, matcarr, horario, horario2, periodo, grupo);

            DataTable dt = bl.ConsultaRelmatcarr_horario();

            

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
    }
}
