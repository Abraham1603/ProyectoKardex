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
    public partial class frmaltacalificacion : Form
    {
        BL bl = new BL();

        public frmaltacalificacion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idrma = cbrma.SelectedItem.ToString();
            string cali = txtcali.Text;
            string uni = txtunidad.Text;

            bl.AltaCalificacion(idrma, cali, uni);

            txtcali.Clear();
            txtunidad.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void frmaltacalificacion_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.llenadorma();

            if (dt.Rows.Count > 0)
            {
                dtllenadorma.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay relaciones ", "Aviso", MessageBoxButtons.OK);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbrma.Items.Add(dt.Rows[i]["id_relmatalum"]);
            }
        }

        private void txtcali_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    
}
