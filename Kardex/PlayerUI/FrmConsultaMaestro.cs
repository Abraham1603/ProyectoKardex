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
    public partial class FrmConsultaMaestro : Form
    {
        BL bl = new BL();
        public FrmConsultaMaestro()
        {
            InitializeComponent();
        }

        private void btnConsultaPeriodo_Click(object sender, EventArgs e)
        {
            
            dtaMaestro.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaMaestro("todas");

                if (dt.Rows.Count > 0)
                {
                    dtaMaestro.DataSource = dt;
                    this.dtaMaestro.Columns["Id_Maestro"].Visible = false;

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
                        dtaMaestro.DataSource = dt;
                        this.dtaMaestro.Columns["Id_Maestro"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No registros con el Maestro ingresado", "Aviso", MessageBoxButtons.OK);

                    }
                }

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
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

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtaMaestro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string eliminar = dtaMaestro.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("Seguro que quieres dar de baja este Maestro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.BajaMaestro(eliminar);
                cbTodas.Checked = true;

                DataTable dt = bl.ConsultaMaestro("todas");

                if (dt.Rows.Count > 0)
                {
                    dtaMaestro.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay maestros activos", "Aviso", MessageBoxButtons.OK);
                }


            }
        }

        private void gbConsultaMaestro_Enter(object sender, EventArgs e)
        {

        }
    }
}
