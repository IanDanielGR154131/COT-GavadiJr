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
        private bool permiso;

        public Usuario()
        {
            this.permiso = false;
        }

        public bool login(ConexionBd conexion, string tipoDeUsuario, string password)
        {
            string consulta = String.Format("Select tipo,contra from Usuarios where " +
                             "tipo = {0} and contra = '{1}'" , tipoDeUsuario, password);
            SqlDataReader reader = conexion.consultar(consulta);
            if (reader.HasRows)
            {
                reader.Read();
                bool tipo = Convert.ToBoolean(reader["tipo"]);
                this.permiso = tipo;
                reader.Close();
                return tipo;
            }
            else
                return false;
        }

        public bool getPermiso()
        {
            return this.permiso;
        }
    }
}
