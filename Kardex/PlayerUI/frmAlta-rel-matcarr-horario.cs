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


            DataTable dt3 = bl.llenadohorario();

            if (dt3.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt3;
            }
            else
            {
                MessageBox.Show("No hay horarios ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                cbhorario.Items.Add(dt3.Rows[i]["horario"]);
            }

            DataTable dt4 = bl.llenadohorario();

            if (dt4.Rows.Count > 0)
            {
                dtmatcarr.DataSource = dt4;
            }
            else
            {
                MessageBox.Show("No hay horarios ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                cbhorario2.Items.Add(dt4.Rows[i]["horario"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string matcarr = cbmatcarr.SelectedItem.ToString();
            string horario = cbhorario.SelectedItem.ToString();
            string horario2 = cbhorario2.SelectedItem.ToString();
            string periodo = cbper.SelectedItem.ToString();
            string grupo = cbgrupo.SelectedItem.ToString();


            DataTable dt = bl.No_puede_tener_dos_materias_en_el_mismo_horario(matcarr, periodo, grupo);
            if (dt.Rows.Count > 0)
            {
                dtvalidamateriahorario.DataSource = dt;
                string a = Convert.ToString(dtvalidamateriahorario.Rows[0].Cells[1].Value.ToString());
                string a2 = Convert.ToString(dtvalidamateriahorario.Rows[0].Cells[2].Value.ToString());
                string b = Convert.ToString(dtvalidamateriahorario.Rows[0].Cells[3].Value.ToString());
                string c = Convert.ToString(dtvalidamateriahorario.Rows[0].Cells[4].Value.ToString());

                int c1;
                int c2;

                if (a == horario || a2 == horario2)
                {
                    MessageBox.Show("No puede haber dos materias en el mismo horario");

                }
                else if (b == periodo)
                {
                    MessageBox.Show("No puede tener dos veces una materia en el mismo periodo");

                }

            }
            else
            {
                bl.Alta_rel_matcarr_horario(matcarr, horario, horario2, periodo, grupo);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
