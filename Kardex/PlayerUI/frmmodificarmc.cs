using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kardex.Layers;

namespace PlayerUI
{
    public partial class frmmodificarmc : Form
    {
        BL bl = new BL();
        public frmmodificarmc()
        {
            InitializeComponent();
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                txtrmc.Enabled = false;
            }
            else
            {
                txtrmc.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.Consultarmc("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvrmc.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay tienes materias relacionadas con carreras", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String rmc = txtrmc.Text.ToString();

                if (rmc == "")
                {
                    MessageBox.Show("Favor de ingresar un valor", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.Consultarmc(rmc);
                    if (dt.Rows.Count > 0)
                    {
                        dgvrmc.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No hay registros en la relacion materia - carrrea", "Aviso", MessageBoxButtons.OK);

                    }
                }

            }
        }

        private void frmmodificarmc_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadoca();

            if (dt.Rows.Count > 0)
            {
                dtllenadoca.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 1; i < dt.Rows.Count; i++)
            {
                cbcarreras.Items.Add(dt.Rows[i]["carrera"]);
            }


            DataTable dtma = bl.llenadoma();

            if (dtma.Rows.Count > 0)
            {
                dtllenadoma.DataSource = dtma;
            }
            else
            {
                MessageBox.Show("No hay ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 1; i < dtma.Rows.Count; i++)
            {
                cbmateria.Items.Add(dtma.Rows[i]["materia"]);
            }
        }

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-A80OEIF ; database=TestDB ; integrated security = true");

        public int ab;
        public int bb;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            string materia = txtma.Text;
            string carrera = txtcar.Text;
            string materian = cbmateria.SelectedItem.ToString();
            string carreran = cbcarreras.SelectedItem.ToString();

            string a = "";
            string b = "";


            DataTable dt = bl.relrmcmateria(materia);
            if (dt.Rows.Count > 0)
            {
                dtmateria.DataSource = dt;
                a = Convert.ToString(dtmateria.Rows[0].Cells[0].Value.ToString());
                ab = Convert.ToInt32(a);


            }

            DataTable dt2 = bl.relrmccarrera(carrera);
            if (dt2.Rows.Count > 0)
            {
                dtcarrera.DataSource = dt2;
                a = Convert.ToString(dtcarrera.Rows[0].Cells[0].Value.ToString());
                bb = Convert.ToInt32(a);


            }


            bl.Modificarmc(id, materian, carreran);

            DataTable dt1 = bl.Consultarmc("todas");

            if (dt1.Rows.Count > 0)
            {
                dgvrmc.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("No hay tienes materias relacionadas con carreras", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void dgvrmc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvrmc.CurrentRow.Cells[0].Value.ToString();
            txtma.Text= dgvrmc.CurrentRow.Cells[1].Value.ToString();
            txtcar.Text = dgvrmc.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void txtcar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtrmc_KeyPress(object sender, KeyPressEventArgs e)
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
