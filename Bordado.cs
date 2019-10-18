using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Ordenes_Trabajo
{
    public class Bordado
    {
        private string id;
        private string descripcion;
        private string color;
        private string cantidad;

        public Bordado()
        {
            this.id = "";
            this.descripcion = "";
            this.color = "";
            this.cantidad = "";
        }

        public Bordado(string id, string descripcion, string color, string cantidad)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.color = color;
            this.cantidad = cantidad;
        }

        public void setId(string id)
        {
            this.id = id;
        }
        
        public string getId()
        {
            return this.id;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return this.color;
        }

        public void setCantidad(string cantidad)
        {
            this.cantidad = cantidad;
        }

        public string getCantidad()
        {
            return this.cantidad;
        }
    }
}
