using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Ordenes_Trabajo
{
    public class Usuario
    {
        private static bool permiso = true;

        public Usuario()
        {
            //Constructor vacio
        }

        //Logeo al sistema
        public bool login(string password)
        {
            string consulta = String.Format("Select tipo,contra from Usuarios where " +
                             "tipo = 1 and contra = '{0}'", password);
            SqlDataReader reader = ConexionBd.ejecConsulta(consulta);
            if (reader.HasRows)
            {
                reader.Read();
                permiso = true;
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }               
        }

        public void logout()
        {
            permiso = false;
        }

        public bool getPermiso()
        {
            return permiso;
        }
    }
}
