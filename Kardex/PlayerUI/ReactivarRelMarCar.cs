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
    public partial class ReactivarRelMarCar : Form
    {
        BL bl = new BL();
        public ReactivarRelMarCar()
        {
            InitializeComponent();
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

        private void btnconsultarmc_Click(object sender, EventArgs e)
        {
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaRelMatCarinactivo("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                    //this.dgvCarrera.Columns["Id_Maestro"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay Relaciones activas", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String carrera = txtAlumno.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar la relacion", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaRelMatCarinactivo(carrera);

                    if (dt.Rows.Count > 0)
                    {
                        dgvCarrera.DataSource = dt;
                        //this.dgvCarrera.Columns["Id_Alumno"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No registros con la informacion ingresada", "Aviso", MessageBoxButtons.OK);
                        dgvCarrera.DataSource = dt;
                    }
                }

            }
        }

        private void gbConsultaCarrera_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCarrera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dgvCarrera.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres reactivar esta Relacion?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarRelMatCar(eliminar);

                DataTable dt = bl.ConsultaRelMatCarinactivo("todas");
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
