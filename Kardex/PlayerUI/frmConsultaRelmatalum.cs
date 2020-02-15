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
    public partial class frmConsultaRelmatalum : Form
    {
        BL bl = new BL();
        public frmConsultaRelmatalum()
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

        private void dgvrma_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int eliminar = Convert.ToInt32(dgvrma.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("Seguro que quieres dar de baja esta relacion ?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.Bajarma(eliminar);
                
                DataTable dt = bl.Consultarma("todas");
                cbTodas.Checked = true;
                if (dt.Rows.Count > 0)
                {
                    dgvrma.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
                }
            }
    }

        private void btnconsultarmc_Click(object sender, EventArgs e)
        {
            dgvrma.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
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
