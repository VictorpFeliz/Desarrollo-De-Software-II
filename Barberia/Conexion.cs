using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace Barberia_Cita
{
    public class Conexion
    {
        SqlConnection sqlCon;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public bool AbrirConexion()
        {
            try
            {
                string serverName = Dns.GetHostName();
                sqlCon = new SqlConnection("Data Source = " + serverName + "; Initial Catalog = Barberia; Integrated Security = True");
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    return true;
                    
                }
                sqlCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }    
        }
        public bool CerrarConexion()
        {
            sqlCon.Close();
            return true;
        }

        public string Cadena()
        {
            return sqlCon.ConnectionString;
        }
    }

}
