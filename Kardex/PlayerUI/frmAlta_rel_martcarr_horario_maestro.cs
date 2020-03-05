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
    public partial class frmAlta_rel_martcarr_horario_maestro : Form
    {
        BL bl = new BL();
        public frmAlta_rel_martcarr_horario_maestro()
        {
            InitializeComponent();
        }
       
        private void Btnregresarma_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

      

        private void btnguardarMa_Click(object sender, EventArgs e)
        {
            string matcarr = cbmatcarrDo.SelectedItem.ToString();
            string maestro = cbMaestro.SelectedItem.ToString();



            DataTable dt = bl.No_debe_permitir_asignar_una_materia_que_ya_esta_aprobada_Docente(matcarr, maestro);
            if (dt.Rows.Count > 0)
            {
                dtvalidaMa.DataSource = dt;
                string a = Convert.ToString(dtvalidaMa.Rows[0].Cells[2].Value.ToString());
                string b = Convert.ToString(dtvalidaMa.Rows[0].Cells[1].Value.ToString());

                float val = float.Parse(a);

                if (val > 7)
                {
                    MessageBox.Show("No debe permitir asignar una materia que ya está aprobada");
                }
                else
                {
                    //VALIDA QUE EXISTA EL PROFESOR
                    DataTable dt4 = bl.Valida_maestro_matcarr(maestro, matcarr);
                    if (dt4.Rows.Count > 0)
                    {   
                            MessageBox.Show("Ya se encuentra asignado este Maestro a ese grupo");
                    }

                    else
                    {
                        DataTable dt9 = bl.valida_horario_maestro_matcarr(matcarr,maestro);
                        if (dt9.Rows.Count > 0)
                        {
                            MessageBox.Show("No puede tener dos materias en el mismo horario");
                        }
                        else
                        {
                            bl.Alta_rel_matcarr_horario_Maestro(matcarr, maestro);
                        }
                                         
                    }
                }
            }
            else
            {


                DataTable dt4 = bl.Valida_maestro_matcarr(maestro, matcarr);
                if (dt4.Rows.Count > 0)
                {
                    MessageBox.Show("Ya se encuentra asignado este Maestro a ese grupo");
                }

                else
                {
                    DataTable dt9 = bl.valida_horario_maestro_matcarr(matcarr, maestro);
                    if (dt9.Rows.Count > 0)
                    {
                        MessageBox.Show("No puede tener dos materias en el mismo horario");
                    }
                    else
                    {
                        bl.Alta_rel_matcarr_horario_Maestro(matcarr, maestro);
                    }

                }
            }
        }

        private void btnregresarma_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void frmAlta_rel_martcarr_horario_maestro_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadomatcarr_horario();

            if (dt.Rows.Count > 0)
            {
                dtmatcarrMa.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbmatcarrDo.Items.Add(dt.Rows[i]["Materia-Carrera-Grupo"]);
            }





            DataTable dt1 = bl.llenadomaestro();

            if (dt1.Rows.Count > 0)
            {
                dtMaestro.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay Maestro ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbMaestro.Items.Add(dt1.Rows[i]["nombre"]);
            }
        }
    }
}
