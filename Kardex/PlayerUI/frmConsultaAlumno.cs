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
    public partial class frmConsultaAlumno : Form
    {

        BL bl = new BL();
        public frmConsultaAlumno()
        {
            InitializeComponent();
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

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaAlumno("Todas");

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay Alumnos activos ", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String carrera = txtAlumno.Text.ToString();
               

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar el Alumno o Carrera", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaAlumno(carrera);
                    if (dt.Rows.Count > 0)
                    {
                        dgvCarrera.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No registros con el Alumno o  carrera ingresado", "Aviso", MessageBoxButtons.OK);

                    }
                }

            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                txtAlumno.Enabled = false;
             //   txtcarrera.Enabled = false;
            }
            else
            {
                txtAlumno.Enabled = true;
              //  txtcarrera.Enabled = true;
            }
        }

        private void gbConsultaCarrera_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dgvCarrera.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("Seguro que quieres dar de baja este alumno?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.BajaAlumno(eliminar);
                cbTodas.Checked = true;

                DataTable dt = bl.ConsultaAlumno("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay alumnos activos", "Aviso", MessageBoxButtons.OK);
                }


            }
        }
    }
}
