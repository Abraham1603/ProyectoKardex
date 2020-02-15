using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlayerUI
{
    public partial class Form1 : Form
    {

        public frmConsultaCarrera frmconscarr;
        public frmAltaCarrera frmaltacarr;
        public frmModificaCarrera frmmodcarr;
        public frmAltaMateria frmaltamat;

        public frmConsultaMateria frmconmat;
        public frmModificaMateria frmmodmat;
        public ReactivarCarrera frmreactivar;
        public ReactivarMateria frmreactivarmat;
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            panelMaestroSubMenu.Visible = false;
            panelPeriodoSubMenu.Visible = false;
            panelCaliSubMenu.Visible = false;
            panelCarreraMateria.Visible = false;
            panelCarreraAlumnoMaestro.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmaltacarr = new frmAltaCarrera();
            frmaltacarr.Show();
            

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmconscarr = new frmConsultaCarrera();
            frmconscarr.Show();

            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmodcarr = new frmModificaCarrera();
            frmmodcarr.Show();
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmaltamat = new frmAltaMateria();
            frmaltamat.Show();
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmconmat = new frmConsultaMateria();
            frmconmat.Show();
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmodmat = new frmModificaMateria();
            frmmodmat.Show();
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
       

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAltaAlumno frm = new frmAltaAlumno();

            frm.Show();
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
             this.Hide();

            frmConsultaAlumno frm = new frmConsultaAlumno();

            frm.Show();
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmModificaAlumno frm = new frmModificaAlumno();

            frm.Show();
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..

            showSubMenu(panelMaestroSubMenu);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Dispose();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PanelPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPeriodoSubMenu);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCaliSubMenu);
        }

        private void Button26_Click(object sender, EventArgs e)
        {

        }

        private void Button28_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCarreraMateria);

        }

        private void Button33_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCarreraAlumnoMaestro);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmreactivar = new ReactivarCarrera();
            frmreactivar.Show();
            hideSubMenu();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmreactivarmat = new ReactivarMateria();
            frmreactivarmat.Show();
            hideSubMenu();
        }

        private void btnaltaperiodo_Click(object sender, EventArgs e)
        {

            this.Hide();

            FrmAltaPeriodo frm = new FrmAltaPeriodo();

            frm.Show();

        }

        private void btnconsultaperiodo_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmConsultaPeriodo frm = new FrmConsultaPeriodo();

            frm.Show();
        }

        private void btnmodificacionperiodo_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmModificaPeriodo   frm = new FrmModificaPeriodo();

            frm.Show();
        }

        private void btnreactivarperiodo_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReactivarPeriodo frm = new ReactivarPeriodo();

            frm.Show();
        }

        private void btnaltamaestro_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmAltaMaestro frm = new FrmAltaMaestro();

            frm.Show();
        }

        private void btnconsultamaestro_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmConsultaMaestro frm = new FrmConsultaMaestro();

            frm.Show();
        }

        private void btnmodifimaestro_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmModificaMaestro frm = new FrmModificaMaestro();

            frm.Show();
        }

        private void btnreactivacionmaestro_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReactivarMaestro frm = new ReactivarMaestro();

            frm.Show();
        }

        private void button33_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmrelmatcarr f = new frmrelmatcarr();
            f.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaRelmatcarr f = new frmAltaRelmatcarr();
            f.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmodificarmc f = new frmmodificarmc();
            f.Show();
        }

        private void button33_Click_2(object sender, EventArgs e)
        {
            showSubMenu(panelCarreraAlumnoMaestro);
        }

        private void button36_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmAltaRelmatalum f = new frmAltaRelmatalum();
            f.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaRelmatalum f = new frmConsultaRelmatalum();
            f.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmodificarelmatalu f = new frmmodificarelmatalu();
            f.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ReactivarAlumno f = new ReactivarAlumno();
            f.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReactivarRelMarCar f = new ReactivarRelMarCar();
            f.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReactivarMatAlum f = new ReactivarMatAlum();
            f.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmconsultacalificaciones f = new frmconsultacalificaciones();
            f.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmaltacalificacion f = new frmaltacalificacion();
            f.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmodificacalificacion f = new frmmodificacalificacion();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmAlta_rel_matcarr_horario f1 = new frmAlta_rel_matcarr_horario();
                f1.Show();
            this.Hide();
        }
    }
}
