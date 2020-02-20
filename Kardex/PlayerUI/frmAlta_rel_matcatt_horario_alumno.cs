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
    public partial class frmAlta_rel_matcatt_horario_alumno : Form
    {
        BL bl = new BL();

        public frmAlta_rel_matcatt_horario_alumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matcarr = cbmatcarr.SelectedItem.ToString();
            string alumno = cbalumno.SelectedItem.ToString();



          //  DataTable dt = bl.No_debe_permitir_asignar_una_materia_que_ya_está_aprobada(matcarr, alumno);
            //if (dt.Rows.Count > 0)
            //{
            //    dtvalida.DataSource = dt;
            //    string a = Convert.ToString(dtvalida.Rows[0].Cells[1].Value.ToString());
            //    string b = Convert.ToString(dtvalida.Rows[0].Cells[2].Value.ToString());
          


            //    if (a == matcarr)
            //    {
            //        MessageBox.Show("No se debe permitir asignar una materia que ya está aprobada");
            //    }
       
            //}
            //else
            //{
            //    bl.Alta_rel_matcarr_horario_alumno(matcarr, alumno);
            //}


        }

        private void frmAlta_rel_matcatt_horario_alumno_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadomatcarr_horario();

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
                cbmatcarr.Items.Add(dt.Rows[i]["Materia-Carrera-Grupo"]);
            }

            DataTable dt1 = bl.llenadoalumno();

            if (dt1.Rows.Count > 0)
            {
                dtalumno.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay alumnos ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbalumno.Items.Add(dt1.Rows[i]["nombre"]);
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
