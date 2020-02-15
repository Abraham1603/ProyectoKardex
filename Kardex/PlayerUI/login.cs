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
    public partial class login : Form
    {
        BL bl = new BL();
        DAL dal = new DAL();

        public login()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
                string matricula = txtuser.Text;
            string pass = txtpass.Text;


            string tipo = cbtu.SelectedIndex.ToString();

            if (tipo == "0")
            {

                if (matricula == "" && pass == "")
                {
                    MessageBox.Show("Ingresa valores en los campos de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (matricula != "" && pass == "")
                {
                    MessageBox.Show("Ingresa una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (matricula == "" && pass != "")
                {
                    MessageBox.Show("Ingresa una matricula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Text = "";
                }
                else
                {
                    DataTable dt = bl.user(matricula, pass);
                    if (dt.Rows.Count > 0)
                    {
                        dtuser.DataSource = dt;
                        string a = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[0].Value.ToString());
                        string b = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[1].Value.ToString());
                        string c = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[2].Value.ToString());
                        string d = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[3].Value.ToString());


                        if (a == matricula && d == pass)
                        {
                            MessageBox.Show("Bienvenido" + " " + b, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Matricula No Valida", "Aletra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtpass.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Matricula o contraseña no validos", "Aletra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtpass.Text = "";
                    }
                }


            }
            else if (tipo == "1")
            {
                if (matricula == "" && pass == "")
                {
                    MessageBox.Show("Ingresa valores en los campos de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (matricula != "" && pass == "")
                {
                    MessageBox.Show("Ingresa una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Text = "";
                }
                else if (matricula == "" && pass != "")
                {
                    MessageBox.Show("Ingresa una matricula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Text = "";
                }
                else
                {
                    DataTable dt = bl.userma(matricula, pass);
                    if (dt.Rows.Count > 0)
                    {
                        dtuser.DataSource = dt;
                        string a = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[0].Value.ToString());
                        string b = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[1].Value.ToString());
                        string c = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[2].Value.ToString());
                        string d = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[3].Value.ToString());


                        if (a == matricula && d == pass)
                        {
                            MessageBox.Show("Bienvenido" + " " + b, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Form1 frm = new Form1();
                            frm.Show();

                        }
                        else
                        {
                            MessageBox.Show("Matricula No Valida", "Aletra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtpass.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Matricula o contraseña no validos", "Aletra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtpass.Text = "";
                    }
                }

            }
            else if (tipo == "2")
            {
                if (matricula == "" && pass == "")
                {
                    MessageBox.Show("Ingresa valores en los campos de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (matricula != "" && pass == "")
                {
                    MessageBox.Show("Ingresa una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Text = "";
                }
                else if (matricula == "" && pass != "")
                {
                    MessageBox.Show("Ingresa una matricula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Text = "";
                }
                else
                {/*
                    DataTable dt = bl.useradmin(matricula, pass);
                    if (dt.Rows.Count > 0)
                    {
                        dtuser.DataSource = dt;
                        string a = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[0].Value.ToString());
                        string b = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[1].Value.ToString());
                        string c = txtma.Text = Convert.ToString(dtuser.Rows[0].Cells[2].Value.ToString());
                    
                        

                        if (b == matricula && c == pass)
                        {
                            MessageBox.Show("Bienvenido" + " " + b, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Form1 frm = new Form1();
                            frm.Show();

                        }
                        else
                        {
                            MessageBox.Show("Matricula No Valida", "Aletra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtpass.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Matricula o contraseña no validos", "Aletra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtpass.Text = "";
                    }*/
                }

            }
            else
            {
                MessageBox.Show("Porfavor seleccione una Opcion", "Aletra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Text = "";
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if (Char.IsDigit(e.KeyChar))
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

        private void dtuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
