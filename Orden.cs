using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Ordenes_Trabajo
{
    class Orden
    {
        private DateTime fecha;
        private bool estado; // True significa en proceso - False significa finalizada
        private string materialEspalda;
        private string nombreEquipo;

        public Orden()
        {
            fecha = DateTime.Now;
            estado = true;
            materialEspalda = "";
        }

        public void setMaterialEspalda(string materialEspalda)
        {
            this.materialEspalda = materialEspalda;
        }
        public void setNombreEquipo(string nombreEquipo)
        {
            this.nombreEquipo = nombreEquipo;
        }

        public DateTime getFecha()
        {
            return this.fecha;
        }

        public bool getEstado()
        {
            return this.estado;
        }

        public string getMaterialEspalda()
        {
            return this.materialEspalda;
        }

        public string getNombreEquipo()
        {
            return this.nombreEquipo;
        }
    }
}
