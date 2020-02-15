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
   
    public partial class ReactivarMateria : Form
    {
        BL bl = new BL();
        public ReactivarMateria()
        {
            InitializeComponent();
            dgvMateria.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaMateriainactivo("Todas");

                if (dt.Rows.Count > 0)
                {
                    dgvMateria.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay materia activas", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String carrera = txtMateria.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar la materia", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaMateriainactivo(carrera);
                    if (dt.Rows.Count > 0)
                    {
                        dgvMateria.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No registros con la materia ingresada", "Aviso", MessageBoxButtons.OK);

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
                txtMateria.Enabled = false;
            }
            else
            {
                txtMateria.Enabled = true;
            }
        }

        private void dgvMateria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dgvMateria.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres reactivar esta materia?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarMateria(eliminar);
                cbTodas.Checked = true;
                DataTable dt = bl.ConsultaMateriainactivo("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvMateria.DataSource = dt;
                    dgvMateria.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay materias activas", "Aviso", MessageBoxButtons.OK);
                }

            }
        }

        private void txtMateria_KeyPress(object sender, KeyPressEventArgs e)
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
