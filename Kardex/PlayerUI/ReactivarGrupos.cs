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
    public partial class ReactivarGrupos : Form
    {
        public ReactivarGrupos()
        {
            InitializeComponent();
        }

        BL bl = new BL();
       

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
                txtCarrera.Enabled = false;
            }
            else
            {
                txtCarrera.Enabled = true;
            }
        }

        private void btnConsultaCarrera_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaGruposinactivo("todas");

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
                String carrera = txtCarrera.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar la carrera", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaGruposinactivo(carrera);

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
            string eliminar = dgvCarrera.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Seguro que quieres reactivar esta carrera?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bl.ReactivarGrupo(eliminar);

                DataTable dt = bl.ConsultaGruposinactivo("todas");
                cbTodas.Checked = true;
                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
                }

            }
        }

    }
}
