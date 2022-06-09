using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lista_de_Paciente
{
    public class Conexion
    {
        public string cadena = "Server=tcp:clases-intec.database.windows.net,1433;Initial Catalog=Paciente;Persist Security Info=False;User ID=Victor;Password=051218Vm;";
        public SqlConnection con = new SqlConnection();

        public bool AbrirConexion()
        {
            try
            {
                con.ConnectionString = cadena;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            con.Open();
            return true;
        }
        public bool CerrarConexion()
        {
            con.Close();
            
            return true;
        }
}
}
