using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicHelpper
{
    class Validaciones
    {

        //Metodo para validar que ningun campo quede vacío
        public bool ValidarCamposVacios(TextBox txt, ErrorProvider error)
        {
            bool ok = true;
            if (txt.Text == "")
            {
                ok = false;
                error.SetError(txt, "Ingrese datos en el campo.");
            }
            return ok;
        }
        //Metodo para validar  que en los campos solo se ingresen  numeros donde sea necesario
        public bool ValidarCamposNumericos(TextBox txt, KeyPressEventArgs e, ErrorProvider error)
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
            //Verifica que pueda ingresar punto y solo punto
            else if ((e.KeyChar == '.') && (!txt.Text.Contains(".")))
            {
                ok = true;
                e.Handled = false;
            }
            //si no cumple nada el errorprovider se activa y la funcion devuelve un false ademas de no dejar escribir y borrar el texto 
            //Para evitar que escriba mal de nuevo
            else
            {
                ok = false;
                e.Handled = true;
                error.SetError(txt, "Ingrese datos numericos en el campo");
                txt.Text = "";
            }
            return ok;
        }
        //Metodo de validacion done la fecha seleccionada sea MAYOR  a la actual
        public bool ValidarFechaCita(DateTimePicker dtp,ErrorProvider errorFecha)
        {
            DateTime fechaSeleccionada = dtp.Value;
            DateTime fechaActual = System.DateTime.Now;
            bool ok = true;
            if (fechaSeleccionada < fechaActual)
            {
                errorFecha.SetError(dtp, "Error la fecha seleccionada es menor a la fecha actual");
                ok = false;
            }
            return ok;
        }
        //Validacion de Fechas de nacimiento
        public bool ValidarFechaNacimiento(DateTimePicker dtp, ErrorProvider errorFecha)
        {
            DateTime fechaSeleccionada = dtp.Value;
            DateTime fechaActual = System.DateTime.Now;
            bool ok = true;
            if (fechaSeleccionada > fechaActual)
            {
                errorFecha.SetError(dtp, "Error la fecha seleccionada es mayor a la fecha actual, ingrese fechas de nacimiento validas");
                ok = false;
            }
            return ok;
        }

        //Metodo para evaluar que solo se ingresen letras en los campos donde sea necesario
        public bool ValidarCampoLetras(TextBox txt, KeyPressEventArgs e, ErrorProvider error)
        {
            bool ok = true;
            //condicion solo para letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                ok = true;
            }
            //tecla backspace
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
                error.SetError(txt, "Ingrese unicamente letras");
                txt.Text = "";
            }
            return ok;
        }
        
    }
}
