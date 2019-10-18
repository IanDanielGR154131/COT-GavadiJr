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
            this.permiso = true;
        }

        public bool login(string tipoDeUsuario, string password)
        {
            string consulta = String.Format("Select tipo,contra from Usuarios where " +
                             "tipo = {0} and contra = '{1}'" , tipoDeUsuario, password);
            SqlDataReader reader = ConexionBd.consultar(consulta);
            if (reader.HasRows)
            {
                reader.Read();
                bool tipo = Convert.ToBoolean(reader["tipo"]);
                this.permiso = tipo;
                reader.Close();
                return true;
            }
            else
                return false;
        }

        public bool getPermiso()
        {
            return this.permiso;
        }

        public void setPermiso(bool permiso)
        {
            this.permiso = permiso;
        }
    }
}
