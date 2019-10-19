using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Ordenes_Trabajo
{
    public class Jugador
    {
        private string apellido;
        private string numero;
        private string tam;

        public Jugador()
        {
            this.apellido = "";
            this.numero = "";
            this.tam = "";
        }

        public Jugador(string apellido, string numero, string tam)
        {
            this.apellido = apellido;
            this.numero = numero;
            this.tam = tam;
        }
        
        public string getApellido()
        {
            return this.apellido;
        }

        public string getNumero()
        {
            return this.numero;
        }

        public string getTam()
        {
            return this.tam;
        }
    }
}
