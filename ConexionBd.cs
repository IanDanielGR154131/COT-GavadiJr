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
        
        //Conecta con la base de datos
        public static bool conectar()
        {
            cadena = "Data Source = LAPTOP-TGJ8N1S4; Initial Catalog = GavadiJr;"+
                          "Integrated Security = True";
            con = new SqlConnection(cadena);
            try
            {
                con.Open();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                return true;
            }
            catch(Exception ex)
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
            catch(Exception)
            {
                return false;
            }
        }

        //Registar Ordenes en la base de datos
        public static bool insertar(Orden orden)
        {

            //Inserción de los elementos basicos de la Orden
            string consulta = String.Format("INSERT INTO OrdenesDeTrabajo VALUES ('{0}', '{1}' , '{2}', {3} )",
                                            orden.getNombreEquipo(), orden.getFecha().ToString("yyyy/MM/dd"),
                                            orden.getMaterialEspalda(), "1");
            if (!ConexionBd.ejecConsultaNonQuery(consulta))
                return false;

            //Obtiene el id de la orden que se acaba de registar
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

        //Inserta una lista de jugadores en la base de datos
        public static bool insertar(List<Jugador> listaJugadores, string id)
        {
            string consulta = "";
            foreach(Jugador j in listaJugadores)
            {
                consulta = String.Format("INSERT INTO Jugadores VALUES ({0}, {1}, '{2}', '{3}')" ,
                                        id, j.getNumero(), j.getApellido(), j.getTam());
                if (!ConexionBd.ejecConsultaNonQuery(consulta))
                {
                    listaJugadores.Clear();
                    return false;
                }
                    
            }
            listaJugadores.Clear();
            return true;
        }


    }
}
