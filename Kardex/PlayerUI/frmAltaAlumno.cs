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
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace PlayerUI
{
    public partial class frmAltaAlumno : Form
    {

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-A80OEIF; database=Kardex ; integrated security = true");
        BL bl = new BL();
        public frmAltaAlumno()
        {
            InitializeComponent();
            
        }

        private void frmAltaAlumno_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadoca();

            if (dt.Rows.Count > 0)
            {
                dtllenadoca.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbcarrera.Items.Add(dt.Rows[i]["carrera"]);
            }

            DataTable dt2 = bl.llenadogrupo();

            if (dt2.Rows.Count > 0)
            {
                dtgrupo.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("No  hay grupos ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cbgrupo.Items.Add(dt2.Rows[i]["grupo"]);
            }

            DataTable dt3 = bl.llenadocampus();

            if (dt3.Rows.Count > 0)
            {
                dtcampus.DataSource = dt3;
            }
            else
            {
                MessageBox.Show("No  hay campus ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                cbcampus.Items.Add(dt3.Rows[i]["campus"]);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string direccion = txtdireccion.Text.ToString();
            string telefono = txttelefono.Text.ToString();
            DateTime fechaalta = Convert.ToDateTime(dtpfechanac.Value.ToString());
            string fe = Convert.ToString(fechaalta);
            string carrera = cbcarrera.SelectedItem.ToString();
            string campus = cbcampus.SelectedItem.ToString();
            string grupo = cbgrupo.SelectedItem.ToString();

            string fecha = Convert.ToString(fechaalta);
            

             DataTable dt = bl.validaalumno(nombre);
             if (dt.Rows.Count > 0)
             {
                 dtca.DataSource = dt;
                 string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

                 if (a == nombre)
                 {
                     MessageBox.Show("El Alumno ya existe");
                 }
                 MessageBox.Show("El Alumno ya existe");
             }
             else
             {


                DataTable dt2 = bl.validaalumnoinactivo2(nombre);
                if (dt2.Rows.Count > 0)
                {
                    dtca2.DataSource = dt2;
                    string b = Convert.ToString(dtca2.Rows[0].Cells[0].Value.ToString());

                    if (b == carrera)
                    {
                        MessageBox.Show("El alumno ya existe y se encuentra dada de baja");
                    }

                      MessageBox.Show("El alumno ya existe y se encuentra dada de baja");

                }
                else
                {
                    bl.AltaAlumno(nombre, direccion, telefono, fecha, carrera, campus, grupo);
                }



            }
            
          //  bl.AltaAlumno(nombre, direccion, telefono, fe, carrera, user,pass);

            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

       

        private void gbAltaAlumno_Enter(object sender, EventArgs e)
        {

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

        private void cbcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
