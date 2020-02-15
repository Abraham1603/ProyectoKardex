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
    public partial class frmModificaMateria : Form
    {
        BL bl = new BL();
        public frmModificaMateria()
        {
            InitializeComponent();
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void BtnConsultaMateria_Click(object sender, EventArgs e)
        {
            string carrera = txtmodi.Text.ToString();

            string carreranueva = txtcnueva.Text.Trim();

            DateTime fechamodi = Convert.ToDateTime(dtpFechaModi.Value.ToString());
            string fecha = Convert.ToString(fechamodi);


            if (carreranueva != "")
            {

                DataTable dt1 = bl.validamateria(carreranueva);
                if (dt1.Rows.Count > 0)
                {
                    dtma.DataSource = dt1;
                    string a = Convert.ToString(dtma.Rows[0].Cells[0].Value.ToString());

                    if (a == carreranueva)
                    {
                        MessageBox.Show("La materia ya existe, no pueden haber dos iguales");
                        cbTodas.Checked = true;
                    }

                }
                else
                {
                    bl.ActualizaMateria(carrera, carreranueva,fecha );
                    cbTodas.Checked = true;

                }
                

            }
            else
            {

                MessageBox.Show("No ha ingresado ningun valor", "Aviso", MessageBoxButtons.OK);
            }

            DataTable dt = bl.ConsultaMateria("todas");

            if (dt.Rows.Count > 0)
            {
                dgvCarrera.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay materia activas", "Aviso", MessageBoxButtons.OK);
            }

            txtmodi.Clear();
            txtcnueva.Clear();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();

            frm.Show();
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
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaMateria("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay materias activas", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                string materia = txtMateria.Text.ToString();

                if (materia == "")
                {
                    MessageBox.Show("Favor de especificar la materia", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaMateria(materia);
                    if (dt.Rows.Count > 0)
                    {
                        dgvCarrera.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No registros con la materia ingresada", "Aviso", MessageBoxButtons.OK);
                        this.Dispose();
                    }
                }

            }
        }

        private void DgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmodi.Text = dgvCarrera.CurrentRow.Cells[0].Value.ToString();
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

        private void txtcnueva_KeyPress(object sender, KeyPressEventArgs e)
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
