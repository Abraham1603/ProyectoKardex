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
using Microsoft.VisualBasic;


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

            string user = Interaction.InputBox("Ingresar Usuario Admin", "User", "User", 600, 600);
            string pass = Interaction.InputBox("Ingresar Contraseña", "User", "User", 600, 600);

            DataTable dt4 = bl.validaadmin(user, pass);

            if (dt4.Rows.Count > 0)
            {
                dtcaadmin.DataSource = dt4;
                string userb = Convert.ToString(dtcaadmin.Rows[0].Cells[0].Value.ToString());
                string passb = Convert.ToString(dtcaadmin.Rows[0].Cells[1].Value.ToString());


                if (userb == user && passb == pass)
                {
                    MessageBox.Show("LOGIN EXITOSO");


                    DataTable dt5 = bl.alumno_solo_puede_tener_un_grupo(alumno);

                    if (dt5.Rows.Count > 0)
                    {
                        dtcgrupo.DataSource = dt5;
                        string x1 = Convert.ToString(dtcgrupo.Rows[0].Cells[1].Value.ToString());
                        string x2 = Convert.ToString(dtcgrupo.Rows[0].Cells[2].Value.ToString());


                      //  MessageBox.Show("EXITO " + x1 + x2);


                        DataTable dt6 = bl.alumno_solo_puede_tener_un_grupo2(matcarr);

                        if (dt6.Rows.Count > 0)
                        {
                            dtcgrupo2.DataSource = dt6;
                            string b1 = Convert.ToString(dtcgrupo2.Rows[0].Cells[1].Value.ToString());
                           // string b2 = Convert.ToString(dtcgrupo2.Rows[0].Cells[2].Value.ToString());


                           if(x2 == b1)
                            {


                                DataTable dt = bl.No_debe_permitir_asignar_una_materia_que_ya_esta_aprobada(matcarr, alumno);
                                if (dt.Rows.Count > 0)
                                {
                                    dtvalida2.DataSource = dt;
                                    string a = Convert.ToString(dtvalida2.Rows[0].Cells[2].Value.ToString());
                                    string b = Convert.ToString(dtvalida2.Rows[0].Cells[1].Value.ToString());

                                    float val = float.Parse(a);

                                    if (val > 7)
                                    {
                                        MessageBox.Show("No debe permitir asignar una materia que ya está aprobada");
                                    }
                                    else
                                    {


                                        DataTable dt3 = bl.validahorarioalumno(alumno, matcarr);
                                        if (dt3.Rows.Count > 0)
                                        {
                                            dtca.DataSource = dt3;
                                            string a1 = Convert.ToString(dtca.Rows[0].Cells[2].Value.ToString());
                                            string a2 = Convert.ToString(dtca.Rows[0].Cells[1].Value.ToString());

                                            if (a1 == matcarr && a2 == alumno)
                                            {
                                                MessageBox.Show("La relacion ya existe");
                                            }
                                        }

                                        else
                                        {

                                            DataTable dt2 = bl.validarelacionhorarioalumnoinactivo(alumno, matcarr);
                                            if (dt2.Rows.Count > 0)
                                            {
                                                dtca2.DataSource = dt2;
                                                string F1 = Convert.ToString(dtca2.Rows[0].Cells[2].Value.ToString());
                                                string F2 = Convert.ToString(dtca2.Rows[0].Cells[1].Value.ToString());

                                                if (F1 == matcarr && F2 == alumno)
                                                {
                                                    MessageBox.Show("La relacion ya existe y se encuentra dada de baja");

                                                }
                                                //MessageBox.Show("La relacion ya existe y se encuentra dada de baja");
                                            }
                                            else
                                            {
                                                bl.Alta_rel_matcarr_horario_Maestro(matcarr, alumno);
                                            }
                                        }
                                    }
                                }
                                else
                                {

                                    DataTable dt3 = bl.validahorarioalumno(alumno, matcarr);
                                    if (dt3.Rows.Count > 0)
                                    {
                                        dtca.DataSource = dt3;
                                        string a1 = Convert.ToString(dtca.Rows[0].Cells[2].Value.ToString());
                                        string a2 = Convert.ToString(dtca.Rows[0].Cells[1].Value.ToString());

                                        if (a1 == matcarr && a2 == alumno)
                                        {
                                            MessageBox.Show("La relacion ya existe");
                                        }





                                    }
                                    else
                                    {

                                        DataTable dt2 = bl.validarelacionhorarioalumnoinactivo(alumno, matcarr);
                                        if (dt2.Rows.Count > 0)
                                        {
                                            dtca2.DataSource = dt2;
                                            string E1 = Convert.ToString(dtca2.Rows[0].Cells[2].Value.ToString());
                                            string E2 = Convert.ToString(dtca2.Rows[0].Cells[1].Value.ToString());

                                            if (E1 == matcarr && E2 == alumno)
                                            {
                                                MessageBox.Show("La relacion ya existe y se encuentra dada de baja");

                                            }
                                            //MessageBox.Show("La relacion ya existe y se encuentra dada de baja");
                                        }
                                        else
                                        {
                                            bl.Alta_rel_matcarr_horario_alumno(matcarr, alumno);
                                        }


                                    }

                                    Form1 f1 = new Form1();
                                    f1.Show();
                                    this.Hide();
                                }


                            }
                            else
                            {
                                MessageBox.Show("ERROR!!!!    El Alumno " +x1 +"pertenece al grupo " + x2);
                            }

                        }

                     }
                     else
                    {
                        DataTable dt2 = bl.validarelacionhorarioalumnoinactivo(matcarr, alumno);
                        if (dt2.Rows.Count > 0)
                        {
                            dtca2.DataSource = dt2;
                            string E1 = Convert.ToString(dtca2.Rows[0].Cells[2].Value.ToString());
                            string E2 = Convert.ToString(dtca2.Rows[0].Cells[1].Value.ToString());

                            if (E1 == matcarr && E2 == alumno)
                            {
                                MessageBox.Show("La relacion ya existe y se encuentra dada de baja");

                            }
                            //MessageBox.Show("La relacion ya existe y se encuentra dada de baja");
                        }
                        else
                        {
                            bl.Alta_rel_matcarr_horario_alumno(matcarr, alumno);
                        }
                     }




                    































                }

                



            }

            else
            {
                MessageBox.Show("ERROR AL INGRESAR");
            }

            Form1 f = new Form1();
                        f.Show();
                        this.Hide();



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

        private void dtvalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
