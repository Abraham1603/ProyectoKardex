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
    public partial class frmAltaRelmatcarr : Form
    {
        BL bl = new BL();
        public frmAltaRelmatcarr()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string materia = cbmateria.SelectedItem.ToString();
            string carrera = cbcarreras.SelectedItem.ToString();


            bl.Altarmc(carrera, materia);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void frmAltaRelmatcarr_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadoca();

            if (dt.Rows.Count > 0)
            {
                dtllenadoca.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No  hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbcarreras.Items.Add(dt.Rows[i]["carrera"]);
            }


            DataTable dtma = bl.llenadoma();

            if (dtma.Rows.Count > 0)
            {
                dtllenadoma.DataSource = dtma;
            }
            else
            {
                MessageBox.Show("No hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dtma.Rows.Count; i++)
            {
                cbmateria.Items.Add(dtma.Rows[i]["materia"]);
            }
        }
    }
}
