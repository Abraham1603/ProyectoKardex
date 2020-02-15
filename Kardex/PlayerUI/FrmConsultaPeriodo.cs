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
    public partial class FrmConsultaPeriodo : Form
    {
        BL bl = new BL();
        public FrmConsultaPeriodo()
        {
            InitializeComponent();
        }

        private void btnConsultaPeriodo_Click(object sender, EventArgs e)
        {

            dtaPeriodo.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaPeriodo("todas");

                if (dt.Rows.Count > 0)
                {
                    dtaPeriodo.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay Periodos activas", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String carrera = txtPeriodo.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar el Periodo", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaPeriodo(carrera);
                    if (dt.Rows.Count > 0)
                    {
                        dtaPeriodo.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No registros con el periodo ingresado", "Aviso", MessageBoxButtons.OK);

                    }
                }

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                txtPeriodo.Enabled = false;
            }
            else
            {
                txtPeriodo.Enabled = true;
            }
        }

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dtaPeriodo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dtaPeriodo.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres dar de baja este periodo?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.BajaPeriodo(eliminar);

                DataTable dt = bl.ConsultaPeriodo("todas");
                cbTodas.Checked = true;
                if (dt.Rows.Count > 0)
                {
                    dtaPeriodo.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay periodos activos", "Aviso", MessageBoxButtons.OK);
                }

            }
        }

        private void gbConsultaPeriodo_Enter(object sender, EventArgs e)
        {

        }
    }
}
