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
    public partial class frmAlta_rel_matcarr_horario : Form
    {
        BL bl = new BL();

        public frmAlta_rel_matcarr_horario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAlta_rel_matcarr_horario_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadomatcar();

            if (dt.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbmatcarr.Items.Add(dt.Rows[i]["Materia-Carrera"]);
            }

            DataTable dt1 = bl.llenadoperiodo();

            if (dt1.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbper.Items.Add(dt1.Rows[i]["periodo"]);
            }

            DataTable dt2 = bl.llenadogrupo();

            if (dt2.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cbgrupo.Items.Add(dt2.Rows[i]["grupo"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string matcarr = cbmatcarr.SelectedItem.ToString();
            string horario = cbhorario.SelectedItem.ToString();
            string dia1 = cbdia1.SelectedItem.ToString();
            string dia2 = cbdia2.SelectedItem.ToString();
            string periodo = cbper.SelectedItem.ToString();
            string grupo = cbgrupo.SelectedItem.ToString();


            DataTable dt = bl.validadosmateriashorario(matcarr,horario,dia1,dia2,periodo,grupo);
            if (dt.Rows.Count > 0)
            {
                dtvalidamateriahorario.DataSource = dt;
                string a = Convert.ToString(dtvalidamateriahorario.Rows[0].Cells[0].Value.ToString());

                if (a == matcarr)
                {
                    MessageBox.Show("La carrera ya existe");
                }

            }
            //else
            //{
            //    bl.Alta_rel_matcarr_horario(matcarr, horario,dia1,dia2,periodo,grupo);

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
