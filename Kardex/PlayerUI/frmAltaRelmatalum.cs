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
    public partial class frmAltaRelmatalum : Form
    {
        BL bl = new BL();
        public frmAltaRelmatalum()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string alumnos = cbalumnos.SelectedItem.ToString();
            string rmc = cbrmc.SelectedItem.ToString();
            string maestro = cbmaestro.SelectedItem.ToString();
            string periodo = cbperiodo.SelectedItem.ToString();


            //  PARA VALIDAR
            //DataTable dt = bl.validacarrera(carrera);
            //if (dt.Rows.Count > 0)
            //{
            //    dtca.DataSource = dt;
            //    string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

            //    if (a == carrera)
            //    {
            //        MessageBox.Show("La carrera ya existe");
            //    }

            //}
            //else
            //{
            bl.Altarelmatalum(alumnos, rmc, maestro, periodo);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void frmAltaRelmatalum_Load(object sender, EventArgs e)
        {
            // llenado alumno
            DataTable dt = bl.llenadoalumno();

            if (dt.Rows.Count > 0)
            {
                dtal.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay relaciones", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbalumnos.Items.Add(dt.Rows[i]["nombre"]);
            }

            // llenado relacion materia carrera
            DataTable dt1 = bl.llenadormc();

            if (dt1.Rows.Count > 0)
            {
                dtrelmc.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("No hay relaciones", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbrmc.Items.Add(dt1.Rows[i]["id_relmatcarr"]);
            }

            // llenado maestro
            DataTable dt2 = bl.llenadomaestro();

            if (dt2.Rows.Count > 0)
            {
                dtma.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("No hay relaciones", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cbmaestro.Items.Add(dt2.Rows[i]["nombre"]);
            }

            // llenado periodo
            DataTable dt3 = bl.llenadoperiodo();

            if (dt3.Rows.Count > 0)
            {
                dtper.DataSource = dt3;
            }
            else
            {
                MessageBox.Show("No hay relaciones", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                cbperiodo.Items.Add(dt3.Rows[i]["periodo"]);
            }
        }
    }
}
