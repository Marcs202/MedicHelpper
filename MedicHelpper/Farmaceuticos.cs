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
    public partial class Farmaceuticos : Form
    {
        public Farmaceuticos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnRestaurar_Click_1(object sender, EventArgs e)
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
        private void pctAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador login = new MenuAdministrador("");
            login.Show();
        }
        private bool ValidarCamposVacios(TextBox txt, ErrorProvider error)
        {
            bool ok = true;
            if (txt.Text == "")
            {
                ok = false;
                error.SetError(txt, "Ingrese datos en el campo.");
            }
            return ok;
        }
        private bool ValidarCamposNumericos(TextBox txt, KeyPressEventArgs e, ErrorProvider error)
        {
            bool ok = true;
            if (char.IsDigit(e.KeyChar))
            {
                ok = true;
                e.Handled = false;
            }
            //tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                ok = true;
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txt.Text.Contains(".")))
            {
                ok = true;
                e.Handled = false;
            }
            else
            {
                ok = false;
                e.Handled = true;
                error.SetError(txt, "Ingrese datos numericos en el campo");
                txt.Text = "";
            }
            return ok;
        }
        bool nomr,ubi,des,cod,cant;

        private void txtNOmbreMEdicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorNombre.SetError(txtNOmbreMEdicamento, "");
            nomr = ValidarCamposVacios(txtNOmbreMEdicamento, errorNombre);
        }
     

        private void txtUbicacionMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorUbicacion.SetError(txtUbicacionMed, "");
            ubi = ValidarCamposVacios(txtUbicacionMed,  errorUbicacion);

        }
 
        private void txtDescripcionmed_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorDescripcion.SetError(txtDescripcionmed, "");
            des = ValidarCamposVacios(txtDescripcionmed, errorDescripcion);
        }
 

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoMed.SetError(txtCodigo, "");
            cod = ValidarCamposNumericos(txtCodigo, e,errorCodigoMed);
        }

        private void txtCantidadMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCantidad.SetError(txtCantidadMed, "");
            cant = ValidarCamposNumericos(txtCantidadMed, e, errorCantidad);
        }

        //
        ClassFarmaceutico obDatos = new ClassFarmaceutico();
        private void btningresarusuario_Click(object sender, EventArgs e)
        {
            ClassFarmaceutico obDatos = new ClassFarmaceutico();
            int año = datmMedicamento.Value.Year;
            int mes = datmMedicamento.Value.Month;
            int dia = datmMedicamento.Value.Day;
            string fecha = dia.ToString() + "-" + mes.ToString() + "-" + año.ToString();
            string sql= "insert into Medicamentos(Nombre,Cantidad,Descripcion,Ubicacion,FechaExpiracion)values('"+this.txtNOmbreMEdicamento.Text+"','"+this.txtCantidadMed.Text+"','"+this.txtDescripcionmed.Text+"','"+this.txtUbicacionMed.Text+"','"+fecha+"')";
            if (obDatos.AñadirMedicamentos(sql)) { MessageBox.Show("Registro Insertado"); } else { MessageBox.Show("Error al insertar"); }

        }

        private void btnMostMedicamento_Click(object sender, EventArgs e)
        {
            dtgVAnadirMedicamento.DataSource = obDatos.MostrarMedicamento();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtIdReceta.Text;
            dtgv_buscaRecta.DataSource = obDatos.BusquedaReceta(id);
            txtIdReceta.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obDatos.BusquedaMedicamentos(txtBuscaMed, dtgv_BusquedaMEd);
        }

        private void btnActualizarMed_Click(object sender, EventArgs e)
        {
            string Medicamento = txtCodMedicamento.Text;
            string Cantidad = txtCantMed.Text;
            obDatos.DespachoMedicamento(Medicamento,Cantidad,dtgv_Despacho);
            
        }
    }
}

