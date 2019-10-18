using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Ordenes_Trabajo
{
    public static class ConexionBd
    {
        public static string cadena;
        private static SqlConnection con;        
        public static SqlCommand command = new SqlCommand();
        public static SqlDataReader reader;
        
        public static bool conectar()
        {
            cadena = "Data Source = LAPTOP-TGJ8N1S4; Initial Catalog = GavadiJr;"+
                          "Integrated Security = True";
            con = new SqlConnection(cadena);
            try
            {
                con.Open();
                command.Connection = con;
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static SqlDataReader consultar(string consulta)
        {
            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = con;
            reader = command.ExecuteReader();
            return reader;
        }

        public static string registrar(string consulta)
        {
            command.CommandText = consulta;
            try
            {
                command.ExecuteNonQuery();
                return "Registro exitoso";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
