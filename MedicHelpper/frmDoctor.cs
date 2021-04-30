using MedicHelpper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicHelpper
{
    public partial class frmDoctor : MedicHelpper.frmPadre
    {
        Validaciones validar = new Validaciones();
        ClassEnfermero enfer = new ClassEnfermero();
        int especialidadDoc = 0;
        bool CampoCodCita, CampoTarjCita, NombreAdd, ApellidoAdd,CodUsuario, CodUsuarioDoc, FechaCita= true, Descripcion;

        public frmDoctor()
        {
            InitializeComponent();
        }
        public frmDoctor(int cod,int tipoDoc)
        {
            InitializeComponent();
            if (cod == 1)
            {
                pctAtras.Enabled = false;
                pctAtras.Visible = false;
            }
            especialidadDoc = tipoDoc;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pctAtras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuAdministrador frm = new MenuAdministrador("");
            frm.Visible = true;
        }
        // validacion para que los campos no queden vacios

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
        private bool ValidarCampoLetras(TextBox txt, KeyPressEventArgs e, ErrorProvider error)
        {
            bool ok = true;
            //condicion solo para letras
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                ok = true;
            }
            //tecla backspac
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                ok = true;
            }
            //Verifica que admite tecla espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                ok = true;
            }
            //si no cumple nada lo deja pasar
            else
            {
                e.Handled = true;
                ok = false;
                error.SetError(txt, "Ingrese unicamente Numeros");
                txt.Text = "";
            }
            return ok;
        }

        private bool ValidarFechaCita(DateTimePicker dt)
        {
            DateTime fechaSeleccionada = dt.Value;
            DateTime fechaActual = System.DateTime.Now;
            bool ok = true;
            if (fechaSeleccionada < fechaActual)
            {
                errorFecha.SetError(dtpCita, "Error la fecha seleccionada es menor a la fecha actual");
                ok = false;
            }
            return ok;
        }

        private void BorrarValidar()
        {
            //errorCodigoCita.SetError(textBox4, "");
            errorCodigoTarjeta.SetError(txtTarjeta, "");
            errorCodigoCita.SetError(txt_CODCITa, "");
            ErrorPaciente.SetError(txt_codPaci, "");
            errorFech.SetError(txt_fecha, "");
            errorCita.SetError(txt_cita, "");
            errorCodigoCons.SetError(txt_RecetDoc, "");
            errorCodUSuario.SetError(txt_codusuario, "");
            errorCodigoCita.SetError(txt_codigocita, "");
            errorFech.SetError(txt_fecha_doc, "");
            errorDescripcion.SetError(txt_DescripcionDoc, "");


        }
    
        private void txt_CODCITa_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoCita.SetError(txt_CODCITa, "");
            NombreAdd = ValidarCampoLetras(txt_CODCITa, e, errorCodigoCita);
        }
        private void txt_codusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            errorCodUSuario.SetError(txt_codusuario, "");
            CodUsuarioDoc = ValidarCamposVacios(txt_codusuario, errorCodUSuario);
        }
        private void txt_codigocita_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoCita.SetError(txt_codigocita, "");
            NombreAdd = ValidarCampoLetras(txt_codigocita, e, errorCodigoCita);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {    
            errorCodigoCita.SetError(txtCita, "");
            CampoCodCita = ValidarCamposNumericos(txtCita, e, errorCodigoCita);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoTarjeta.SetError(txtTarjeta, "");
            CampoTarjCita = validar.ValidarCamposVacios(txtTarjeta, errorCodigoTarjeta);
        }

        private void txt_fecha_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorFech.SetError(txt_fecha_doc, "");
            FechaCita = ValidarCamposVacios(txt_fecha_doc, errorFech);
        }

        private void txt_DescripcionDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorDescripcion.SetError(txt_DescripcionDoc, "");
            Descripcion = ValidarCamposVacios(txt_DescripcionDoc, errorDescripcion);
        }
        private void txt_codPaci_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorPaciente.SetError(txt_codPaci, "");
            ApellidoAdd = ValidarCampoLetras(txt_codPaci, e, ErrorPaciente);
        }
        private void txt_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorFech.SetError(txt_fecha, "");
            ApellidoAdd = ValidarCampoLetras(txt_fecha, e, errorFech);
        }
        private void txt_cita_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCita.SetError(txt_cita, "");
            ApellidoAdd = ValidarCampoLetras(txt_cita, e, errorCita);
        }

        private void txt_ConsultaDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodUSuario.SetError(txt_codusuario, "");
            CodUsuario = ValidarCamposNumericos(txt_codusuario, e, errorCodUSuario);
            
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            errorFecha.SetError(dtpCita, "");
            FechaCita = ValidarFechaCita(dtpCita);

        }
        private void btn_guardar_diagnostico_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Consulta (IdUsuarioConsulta,idCita,Descripcion,CodReceta,Fecha) values ('" + txt_codusuario.Text+ "','" +txt_codigocita.Text+ "','" +txt_DescripcionDoc.Text+ "','"+ txt_RecetDoc.Text + "','" + txt_fecha_doc.Text+ "')";
            
            if (ObDatos.AgregarCita(sql)) { 
                MessageBox.Show("Datos insertados correctamente");
                //string eliminado = "delete from Cita where idCita " + txt_codigocita;
                
            }
            else { MessageBox.Show("Hubo un problema con la insersion de datos"); }

            
            ////  FALTA HACER QUE BORRE DE LA BASE DE DATOS LAS CITAS YA ATENDIDAS
            ///
        }

        ClassDoctor ObDatos = new ClassDoctor();
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            ObDatos.BusquedaDeCita(txt_CODCITa, txt_codPaci, txt_fecha, txt_cita);
        }
        private void btn_MostrarData_Click(object sender, EventArgs e)
        {
            if (especialidadDoc!=-1)
            {
                ObDatos.AtenderPaciente(especialidadDoc, dataGridView1);
            }
            else
            {
                ObDatos.BuscarCita("Select * from Cita ", "Consulta");
                this.dataGridView1.DataSource = ObDatos.ds.Tables["Consulta"];
            }
            
        }
        private void btnAddCita_Click(object sender, EventArgs e)
        {
            BorrarValidar();
            if (validar.ValidarCamposVacios(txtTarjeta, errorCodigoTarjeta)
                   && FechaCita)
            {
                enfer.AgregarCita(dtpCita, txtTarjeta.Text, label8, txtCita,cbEspecilidadCita);
                errorFecha.SetError(dtpCita, "");
            }
            else
            {
                if (!FechaCita)
                {
                    errorFecha.SetError(dtpCita, "Campo con datos no validos, ingrese fechas proximas");
                }
                else if (!CampoTarjCita)
                {
                    errorCodigoTarjeta.SetError(txtTarjeta, "Campo con datos no validos,\n Vuelva a intentar ingresar");
                }
                else
                {
                    errorCodigoTarjeta.SetError(txtTarjeta, "Campos con datos vacios");
                }
            }
        }
    }
}
