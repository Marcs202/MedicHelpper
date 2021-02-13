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
using System.Data.SqlClient;

namespace MedicHelpper
{
    public partial class Usuarios : Form
    {
        ConexionSqlServer conectar = new ConexionSqlServer();
        List<ClassUsuarios> TodosLosUsuarios = new List<ClassUsuarios>();
        List<ClassUsuarios> ResultadosBusquedaUsuarios = new List<ClassUsuarios>();
        private int indice = -1;
        public Usuarios()
        {
            InitializeComponent();
            //cuenta la cantiad de registros
            string tabla = "TipoUsuario";
            int conta = contarRegistros(tabla);
            for (int x = 0; x < conta; x++)
            {
                conectar.conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TipoUsuario where IdTipoUsuario = " + x, conectar.conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cmbtipousuarioreg.Items.Add(Convert.ToString(dr["TipoUsuario"]));
                    cmbbuscartipo.Items.Add(Convert.ToString(dr["TipoUsuario"]));
                }
                conectar.conexion.Close();
            }
            IniciarGrid();
        }
        private void Limpiar()
        {
            txbnombreusuarioreg.Clear();
            txbapellidousurioreg.Clear();
            txbduiusuarioreg.Clear();
            txbcontraseñareg.Clear();
            txbbuscarnombre.Clear();
            txbbuscarapellido.Clear();
            txbbuscardui.Clear();
            txbbusquedamuestranombre.Clear();
            txbcontraseñabuscar.Clear();
            cmbbuscartipo.SelectedIndex = -1;
            cmbtipousuarioreg.SelectedIndex = -1;
            dtpfechanacreg.Value = DateTime.Today;
            dtpbuscarfecha.Value = DateTime.Today;
            IniciarGrid();
            txbnombrebusqueda.Clear();
            txbbusquedamuestranombre.Clear();
            txbbuscarid.Clear();
            indice = -1;
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
        //registrar usuario------------------------------------------------------------
        private void txbnombreusuarioreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)){ e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txbapellidousurioreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txbduiusuarioreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cmbtipousuarioreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnlimpiarusuario_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private string generarCodigoUsuario(string nombre, string apellido, int dia, int año)
        {
            string diaNuveo = "";
            string añoNuevo = Convert.ToString(año);
            string añoN =""+añoNuevo[2] + añoNuevo[3];
            if(dia> 0 && dia <= 9)
            {
                diaNuveo = 0+Convert.ToString(dia);
            }
            else
            {
                diaNuveo = Convert.ToString(dia);
            }
            string primeraLNombre = Convert.ToString( nombre[0]);
            string primeraLApellido = Convert.ToString(apellido[0]);
            string cadenaCodigo = primeraLNombre + primeraLApellido + diaNuveo + añoN;
            return cadenaCodigo.ToUpper();
        }
        private void btningresarusuario_Click(object sender, EventArgs e)
        {
            //try
            //{
                string DUI = txbduiusuarioreg.Text;
                string nombre= txbnombreusuarioreg.Text, apellido = txbapellidousurioreg.Text;
                if (DUI.Length == 9)
                {
                    if(nombre.Length >= 4 && apellido.Length >= 4)
                    {
                        if(cmbtipousuarioreg.SelectedIndex > -1)
                        {
                            //REGISTRAMOS USUARIOS
                            int año = dtpfechanacreg.Value.Year;
                            int mes = dtpfechanacreg.Value.Month;
                            int dia = dtpfechanacreg.Value.Day;
                            string codigoGenerado = generarCodigoUsuario(txbnombreusuarioreg.Text, txbapellidousurioreg.Text, dia,año);
                            int tipousuario=-1;
                            if (cmbtipousuarioreg.Text == "Administrador")
                            {
                                tipousuario = 0;
                            }
                            else if (cmbtipousuarioreg.Text == "Enfermeria")
                            {
                                tipousuario = 1;
                            }
                            else if (cmbtipousuarioreg.Text == "Dotores")
                            {
                                tipousuario = 2;
                            }
                            else if (cmbtipousuarioreg.Text == "Farmaceutico")
                            {
                                tipousuario = 2;
                            }
                            string nuevafecha = Convert.ToString(dia) + "-" + Convert.ToString(mes) +"-" +Convert.ToString(año);
                            string cadenaInsertar = "INSERT INTO Usuarios VALUES ('" + codigoGenerado + "','" + txbcontraseñareg.Text +"','" + nombre + "','"+apellido +"','"+ dia+"-"+mes+"-"+año+ "','" + DUI + "','" + tipousuario + "');";
                            conectar.conexion.Open();
                            SqlCommand inserto = new SqlCommand(cadenaInsertar, conectar.conexion);
                            inserto.ExecuteNonQuery();
                            conectar.conexion.Close();
                            MessageBox.Show("Usuario insertado con éxito\nDatos ingresados:\nCodigo del usuario: " + codigoGenerado +
                                "\nNombre: " + nombre + apellido + "\nFecha de nacimiento: " + dia + "-" + mes + "-" + año + "\nDUI: " + DUI + "\nTipo usuario: " + cmbtipousuarioreg.Text);
                            Limpiar();
                        
                        
                        }
                        else
                        {
                            MessageBox.Show("ALERTA: Seleccione el tipo usuario.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("ALERTA: Revise nombre y apellido ingresado.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("ALERTA: DUI debe tener 9 caracteres.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }
        //------------------------------------------------------------
        //Modificar usuario------------------------------------------------------------
        private void txbnombrebusqueda_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbnombrebusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txbbuscarnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txbbuscarapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txbbuscardui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IniciarGrid();
                ResultadosBusquedaUsuarios.Clear();
                string nombre = txbnombrebusqueda.Text;
                if (nombre.Length == 6)
                {
                    int cantidadRegistros = dtgvbusquedaresultados.RowCount;
                    for (int i = 0; i < cantidadRegistros; i++)
                    {
                        string valorUsuario = dtgvbusquedaresultados.Rows[i].Cells[0].Value.ToString();
                        if (nombre == valorUsuario)
                        {
                            ResultadosBusquedaUsuarios.Add(TodosLosUsuarios[i]);
                        }
                    }
                    dtgvbusquedaresultados.DataSource = null;
                    dtgvbusquedaresultados.DataSource = ResultadosBusquedaUsuarios;
                }
                else
                {
                    MessageBox.Show("ALERTA: Verifique los datos ingresados para la busqueda.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
}
        private void dtgvbusquedaresultados_DoubleClick(object sender, EventArgs e)
        {
            //--------------------------------------
            DataGridViewRow selecionar = dtgvbusquedaresultados.SelectedRows[0];
            int posicion = dtgvbusquedaresultados.Rows.IndexOf(selecionar);
            indice = posicion;
            ClassUsuarios usu = TodosLosUsuarios[posicion];
            txbbuscarid.Text = usu.Usuario;
            txbcontraseñabuscar.Text = usu.Password;
            txbbuscarnombre.Text = usu.Nombre;
            txbbuscarapellido.Text = usu.Apellido;
            dtpbuscarfecha.Text = usu.FechaNacimiento;
            txbbuscardui.Text = usu.DUI;
            cmbbuscartipo.SelectedIndex = Convert.ToInt16(usu.TipoDeUsuario);
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            //try
            //{

                string DUI = txbbuscardui.Text;
                string nombre = txbbuscarnombre.Text, apellido = txbbuscarapellido.Text;
                if (DUI.Length == 9)
                {

                    if (nombre.Length >= 4 && apellido.Length >= 4)
                    {
                        
                        string comandoActualizarDatos = "UPDATE Usuarios SET Contraseña = '" + txbbuscarid.Text + "', Nombre = '" + txbbuscarnombre.Text + "', Apellido = '" + txbbuscarapellido.Text + "', FechaDeNacimiento = '" + dtpbuscarfecha.Value + "', DUI = '" + txbbuscardui.Text + "', IdTipoUsuarioUsusarios = '" + cmbbuscartipo.SelectedIndex + "' WHERE IdUsuario = '" + txbbuscarid.Text + "'";
                        conectar.conexion.Open();
                        SqlCommand comandoActualizar = new SqlCommand(comandoActualizarDatos, conectar.conexion);
                        comandoActualizar.ExecuteNonQuery();
                        conectar.conexion.Close();
                        Limpiar();
                        IniciarGrid();
                    }
                    else
                    {
                        MessageBox.Show("ALERTA: Revise nombre y apellido ingresado.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("ALERTA: DUI debe tener 9 caracteres.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                
                string idEliminar = txbbuscarid.Text;
                string eliminar = "DELETE FROM Usuarios WHERE IdUsuario = '" + idEliminar + "'";
                conectar.conexion.Open();
                SqlCommand eliminarComando = new SqlCommand(eliminar, conectar.conexion);
                eliminarComando.ExecuteNonQuery();
                conectar.conexion.Close();
                MessageBox.Show("Se elimino con exito el registro.");
                Limpiar();
                IniciarGrid();
            }
            else
            {
                MessageBox.Show("ALERTA: Tienes que dar doble click sobre el registro para que sea seleccionado.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnlimpiarbusqueda_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //------------------------------------------------------------
        //mostrar usuarios------------------------------------------------------------
        
        private void txbbusquedamuestranombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnbuscarEnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                IniciarGrid();
                ResultadosBusquedaUsuarios.Clear();
                string nombre = txbbusquedamuestranombre.Text;
                int cantidadRegistros = dtgvmostrarusuarios.RowCount;
                if (nombre.Length == 6)
                {
                    for(int i = 0; i < cantidadRegistros; i++)
                    {
                        string datoBuscado = dtgvmostrarusuarios.Rows[i].Cells[0].Value.ToString();
                        if (datoBuscado == nombre)
                        {
                            ResultadosBusquedaUsuarios.Add(TodosLosUsuarios[i]);
                        }
                    }
                    dtgvmostrarusuarios.DataSource = null;
                    dtgvmostrarusuarios.DataSource = ResultadosBusquedaUsuarios;
                }
                else
                {
                    MessageBox.Show("ALERTA: Verifique los datos ingresados para la busqueda.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnlimpiarelmostrarusuarios_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void pctAtras_Click(object sender, EventArgs e)
        {

            this.Hide();
            MenuAdministrador menu = new MenuAdministrador("");
            menu.Show();
        }
        
        private int contarRegistros(string tabla)
        {
            int conteo=0;
            conectar.conexion.Open();
            string consulta = "SELECT COUNT(*) FROM "+tabla;
            SqlCommand contador = new SqlCommand(consulta, conectar.conexion);
            conteo = Convert.ToInt32(contador.ExecuteScalar());
            conectar.conexion.Close();
            return conteo;
        }
        private void IniciarGrid()
        {
            dtgvbusquedaresultados.DataSource = null;
            dtgvmostrarusuarios.DataSource = null;
            TodosLosUsuarios.Clear();
            string tabla = "Usuarios";
            int contar = contarRegistros(tabla);
            string consulta = "SELECT * FROM Usuarios";
            conectar.conexion.Open();
            SqlCommand consultar = new SqlCommand(consulta, conectar.conexion);
            SqlDataAdapter sda = new SqlDataAdapter(consultar);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conectar.conexion.Close();
            for(int x = 0; x < contar; x++)
            {
                ClassUsuarios personas = new ClassUsuarios();
                personas.Usuario = dt.Rows[x][0].ToString();
                personas.Password =  dt.Rows[x][1].ToString();
                personas.Nombre = dt.Rows[x][2].ToString();
                personas.Apellido = dt.Rows[x][3].ToString();
                personas.FechaNacimiento = dt.Rows[x][4].ToString();
                personas.DUI = dt.Rows[x][5].ToString();
                personas.TipoDeUsuario = dt.Rows[x][6].ToString();
                TodosLosUsuarios.Add(personas);
            }
            dtgvbusquedaresultados.DataSource = TodosLosUsuarios;
            dtgvmostrarusuarios.DataSource = TodosLosUsuarios;
        }
        private void BuscarEnGrid(int opcGrid, string nombreBusqueda)
        {

            if (opcGrid == 0)
            {
                dtgvbusquedaresultados.DataSource = null;

            }
            else if (opcGrid == 1)
            {
                dtgvmostrarusuarios.DataSource = null;
            }
        }

    }
        //------------------------------------------------------------
}
