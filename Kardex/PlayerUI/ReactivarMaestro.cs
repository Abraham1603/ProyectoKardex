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
    public partial class ReactivarMaestro : Form
    {
        BL bl = new BL();
        public ReactivarMaestro()
        {
            InitializeComponent();
            
        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaMaestroinactivo("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                    this.dgvCarrera.Columns["Id_Maestro"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay maestro activo", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String carrera = txtCarrera.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar el Maestro", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaMaestroinactivo(carrera);

                    if (dt.Rows.Count > 0)
                    {
                        dgvCarrera.DataSource = dt;
                      this.dgvCarrera.Columns["Id_Maestro"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No registros con el Maestro ingresada", "Aviso", MessageBoxButtons.OK);
                        dgvCarrera.DataSource = dt;
                    }
                }

            }
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

        private void dgvCarrera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dgvCarrera.CurrentRow.Cells[1].Value.ToString();


            if (MessageBox.Show("Seguro que quieres reactivar este Maestro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarMaestro(eliminar);

                DataTable dt = bl.ConsultaMaestroinactivo("todas");
                cbTodas.Checked = true;
                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    // MessageBox.Show("No hay maestros activos", "Aviso", MessageBoxButtons.OK);


                    dgvCarrera.DataSource = dt;

                }

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
