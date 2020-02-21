﻿using System;
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
    public partial class frmAltaCampus : Form
    {
        BL bl = new BL();
        public frmAltaCampus()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string campus = txtCarrera.Text.Trim();
            string ubicacion = txtubicacion.Text.ToString();



            DataTable dt = bl.validacampus(campus);
            if (dt.Rows.Count > 0)
            {
                dtca.DataSource = dt;
                string a = Convert.ToString(dtca.Rows[0].Cells[0].Value.ToString());

                if (a == campus)
                {
                    MessageBox.Show("El Campus ya existe");
                }

            }
            else
            {
                bl.Altacampus(campus, ubicacion);

            }

            //  bl.AltaAlumno(nombre, direccion, telefono, fe, carrera, user,pass);

            this.Hide();

            Form1 frm = new Form1();

            frm.Show();











        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}