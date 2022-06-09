using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Lista_de_Paciente
{
    public class IngresarPaciente
    {
        public bool Agregar(int pacienteID, string nombre, string apellido, string numero, string cedula, string correo, string provincia, DateTime fecha, string sexo )
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.AbrirConexion();
            if (resultado == false)
            {
                return false;
            }
            SqlCommand insertar = new SqlCommand("INSERT INTO InfoPaciente (PacienteID, Nombre, Apellido, Numero, Cedula, Correo, Provincia, FechaNacimiento, Sexo) VALUES ('" +pacienteID+ "', '" + nombre+"', '"+apellido+"', '"+numero+"', '"+cedula+"', '"+correo+"', '"+provincia+ "', '"+ fecha+ "' , '" +sexo+ "')",conexion.con);
            insertar.ExecuteNonQuery();
            conexion.CerrarConexion();
            return true;

           
        }
    }
}
