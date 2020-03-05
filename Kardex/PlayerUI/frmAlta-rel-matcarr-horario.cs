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


            DataTable dt8 = bl.Valida_carrera(matcarr);

            if (dt8.Rows.Count > 0)
            {
                dtcgrupo.DataSource = dt8;
                string validacarrera = dtcgrupo.Rows[0].Cells[0].Value.ToString();
                string validagrupo = dtcgrupo.Rows[0].Cells[1].Value.ToString();
                string siglasgrupo = validagrupo.Remove(0, 2);
                string siglasgrupo2 = grupo.Remove(0, 2);
                if (siglasgrupo  == siglasgrupo2 )
                {

                    DataTable dt5 = bl.Valida_materia(matcarr, periodo, grupo);
                    if (dt5.Rows.Count == 0)
                    {



                        DataTable dt = bl.Valida_horario(horario, horario2, periodo, grupo);
                        if (dt.Rows.Count == 0)
                        {
                            
                            bl.Alta_rel_matcarr_horario(matcarr, horario, horario2, periodo, grupo);
                        }
                        else
                        {
                            MessageBox.Show("No puede haber dos materias en el mismo horario");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El grupo no puede tener asignada dos veces la materia en el mismo periodo");
                    }

                    
                }
                else
                {
                    MessageBox.Show(" Lo siento pero la carrera " + validacarrera +" pertenece al grupo " + validagrupo  );

                }
               
            }
            else
            {
                DataTable dt5 = bl.Valida_materia(matcarr, periodo, grupo);


                if (dt5.Rows.Count == 0)
                {



                    DataTable dt = bl.Valida_horario(horario, horario2, periodo, grupo);
                    if (dt.Rows.Count == 0)
                    {
                        bl.Alta_rel_matcarr_horario(matcarr, horario, horario2, periodo, grupo);
                    }
                    else
                    {
                        MessageBox.Show("No puede haber dos materias en el mismo horario");
                    }

                }
                else

                {
                    MessageBox.Show("El grupo no puede tener asignada dos veces la materia en el mismo periodo");

                }




                //bl.Alta_rel_matcarr_horario(matcarr, horario, horario2, periodo, grupo);
            }
             

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
