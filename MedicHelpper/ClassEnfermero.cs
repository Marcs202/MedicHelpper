
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MedicHelpper
{
    class ClassEnfermero : ClassUsuarios
    {


        private string cadena = "server=localhost;database=MedicHelpperBDD;integrated security = True";
        //LAPTOP-B09UIF2D\\MSSQLSERVERDEV
        public SqlConnection conexion;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        
        public void conectar()
        {
            conexion = new SqlConnection(cadena);            
        }
        public ClassEnfermero()
        {
            conexion = new SqlConnection(cadena);
            conectar();            
        }
        public void VerificarCodigoCita(DateTimePicker fechaCita, string nTarjeta,Label lbl, TextBox txt)
        {
            try
            {

                int año = fechaCita.Value.Year;
                int mes = fechaCita.Value.Month;
                int dia = fechaCita.Value.Day;
                int Hora = fechaCita.Value.Hour;
                int Minuto = fechaCita.Value.Minute;
                string fecha = dia.ToString() + "-" + mes.ToString() + "-" + año.ToString() + " " + Hora.ToString() + ":" + Minuto.ToString();
                string seleccion = "SELECT idCita FROM Cita WHERE FechaCita = @fecha AND IdPacienteCita =  @idPacien AND Estado = @estado";
                comando = new SqlCommand(seleccion, conexion);
                comando.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
                comando.Parameters["@fecha"].Value = fecha;
                comando.Parameters.Add(new SqlParameter("@idPacien", SqlDbType.Char, 6));
                comando.Parameters["@idPacien"].Value = nTarjeta;
                comando.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int));
                comando.Parameters["@estado"].Value = 1;
                conexion.Open();
                txt.Visible = true;
                lbl.Visible = true;
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    txt.Text = registro["idCita"].ToString();
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                DialogResult mensaje;
                mensaje = MessageBox.Show("No se encontro la cita en la base de datos, error en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (mensaje == DialogResult.OK)
                {
                    txt.Visible = false;
                    lbl.Visible = false;
                    fechaCita.Value = System.DateTime.Today;
                }
            }
            finally
            {
                conexion.Close();
            }
        }
        public void AgregarCita(DateTimePicker fechaCita, string nTarjeta, Label lbl, TextBox txt)
        {
            try
            {
                conexion.Open();
                int estado = 1;
                int año = fechaCita.Value.Year;
                int mes = fechaCita.Value.Month;
                int dia = fechaCita.Value.Day;
                int Hora = fechaCita.Value.Hour;
                int Minuto = fechaCita.Value.Minute;
                string fecha = dia.ToString() + "-" + mes.ToString() + "-" + año.ToString() + " " + Hora.ToString()+":"+Minuto.ToString();
                string insertar;
                insertar = "INSERT INTO Cita (IdPacienteCita,FechaCita,Estado)";
                insertar+="VALUES (@idPaciente,@fecha,@estado)";
                comando = new SqlCommand(insertar, conexion);
                comando.Parameters.Add(new SqlParameter("@idPaciente", SqlDbType.Char, 6));
                comando.Parameters["@idPaciente"].Value = nTarjeta;
                comando.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
                comando.Parameters["@fecha"].Value = fecha;
                comando.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int));
                comando.Parameters["@estado"].Value = estado;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Cita añadida al sistema exitosamente", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.VerificarCodigoCita(fechaCita, nTarjeta, lbl, txt);
            }
            catch (Exception ex)
            {
                if (ex.ToString() == "Duplicate Data")
                {
                    MessageBox.Show("Cita no ingresado,este paciente ya tiene una cita para el mismo momento ", "Reintentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cita no ingresada,Vuelva a intentar ingresar con los formatos correctos"+ex , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            finally
            {
                conexion.Close();
            }
        }
        public void AgregarPaciente(string id, string nombre, string apellido, string fechaNacimiento)
        {
            try
            {
                conexion.Open();
                string insertar;
                insertar = "INSERT INTO Pacientes (IdPaciente,Nombre,Apellido,FechaDeNacimiento)";
                insertar += "VALUES(@id,@nombre,@apellido,@fechaNacimiento)";
                comando = new SqlCommand(insertar, conexion);
                comando.Parameters.Add(new SqlParameter("@id", SqlDbType.Char,6));
                comando.Parameters["@id"].Value = id;
                comando.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 75));
                comando.Parameters["@nombre"].Value = nombre;
                comando.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar, 75));
                comando.Parameters["@apellido"].Value = apellido;
                comando.Parameters.Add(new SqlParameter("@fechaNacimiento", SqlDbType.Date));
                comando.Parameters["@fechaNacimiento"].Value = fechaNacimiento;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Paciente añadido al sistema exitosamente", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Paciente no ingresado, error en la insercion ", "Reintentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                conexion.Close();
            }
        }
        public void EditarPaciente( TextBox txtNombre, TextBox txtApellido, TextBox txtFechaBirth, TextBox NTarjeta)
        {            
            string Consulta = "UPDATE Pacientes SET Nombre = @nombre, Apellido = @apellido, FechaDeNacimiento = @fecha WHERE IdPaciente = @idPaciente";
            conexion.Open();
            SqlCommand comando = new SqlCommand(Consulta, conexion);
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@apellido", txtApellido.Text);
            comando.Parameters.AddWithValue("@fecha", txtFechaBirth.Text);
            comando.Parameters.AddWithValue("@idPaciente", NTarjeta.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Paciente actualizado exitosamente", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void BuscarPaciente(TextBox NTarjeta, TextBox txtNombre, TextBox txtApellido, TextBox txtFechaBirth, Button btnEdit, Label lblName, Label lblLastName, Label lblBirth, PictureBox pictureBox2)
        {

            try
            {
                string selec = "SELECT * FROM Pacientes WHERE IdPaciente =@idPaciente";
                comando = new SqlCommand(selec, conexion);
                comando.Parameters.AddWithValue("@idPaciente", NTarjeta.Text);
                conexion.Open();
                SqlDataReader Buscar = comando.ExecuteReader();
                if (Buscar.Read())
                {
                    txtNombre.Text = Buscar["Nombre"].ToString();
                    txtApellido.Text = Buscar["Apellido"].ToString();
                    txtFechaBirth.Text = Buscar["FechaDeNacimiento"].ToString();
                    lblName.Visible = true;
                    lblLastName.Visible = true;
                    lblBirth.Visible = true;
                    txtNombre.Visible = true;
                    txtApellido.Visible = true;
                    txtFechaBirth.Visible = true;
                    btnEdit.Visible = true;
                    pictureBox2.Visible = true;
                    conexion.Close();
                }
                else
                {
                    DialogResult mensaje;
                    mensaje = MessageBox.Show("No se encontro el paciente en la Base de Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Close();

            }
                catch (Exception ex)
                {
                    MessageBox.Show("Paciente no encontrado o no ha sido ingresado, error en la busqueda.", "Reintentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable MostrarPaciente()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MostrarPacientes", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}