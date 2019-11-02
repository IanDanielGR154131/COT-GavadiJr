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
        public static SqlConnection con;        
        public static SqlCommand command = new SqlCommand();
        public static SqlDataReader reader;
        
        //Conecta con la base de datos
        public static bool conectar()
        {
            string cadenaMartin = "Data Source = LAPTOP-TGJ8N1S4; Initial Catalog = GavadiJr;" +
                          "Integrated Security = True";

            string cadenaIan = "Data Source = DESKTOP-F5KKISN\\SQLEXPRESS; Initial Catalog = GavadiJr;" +
                          "Integrated Security = True";

            cadena = cadenaIan;
            con = new SqlConnection(cadena);
            try
            {
                con.Open();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        //Ejecuta consultas que devuelven algun resultado (SELECT)
        public static SqlDataReader ejecConsulta(string consulta)
        {
            command.CommandText = consulta;
            reader = command.ExecuteReader();
            return reader;
        }

        //Ejecuta consultas que NO devuelven algun resultado (INSERT,UPDATE,DELETE)
        private static bool ejecConsultaNonQuery(string consulta)
        {
            command.CommandText = consulta;
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        //Registar Ordenes en la base de datos
        public static bool insertar(Orden orden)
        {

            //Inserción de los elementos basicos de la Orden
            string consulta = "EXEC insertOrden '{0}' , '{1}' , '{2}' , '{3}', {4}";
            consulta = String.Format(consulta, orden.getId(), orden.getNombreEquipo(), orden.getFecha().ToString("yyyy/MM/dd"),
                                    orden.getMaterialEspalda(), "1");

            if (!ConexionBd.ejecConsultaNonQuery(consulta))
                return false;

            //Si la orden es nueva, recupera su Id
            if(orden.getId() == "")
                orden.setId(getUltimoIdDeOrden());

            //Inserción de los elementos del uniforme de la Orden
            foreach (Elemento e in orden.listaElementos)
            {
                consulta = String.Format("INSERT INTO ElementosEnOrdenDeTrabajo values ({0} , {1} , '{2}' , '{3}')",
                                        orden.getId(), e.getId(), e.getColor(), e.getTipo());
                if (!ConexionBd.ejecConsultaNonQuery(consulta))
                    return false;
            }
            orden.listaElementos.Clear();

            //Inserción de los bordados del uniforme
            foreach (Bordado b in orden.listaBordados)
            {
                consulta = String.Format("INSERT INTO BordadosEnOrdenDeTrabajo values ({0} , {1} , '{2}' , '{3}', {4})",
                                        orden.getId(), b.getId(), b.getColor(), b.getDescripcion(), b.getCantidad());
                if (!ConexionBd.ejecConsultaNonQuery(consulta))
                    return false;
            }
            orden.listaBordados.Clear();

            return true;
        }

        //Inserta un jugador en la base de datos
        public static bool insertar(Jugador j, string idDeOrden)
        {
            string consulta = "INSERT INTO Jugadores VALUES ({0}, '{1}', '{2}', '{3}')";
            
            consulta = String.Format(consulta, idDeOrden, j.getNumero(), j.getApellido(), j.getTam());
            if (!ConexionBd.ejecConsultaNonQuery(consulta))
                return false;
            else
                return true;
        }

        public static bool insertar(string rutaImagen, string idDeOrden)
        {
            string consulta = "UPDATE OrdenesDeTrabajo SET rutaImagen = '{0}' WHERE id = {1}";
            consulta = String.Format(consulta, rutaImagen, idDeOrden);
            if (!ConexionBd.ejecConsultaNonQuery(consulta))
                return false;
            else
                return true;
        }


        public static bool eliminarElementos(Orden o)
        {
            string consulta = "DELETE FROM ElementosEnOrdenDeTrabajo WHERE idDeOrden = {0}";
            consulta = String.Format(consulta, o.getId());
            if (ejecConsultaNonQuery(consulta))
                return true;
            else
                return false;
        }

        public static bool eliminarBordados(Orden o)
        {
            string consulta = "DELETE FROM BordadosEnOrdenDeTrabajo WHERE idDeOrden = {0}";
            consulta = String.Format(consulta, o.getId());
            if (ejecConsultaNonQuery(consulta))
                return true;
            else
                return false;
        }

        public static bool finalizarOrden(string idOrden)
        {
            string consulta = "UPDATE OrdenesDeTrabajo set estado = 0 WHERE id = {0}";
            consulta = String.Format(consulta, idOrden);
            if (ejecConsultaNonQuery(consulta))
                return true;
            else
                return false;
        }

        public static bool eliminarJugadores(string idOrden)
        {
            string consulta = "DELETE FROM Jugadores WHERE idDeOrden = {0}";
            consulta = String.Format(consulta, idOrden);
            if (ejecConsultaNonQuery(consulta))
                return true;
            else
                return false;
        }

        public static bool configAdapter(SqlDataAdapter da, SqlCommandBuilder cb, string select)
        {
            da.SelectCommand = new SqlCommand(select, con);
            cb.DataAdapter = da;
            return true;
        }

        public static void actualizarAdapter(SqlDataAdapter da, DataTable dt)
        {
            dt.Clear();
            da.Fill(dt);
        }

        //Recupera el ultimo Id de Orden registrada (usado en el metodo "insertar(Orden)")
        private static string getUltimoIdDeOrden()
        {
            string consulta = "select top 1 id from OrdenesDeTrabajo order by id desc";
            SqlDataReader reader = ConexionBd.ejecConsulta(consulta);
            reader.Read();
            string id = reader["id"].ToString();
            reader.Close();
            return id;
        }

        //Llena una orden a partir de su id
        public static void llenarOrden(Orden orden)
        {
            //Informacion basica
            string consulta = "SELECT * FROM OrdenesDeTrabajo WHERE id = {0}";
            consulta = String.Format(consulta, orden.getId());
            ejecConsulta(consulta);
            if (!reader.HasRows)
                return;
            else
            {
                reader.Read();
                orden.setNombreEquipo(reader["nombreEquipo"].ToString());
                orden.setMaterialEspalda(reader["materialDeEspalda"].ToString());
                reader.Close();
            }

            //Elementos de la orden
            consulta = "SELECT * FROM ElementosEnOrdenDeTrabajo WHERE idDeOrden = {0}";
            consulta = String.Format(consulta, orden.getId());
            ejecConsulta(consulta);
            while (reader.Read())
            {
                orden.listaElementos.Add(new Elemento(reader[1].ToString(), reader[3].ToString(), reader[2].ToString()));
            }
            reader.Close();

            //Bordados de la orden
            consulta = "SELECT * FROM BordadosEnOrdenDeTrabajo WHERE idDeOrden = {0}";
            consulta = String.Format(consulta, orden.getId());
            ejecConsulta(consulta);
            while (reader.Read())
            {
                orden.listaBordados.Add(new Bordado(reader[1].ToString(), reader[3].ToString(), reader[2].ToString(), reader[4].ToString()));
            }
            reader.Close();
        }

    }
}
