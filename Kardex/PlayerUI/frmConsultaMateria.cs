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
    public partial class frmConsultaMateria : Form
    {
        BL bl = new BL();
        public frmConsultaMateria()
        {
            InitializeComponent();
        }

        private void BtnConsultaCarrera_Click(object sender, EventArgs e)
        {

            dgvMateria.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaMateria("Todas");

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
                    DataTable dt = bl.ConsultaMateria(carrera);
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

        private void CbTodas_CheckedChanged(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void DgvCarrera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string eliminar = dgvMateria.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("Seguro que quieres dar de baja esta materia?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.BajaMateria(eliminar);
                cbTodas.Checked = true;

                DataTable dt = bl.ConsultaMateria("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvMateria.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay materias activas", "Aviso", MessageBoxButtons.OK);
                }


            }
        }

        private void DgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void gbConsultaCarrera_Enter(object sender, EventArgs e)
        {

        }
    }
}
