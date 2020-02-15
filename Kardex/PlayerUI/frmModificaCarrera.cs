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
    public partial class frmModificaCarrera : Form
    {
        BL bl = new BL();
        public frmModificaCarrera()
        {
            InitializeComponent();
            dgvCarrera.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
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
                txtCarrera.Enabled = false;
            }
            else
            {
                txtCarrera.Enabled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaCarrera("todas");

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
                string carrera = txtCarrera.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar la carrera", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaCarrera(carrera);
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

        private void BtnModificarCarrera_Click(object sender, EventArgs e)
        {

            string carrera = txtmodi.Text.ToString();
            cbTodas.Checked = false;
            string carreranueva = txtcnueva.Text.Trim();

            DateTime fechamodi = Convert.ToDateTime(dtpFechaModi.Value.ToString());
            string fecha = Convert.ToString(fechamodi);

            if ( carreranueva != "")
            {

                DataTable dt1 = bl.validacarrera(carreranueva);
                if (dt1.Rows.Count > 0)
                {
                    dtca.DataSource = dt1;
                    string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

                    if (a == carreranueva)
                    {
                        MessageBox.Show("La carrera ya existe, no pueden haber dos iguales");
                        cbTodas.Checked = true;
                    }

                }
                else
                {
                    
                    bl.ActualizaCarrera(carrera, carreranueva, fecha);
                    cbTodas.Checked = true;


                   


                }



            }
            else
            {

                MessageBox.Show("No ha ingresado ningun valor", "Aviso", MessageBoxButtons.OK);
            }

            
            DataTable dt = bl.ConsultaCarrera("todas");

            if (dt.Rows.Count > 0)
            {
                dgvCarrera.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
            }

            txtmodi.Clear();
            txtcnueva.Clear();
        }

        private void DgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmodi.Text = dgvCarrera.CurrentRow.Cells[0].Value.ToString();
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

        private void gbCarrera_Enter(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
