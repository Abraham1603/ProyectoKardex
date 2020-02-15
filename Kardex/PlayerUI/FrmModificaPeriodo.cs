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
    public partial class FrmModificaPeriodo : Form
    {
        BL bl = new BL();
        public FrmModificaPeriodo()
        {
            InitializeComponent();
            dgvPeriodo.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
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

        

        

        private void btnConsultaPeriodo_Click(object sender, EventArgs e)
        {
            string carrera = txtmodi.Text.ToString();
            cbTodas.Checked = false;
            string carreranueva = txtcnueva.Text.Trim();

            DateTime fechamodi = Convert.ToDateTime(dtpFechaModi.Value.ToString());
            string fecha = Convert.ToString(fechamodi);

            if (carreranueva != "")
            {

                DataTable dt1 = bl.validaperiodo(carreranueva);
                if (dt1.Rows.Count > 0)
                {
                    dtca.DataSource = dt1;
                    string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

                    if (a == carreranueva)
                    {
                        MessageBox.Show("El periodo ya existe, no pueden haber dos iguales");
                        cbTodas.Checked = true;
                    }

                }
                else
                {

                    bl.ActualizaPeriodo(carrera, carreranueva,fecha);
                    cbTodas.Checked = true;





                }



            }
            else
            {

                MessageBox.Show("No ha ingresado ningun valor", "Aviso", MessageBoxButtons.OK);
            }


            DataTable dt = bl.ConsultaPeriodo("todas");

            if (dt.Rows.Count > 0)
            {
                dgvPeriodo.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay Periodo activos", "Aviso", MessageBoxButtons.OK);
            }

            txtmodi.Clear();
            txtcnueva.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();

            frm.Show();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaPeriodo("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvPeriodo.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay Periodos activas", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                string carrera = txtPeriodo.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar el Periodo", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaPeriodo(carrera);
                    if (dt.Rows.Count > 0)
                    {
                        dgvPeriodo.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No registros con el Periodo ingresada", "Aviso", MessageBoxButtons.OK);

                    }
                }

            }
        }

        private void dtgPeriodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmodi.Text = dgvPeriodo.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcnueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void gbPeriodo_Enter(object sender, EventArgs e)
        {

        }

        private void txtcnueva_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
