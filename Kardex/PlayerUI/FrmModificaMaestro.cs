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
    public partial class FrmModificaMaestro : Form
    {
        BL bl = new BL();
        public FrmModificaMaestro()
        {
            InitializeComponent();
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                txtmaestro.Enabled = false;
            }
            else
            {
                txtmaestro.Enabled = true;
            }
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            dtgMaestro.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaMaestro("todas");

                if (dt.Rows.Count > 0)
                {
                    dtgMaestro.DataSource = dt;
                    this.dtgMaestro.Columns["Id_Maestro"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay Maestros activas", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String carrera = txtmaestro.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar el Maestro", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaMaestro(carrera);
                    if (dt.Rows.Count > 0)
                    {
                        dtgMaestro.DataSource = dt;
                        this.dtgMaestro.Columns["Id_Maestro"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No registros con el Maestro ingresado", "Aviso", MessageBoxButtons.OK);

                    }
                }

            }
        }

        private void btnConsultaPeriodo_Click(object sender, EventArgs e)
        {
            
            cbTodas.Checked = false;

            string id = txtid.Text;
            string nombre = txtnombre.Text.Trim();
            string direccion = txtdireccion.Text;
            string telefono = txttelefono.Text;
            string pass = txtpass.Text;


            if (nombre != "")
            {


                DataTable dt1 = bl.validamaestro(nombre);
                if (dt1.Rows.Count > 0)
                {
                    dtca.DataSource = dt1;
                    string a = Convert.ToString(dtca.Rows[0].Cells[1].Value.ToString());
                   

                    if (a == nombre)
                    {
                        MessageBox.Show("El Maestro ya existe, no pueden haber dos iguales");
                        cbTodas.Checked = true;
                    }

                }
                else
                {

                    bl.ActualizaMaestro(id, nombre, direccion, telefono, pass);
                    cbTodas.Checked = true;




                }




/*

                bl.ActualizaMaestro(id,nombre, direccion, telefono, pass);
                    cbTodas.Checked = true;
*/
            }
            else
            {

                MessageBox.Show("No ha ingresado ningun nombre", "Aviso", MessageBoxButtons.OK);
            }


            DataTable dt = bl.ConsultaMaestro("todas");

            if (dt.Rows.Count > 0)
            {
                dtgMaestro.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
            }


            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtpass.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();

            frm.Show();
        }

        private void dtgMaestro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtid.Text = dtgMaestro.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dtgMaestro.CurrentRow.Cells[1].Value.ToString();
            txtdireccion.Text = dtgMaestro.CurrentRow.Cells[2].Value.ToString();
            txttelefono.Text = dtgMaestro.CurrentRow.Cells[3].Value.ToString();
            txtpass.Text = dtgMaestro.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
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
