using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Ordenes_Trabajo
{
    public partial class VentanaJugadores : Form
    {
        private Orden orden;

        public VentanaJugadores(Orden orden)
        {
            InitializeComponent();
            cbTam.SelectedIndex = 0; //Poner el foco en un elemento del ComboBox
            this.orden = orden;
        }

        //Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            this.orden.listaJugadores.Add(new Jugador(txtApellido.Text, txtNumero.Text, cbTam.Text));
            lbContadorDeJugadores.Text = this.orden.listaJugadores.Count.ToString();
        }

        //Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ConexionBd.insertar(this.orden.listaJugadores, this.orden.getId()))
                MessageBox.Show("Jugadores guardados con éxito");
            else
                MessageBox.Show("Error al guardar jugadores");
            this.Dispose();
        }
    }
}
