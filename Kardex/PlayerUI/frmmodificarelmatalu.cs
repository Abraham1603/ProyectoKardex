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
    public partial class frmmodificarelmatalu : Form
    {
        BL bl = new BL();
        public frmmodificarelmatalu()
        {
            InitializeComponent();
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                txtrma.Enabled = false;
            }
            else
            {
                txtrma.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.Consultarma("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvrma.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay tienes materias relacionadas con carreras", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String rma = txtrma.Text.ToString();

                if (rma == "")
                {
                    MessageBox.Show("Favor de ingresar un valor", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.Consultarma(rma);
                    if (dt.Rows.Count > 0)
                    {
                        dgvrma.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No hay registros en la relacion materia - carrrea", "Aviso", MessageBoxButtons.OK);

                    }
                }

            }
        }

        private void dgvrma_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvrma.CurrentRow.Cells[0].Value.ToString();
            txtalu.Text = dgvrma.CurrentRow.Cells[1].Value.ToString();
            txtidrmc.Text = dgvrma.CurrentRow.Cells[2].Value.ToString();
            txtma.Text = dgvrma.CurrentRow.Cells[3].Value.ToString();
            txtpe.Text = dgvrma.CurrentRow.Cells[4].Value.ToString();


            cbalumnos.Text = dgvrma.CurrentRow.Cells[1].Value.ToString();
            cbrmc.Text = dgvrma.CurrentRow.Cells[2].Value.ToString();
            cbmaestro.Text = dgvrma.CurrentRow.Cells[3].Value.ToString();
            cbperiodo.Text = dgvrma.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            string alumno = txtalu.Text;
            string idrmc = txtidrmc.Text;
            string maestro = txtma.Text;
            string periodo = txtpe.Text;


            string alumnon = cbalumnos.SelectedItem.ToString();
            string idrmcn = cbrmc.SelectedItem.ToString();
            string maestron = cbmaestro.SelectedItem.ToString();
            string periodon = cbperiodo.SelectedItem.ToString();

            bl.Modificarma(id, alumno, idrmc, maestro, periodo, alumnon, idrmcn, maestron, periodon);

            DataTable dt = bl.Consultarma("todas");

            if (dt.Rows.Count > 0)
            {
                dgvrma.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay tienes materias relacionadas con carreras", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void frmmodificarelmatalu_Load(object sender, EventArgs e)
        {
            // llenado alumno
            DataTable dt = bl.llenadoalumno();

            if (dt.Rows.Count > 0)
            {
                dtal.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbalumnos.Items.Add(dt.Rows[i]["nombre"]);
            }

            // llenado relacion materia carrera
            DataTable dt1 = bl.llenadormc();

            if (dt1.Rows.Count > 0)
            {
                dtrelmc.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("No hay ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbrmc.Items.Add(dt1.Rows[i]["id_relmatcarr"]);
            }

            // llenado maestro
            DataTable dt2 = bl.llenadomaestro();

            if (dt2.Rows.Count > 0)
            {
                dtma.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("No hay ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cbmaestro.Items.Add(dt2.Rows[i]["nombre"]);
            }

            // llenado periodo
            DataTable dt3 = bl.llenadoperiodo();

            if (dt3.Rows.Count > 0)
            {
                dtper.DataSource = dt3;
            }
            else
            {
                MessageBox.Show("No hay ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                cbperiodo.Items.Add(dt3.Rows[i]["periodo"]);
            }
        }

        private void txtrma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
