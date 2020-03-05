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
    public partial class frmModificaGrupos : Form
    {
        public frmModificaGrupos()
        {
            InitializeComponent();
        }
        BL bl = new BL();
        
       

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaGrupo("todas");

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
                    DataTable dt = bl.ConsultaGrupo(carrera);
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

        private void dgvCarrera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificarCarrera_Click(object sender, EventArgs e)
        {
            string carrera = txtmodi.Text.ToString();
            cbTodas.Checked = false;
            string carreranueva = txtcnueva.Text.Trim();

            DateTime fechamodi = Convert.ToDateTime(dtpFechaModi.Value.ToString());
            string fecha = Convert.ToString(fechamodi);

            if (carreranueva != "")
            {

                DataTable dt1 = bl.validagrupo(carreranueva);
                if (dt1.Rows.Count > 0)
                {
                    dtca.DataSource = dt1;
                    string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

                    if (a == carreranueva)
                    {
                        MessageBox.Show(" El grupo ya existe, no pueden haber dos iguales");
                        cbTodas.Checked = true;
                    }

                }
                else
                {

                    bl.ActualizaGrupo(carrera, carreranueva, fecha);
                    cbTodas.Checked = true;

                }



            }
            else
            {

                MessageBox.Show("No ha ingresado ningun valor", "Aviso", MessageBoxButtons.OK);
            }


            DataTable dt = bl.ConsultaGrupo("todas");

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

        private void dgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmodi.Text = dgvCarrera.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
