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
    public partial class ReactivarCarrera : Form
    {

        BL bl = new BL();
        public ReactivarCarrera()
        {
            InitializeComponent();
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaCarrerainactivo("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String carrera = txtCarrera.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar la carrera", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaCarrerainactivo(carrera);
                    
                    if (dt.Rows.Count > 0)
                    {
                        dgvCarrera.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No registros con la carrera ingresada", "Aviso", MessageBoxButtons.OK);

                    }
                }

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                txtCarrera.Enabled = false;
            }
            else
            {
                txtCarrera.Enabled = true;
            }
        }

        private void dgvCarrera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dgvCarrera.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres reactivar esta carrera?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarCarrera(eliminar);

                DataTable dt = bl.ConsultaCarrerainactivo("todas");
                cbTodas.Checked = true;
                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
                }

            }
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
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
