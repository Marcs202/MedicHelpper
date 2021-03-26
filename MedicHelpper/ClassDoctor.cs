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
    class ClassDoctor : ClassUsuarios
    {
        //especialidades
        //General
        //Pediatría
        //Neumología
        //Gastroenterología

        private string cadena = "server=localhost;database=MedicHelpperBDD;integrated security = True";
        
        public SqlConnection AgDoc;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        
        private void Conexion()
        {
            AgDoc = new SqlConnection(cadena);
        }
        public ClassDoctor()
        {
            Conexion();
        }

        public bool AgregarCita(string sql)
        {
            try
            {
                AgDoc.Open();
                comando = new SqlCommand(sql, AgDoc);
                int i = comando.ExecuteNonQuery();
                AgDoc.Close();
                if (i > 0)
                {
                    return true;

                }
                else { return false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion a la base de datos"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AgDoc.Close();
                return false;
            }
            finally
            {
                AgDoc.Close();
                
            }
            

        }
        public void BuscarCita(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, AgDoc);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        
        public void BusquedaDeCita(TextBox txt_CODCITa, TextBox txt_codPaci, TextBox txt_fecha, TextBox txt_cita)
        {
            txt_CODCITa.Visible = true;
            txt_codPaci.Visible = true;
            txt_fecha.Visible = true;
            txt_cita.Visible = true;
            try
            {
                string selec = "select * from Cita where IdCita='" + txt_CODCITa.Text + "'";
                comando = new SqlCommand(selec, AgDoc);
                AgDoc.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read() == true)
                {
                    txt_codPaci.Text = dr["IdPacienteCita"].ToString();
                    txt_fecha.Text = dr["FechaCita"].ToString();
                    txt_cita.Text = dr["Estado"].ToString();
                }
                else
                {
                    DialogResult mensaje;
                    mensaje = MessageBox.Show("No se encontro la cita en la base de datos, error en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.BusquedaDeCita(txt_CODCITa, txt_codPaci, txt_fecha, txt_cita);
                AgDoc.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                AgDoc.Close();

            }
        }
        public void AtenderPaciente(int especialidadDoc, DataGridView dtg )
        {
            string querySelect = "select IdPacienteCita As  [Tarjeta del Paciente], Nombre, Apellido, Convert(date,FechaCita) As [Fecha de Cita] , Prioridad" +
                " From Cita cit " +
                " Inner Join Pacientes pa " +
                " ON pa.IdPaciente = cit.IdPacienteCita " +
                " where Especialidad = " + especialidadDoc +
                " and FechaCita = Convert(date,getdate())";
            string queryCantidad = " select( select count (*)  From Cita cit Inner Join Pacientes pa " +
               " ON pa.IdPaciente= cit.IdPacienteCita " +
               " where Especialidad = " + especialidadDoc + ") as [Cantidad]";
            ConexionSqlServer cn = new ConexionSqlServer();
            try
            {

                cn.abrir();
                SqlCommand cmSelect = new SqlCommand(queryCantidad, cn.conexion);
                int cantidad = Convert.ToInt32(cmSelect.ExecuteScalar());//se tiene la cantidad de datos que deberá tener el monticulo
                cn.cerrar();


                cn.abrir();
                SqlCommand cmPacientes = new SqlCommand(querySelect, cn.conexion);
                SqlDataReader reader = cmPacientes.ExecuteReader();
               
                Paciente[] pacien;
                pacien = new Paciente[cantidad];

                
                Heap heap = new Heap(cantidad);
                int iterador = 0;
                
                while (reader.Read())
                {
                    Paciente pa = new Paciente();
                    pa.TarjetaPaciente= Convert.ToString(reader["Tarjeta del Paciente"]);   
                    pa.Nombre= Convert.ToString(reader["Nombre"]);
                    pa.Apellido= Convert.ToString(reader["Apellido"]);
                    pa.FechaCita = Convert.ToString(reader["Fecha de Cita"]);
                    pa.Prioridad = Convert.ToInt32(reader["Prioridad"]);
                    pacien[iterador] = pa;
                    heap.Insertar(pacien[iterador]);
                    MessageBox.Show(pacien[iterador].Nombre.ToString());
                    iterador++;
                }
                
                cn.cerrar();
                List<Paciente> ordenado = new List<Paciente>();
                
                for (int i = 0; i < iterador; i++)
                {
                    ordenado.Add(heap.BorrarMin());
                }
                dtg.DataSource = ordenado;
            }
            catch (Exception)
            {
                cn.cerrar();
                MessageBox.Show("No se puede conectar a la base de datos");
                throw;
            }
            finally { cn.cerrar(); }

        }
    }
}