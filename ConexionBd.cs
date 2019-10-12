using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Ordenes_Trabajo
{
    public class ConexionBd
    {
        private SqlConnection con;
        private string cadena;
        
        public ConexionBd()
        {
            this.cadena = "";
        }

        public bool conectar()
        {
            this.cadena = "Data Source = LAPTOP-TGJ8N1S4; Initial Catalog = GavadiJr;"+
                          "Integrated Security = True";
            this.con = new SqlConnection(this.cadena);
            try
            {
                this.con.Open();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public SqlDataReader consultar(string consulta)
        {
            SqlCommand command = new SqlCommand(consulta, this.con);
            command.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            return reader;
        }

        public string registrar(string consulta)
        {
            SqlCommand command = new SqlCommand(consulta, this.con);
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
