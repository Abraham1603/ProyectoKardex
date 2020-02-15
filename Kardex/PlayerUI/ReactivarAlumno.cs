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
    public partial class ReactivarAlumno : Form
    {
        BL bl = new BL();
        public ReactivarAlumno()
        {
            InitializeComponent();
        }

        private void dgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dgvCarrera.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres reactivar este Alumno?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarAlumno(eliminar);

                DataTable dt = bl.ConsultaAlumnoinactivo("todas");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaAlumnoinactivo("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                    //this.dgvCarrera.Columns["Id_Maestro"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay Alumno activo", "Aviso", MessageBoxButtons.OK);
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
                    DataTable dt = bl.ConsultaAlumnoinactivo(carrera);

                    if (dt.Rows.Count > 0)
                    {
                        dgvCarrera.DataSource = dt;
                        //this.dgvCarrera.Columns["Id_Alumno"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No registros con el Alumno ingresada", "Aviso", MessageBoxButtons.OK);
                        dgvCarrera.DataSource = dt;
                    }
                }

            }
        }

        private void txtAlumno_KeyPress(object sender, KeyPressEventArgs e)
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
