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
    public partial class frmrelmatcarr : Form
    {
        BL bl = new BL();
        public frmrelmatcarr()
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

        private void btnconsultarmc_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void dgvrmc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvCarrera.CurrentRow.Cells[0].Value.ToString();
            int eliminar = Convert.ToInt32(dgvrmc.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("Seguro que quieres dar de baja esta relacion ?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.Bajarmc(eliminar);

                DataTable dt = bl.Consultarmc("todas");
                cbTodas.Checked = true;
                if (dt.Rows.Count > 0)
                {
                    dgvrmc.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
                }

            }
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
