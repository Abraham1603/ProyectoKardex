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
    public partial class ReactivarMatAlum : Form
    {
        BL bl = new BL();
        public ReactivarMatAlum()
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
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnconsultarmc_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.Consultarmainactivo("todas");

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
                    DataTable dt = bl.Consultarmainactivo(rma);
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
            string eliminar = dgvrma.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres reactivar esta Relacion?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarRelmatalum(eliminar);

                DataTable dt = bl.Consultarmainactivo("todas");
                cbTodas.Checked = true;
                if (dt.Rows.Count > 0)
                {
                    dgvrma.DataSource = dt;
                }
                else
                {
                    // MessageBox.Show("No hay maestros activos", "Aviso", MessageBoxButtons.OK);


                    dgvrma.DataSource = dt;

                }

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
