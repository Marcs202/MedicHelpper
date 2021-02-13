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

        private string cadena = "server=localhost;database=MedicHelpperBDD;integrated security = True;";
        //LAPTOP-B09UIF2D\\MSSQLSERVERDEV
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
            catch (Exception)
            {
                MessageBox.Show("Error en la conexion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}