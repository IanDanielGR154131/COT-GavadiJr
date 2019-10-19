using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Ordenes_Trabajo
{
    public class Orden
    {
        private string id;
        private DateTime fecha;
        private bool estado; // True: significa en proceso - False: significa finalizada
        private string materialEspalda;
        private string nombreEquipo;

        public List<Elemento> listaElementos;
        public List<Bordado> listaBordados;
        public List<Jugador> listaJugadores;

        public Orden()
        {
            this.fecha = DateTime.Now;
            this.estado = true;
            this.materialEspalda = "";
            this.id = "";

            this.listaElementos = new List<Elemento>();
            this.listaBordados = new List<Bordado>();
            this.listaJugadores = new List<Jugador>();
        }

        public DateTime getFecha()
        {
            return this.fecha;
        }

        public bool getEstado()
        {
            return this.estado;
        }

        public void setMaterialEspalda(string materialEspalda)
        {
            this.materialEspalda = materialEspalda;
        }

        public string getMaterialEspalda()
        {
            return this.materialEspalda;
        }

        public void setNombreEquipo(string nombreEquipo)
        {
            this.nombreEquipo = nombreEquipo;
        }

        public string getNombreEquipo()
        {
            return this.nombreEquipo;
        }

        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }

        
    }
}
