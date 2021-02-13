using MedicHelpper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicHelpper
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador(string nombre)
        {
            InitializeComponent();
            lbluser.Text = nombre;
            
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMedicHelppercs login = new LoginMedicHelppercs();
            login.Show();
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMedicHelppercs login = new LoginMedicHelppercs();
            login.Show();
        }

        private void btncitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnfer citas = new frmEnfer();
            citas.Show();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();
            this.Hide();
            frm.Visible = true;
        }

        private void btnfarmacia_Click(object sender, EventArgs e)
        {
            Farmaceuticos frm = new Farmaceuticos();
            this.Hide();
            frm.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Image = Resources.redimensionar;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                btnRestaurar.Image = Resources.redimensionar;
                this.WindowState = FormWindowState.Maximized;
                btnRestaurar.Image = Resources.restaurar;
            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
