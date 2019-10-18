using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Ordenes_Trabajo
{
    public class Elemento
    {
        private string id;
        private string tipo;
        private string color;

        public Elemento()
        {
            this.id = "";
            this.tipo = "";
            this.color = "";
        }
        public Elemento(string id, string tipo, string color)
        {
            this.id = id;
            this.tipo = tipo;
            this.color = color;
        }

        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return this.color;
        }
    }
}
