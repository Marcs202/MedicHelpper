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
    class ClassFarmaceutico : ClassUsuarios
    {
        private string cadena = "server=localhost;database=MedicHelpperBDD;integrated security = True";
        //LAPTOP-B09UIF2D\\MSSQLSERVERDEV
        public SqlConnection far;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        private SqlCommand cmd2;

        private void Conectar()
        {
            far = new SqlConnection(cadena);
        }

        public ClassFarmaceutico()
        {
            Conectar();
        }
        public DataTable MostrarMedicamento()
        {
            SqlDataAdapter da = new SqlDataAdapter("BMD_Medicamento", far);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable BusquedaReceta(string idReceta)
        {
            DataTable dt = new DataTable();
            if ( idReceta.Equals(""))
            {
                MessageBox.Show("Ingrese datos en el campo","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return dt;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CodReceta, Descripcion " +
                "FROM Consulta  WHERE CodReceta =" + idReceta, far);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                return dt;
            }
            
        }
        public void BusquedaMedicamentos(TextBox txtBuscarMed,DataGridView dtg)
        {
            try
            {
                string selec = "SELECT * FROM Medicamentos WHERE [Codigo de Medicamento] = @idMedi";
                cmd2 = new SqlCommand(selec, far);                
                cmd2.Parameters.Add(new SqlParameter("@idMedi", SqlDbType.Int));
                cmd2.Parameters["@idMedi"].Value = Convert.ToInt32(txtBuscarMed.Text);
                far.Open();
                SqlDataReader dr = cmd2.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtg.DataSource = dt;
                far.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Medicamento no encontrado o no ha sido ingresado, error en la busqueda."   , "Reintentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                far.Close();
            }
            finally
            {
                far.Close();
            }
        }
        public bool  AñadirMedicamentos(string sql)
        {
            far.Open();
            comando = new SqlCommand(sql, far);
            int i = comando.ExecuteNonQuery();
            far.Close();
            if (i > 0) { return true; }else { return false; }
            
        }
      
        public void DespachoMedicamento(string CodigoMedicamento,string Cantidad,DataGridView dtg)
        {
            
            far.Open();
            try
            {
                string Sql = "UPDATE Medicamentos SET  Cantidad = Cantidad - " + Cantidad + " WHERE [Codigo de Medicamento] = " + CodigoMedicamento;
                comando = new SqlCommand(Sql, far);
                comando.ExecuteNonQuery();
                far.Close();
                MessageBox.Show("Retiro de medicina completado","Retiro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                string selec = "SELECT * FROM Medicamentos ";
                cmd2 = new SqlCommand(selec, far);
                far.Open();
                SqlDataReader dr = cmd2.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtg.DataSource = dt;
                far.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Retiro de medicina no realizado", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                far.Close();
            }
            finally
            {
                far.Close();
            }
            
        }
    }
}
