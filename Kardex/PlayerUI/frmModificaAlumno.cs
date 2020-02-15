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
    public partial class frmModificaAlumno : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-IH0ESEJ\\SQLEXPRESS ; database=Kardex ; integrated security = true");

        BL bl = new BL();
        public frmModificaAlumno()
        {
            InitializeComponent();
           // EstablecerComboBox2();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            dtgAlumno.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaAlumno("Todas");

                if (dt.Rows.Count > 0)
                {
                    dtgAlumno.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay Alumnos activos", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String carrera = txtAlumno.Text.ToString();
               // String nombre = txtcar.Text.ToString();

                if (carrera == "")
                {
                    MessageBox.Show("Favor de especificar el Alumno", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaAlumno(carrera);
                    if (dt.Rows.Count > 0)
                    {
                        dtgAlumno.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No registros con el Alumno ingresado", "Aviso", MessageBoxButtons.OK);

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
                txtAlumno.Enabled = false;
               // txtcar.Enabled = false;
            }
            else
            {
                txtAlumno.Enabled = true;
                //txtcar.Enabled = true;
            }
        }
        /*
        private void btnModificarAlumno_Click(object sender, EventArgs e)
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




                

                      --          bl.ActualizaMaestro(id,nombre, direccion, telefono, pass);
                        --            cbTodas.Checked = true;
                
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
                MessageBox.Show("No hay Alumnos activas", "Aviso", MessageBoxButtons.OK);
            }


            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtpass.Clear();





        }

    */


        private void dtgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dtgAlumno.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgAlumno.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dtgAlumno.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dtgAlumno.CurrentRow.Cells[3].Value.ToString();
            dtpFechaNac.Text = dtgAlumno.CurrentRow.Cells[4].Value.ToString();
            cbCarrrera.Text = dtgAlumno.CurrentRow.Cells[5].Value.ToString();
            txtpass.Text = dtgAlumno.CurrentRow.Cells[6].Value.ToString();
            //EstablecerComboBox2();
        }

/*
        public void EstablecerComboBox2()
        {

            cbCarrrera.Items.Clear();

            conexion.Open();

            //cbPuestoParameters.Items.Add("Hola");
            string query = "SELECT [carrera] FROM [carrera] WHERE [activo] = 1";
            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cbCarrrera.Items.Add(reader["carrera"].ToString());


            }

            conexion.Close();
        }*/

        private void gbAlumnos_Enter(object sender, EventArgs e)
        {

        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            cbTodas.Checked = false;

            int id = Convert.ToInt32( txtid.Text);
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string pass = txtpass.Text;
            string carrera = cbCarrrera.SelectedItem.ToString();
            DateTime fecha = dtpFechaNac.Value;
            string fe = Convert.ToString(fecha);


            if (nombre != "")
            {


                DataTable dt1 = bl.validaalumno(nombre);
                if (dt1.Rows.Count > 0)
                {
                    dtca.DataSource = dt1;
                    string a = Convert.ToString(dtca.Rows[0].Cells[1].Value.ToString());


                    if (a == nombre)
                    {
                        MessageBox.Show("El Alumno ya existe, no pueden haber dos iguales");
                        cbTodas.Checked = true;
                    }

                }
                else
                {

                    bl.ActualizaAlumno(id, nombre, direccion, carrera , telefono, pass, fe);
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
                dtgAlumno.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay carreras activas", "Aviso", MessageBoxButtons.OK);
            }


            txtNombre.Clear();
            txtAlumno.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtpass.Clear();

            DataTable dt2 = bl.ConsultaAlumno("Todas");

            if (dt2.Rows.Count > 0)
            {
                dtgAlumno.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("No hay Alumnos activos", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void frmModificaAlumno_Load(object sender, EventArgs e)
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
                cbCarrrera.Items.Add(dt.Rows[i]["carrera"]);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
