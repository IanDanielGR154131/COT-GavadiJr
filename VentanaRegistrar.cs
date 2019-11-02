using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Ordenes_Trabajo
{
    public partial class VentanaRegistrar : Form  
    {
        private Orden orden;
        private Usuario usuario;
        
        public VentanaRegistrar()
        {
            orden = new Orden();
            usuario = new Usuario();
            InitializeComponent();
        }

        public VentanaRegistrar(Orden o)
        {
            InitializeComponent();
            this.usuario = new Usuario();
            this.orden = o; 
            this.llenarForm();          
        }

        //Llena el objeto orden
        private void llenarOrden()
        {
            //Principal   
            this.orden.setMaterialEspalda(txtMaterialEspalda.Text);
            this.orden.setNombreEquipo(txtNombreEquipo.Text);

            //Elementos
            if (txtTipoLogo.Text != "")
                orden.listaElementos.Add(new Elemento("1", txtTipoLogo.Text, txtColorLogo.Text));
            if(txtTipoNumEspalda.Text != "")
                orden.listaElementos.Add(new Elemento("2", txtTipoNumEspalda.Text, txtColorNumEspalda.Text));
            if (txtTipoNumFrente.Text != "")
                orden.listaElementos.Add(new Elemento("3", txtTipoNumFrente.Text, txtColorNumFrente.Text));
            if (txtTipoNumPantalonera.Text != "")
                orden.listaElementos.Add(new Elemento("4", txtTipoNumPantalonera.Text, txtColorNumPantalonera.Text));
            if (txtTipoApellidos.Text != "")
                orden.listaElementos.Add(new Elemento("5", txtTipoApellidos.Text, txtColorApellidos.Text));

            //Bordados
            if (txtTipoGorra.Text != "")
                orden.listaBordados.Add(new Bordado("1", txtTipoGorra.Text, txtColorGorra.Text, txtCantGorra.Text));
            if (txtTipoPecho.Text != "")
                orden.listaBordados.Add(new Bordado("2", txtTipoPecho.Text, txtColorPecho.Text, txtCantPecho.Text));
            if (txtTipoManga.Text != "")
                orden.listaBordados.Add(new Bordado("3", txtTipoManga.Text, txtColorManga.Text, txtCantManga.Text));
            if (txtTipoTrabilla.Text != "")
                orden.listaBordados.Add(new Bordado("4", txtTipoTrabilla.Text, txtColorTrabilla.Text, txtCantTrabilla.Text));
        }

        private void llenarForm()
        {
            txtNombreEquipo.Text = this.orden.getNombreEquipo();
            txtMaterialEspalda.Text = this.orden.getMaterialEspalda();

            foreach (Elemento e in orden.listaElementos)
            {
                switch (e.getId())
                {
                    case "1":
                        txtTipoLogo.Text = e.getTipo();
                        txtColorLogo.Text = e.getColor();
                        break;
                    case "2":
                        txtTipoNumEspalda.Text = e.getTipo();
                        txtColorNumEspalda.Text = e.getColor();
                        break;
                    case "3":
                        txtTipoNumFrente.Text = e.getTipo();
                        txtColorNumFrente.Text = e.getColor();
                        break;
                    case "4":
                        txtTipoNumPantalonera.Text = e.getTipo();
                        txtColorNumPantalonera.Text = e.getColor();
                        break;
                    case "5":
                        txtTipoApellidos.Text = e.getTipo();
                        txtColorApellidos.Text = e.getColor();
                        break;
                }
            }
            this.orden.listaElementos.Clear();

            foreach (Bordado b in orden.listaBordados)
            {
                switch (b.getId())
                {
                    case "1":
                        txtTipoGorra.Text = b.getDescripcion();
                        txtColorGorra.Text = b.getColor();
                        txtCantGorra.Text = b.getCantidad();
                        break;
                    case "2":
                        txtTipoPecho.Text = b.getDescripcion();
                        txtColorPecho.Text = b.getColor();
                        txtCantPecho.Text = b.getCantidad();
                        break;
                    case "3":
                        txtTipoManga.Text = b.getDescripcion();
                        txtColorManga.Text = b.getColor();
                        txtCantManga.Text = b.getCantidad();
                        break;
                    case "4":
                        txtTipoTrabilla.Text = b.getDescripcion();
                        txtColorTrabilla.Text = b.getColor();
                        txtCantTrabilla.Text = b.getCantidad();
                        break;
                }
            }
            this.orden.listaBordados.Clear();
        }

        //Colocar campos del fomulario en blanco
        private void limpiar()
        {
            txtNombreEquipo.Clear();
            txtMaterialEspalda.Clear();
            txtTipoLogo.Clear();
            txtColorLogo.Clear();
            txtTipoNumEspalda.Clear();
            txtColorNumEspalda.Clear();
            txtTipoNumFrente.Clear();
            txtColorNumFrente.Clear();
            txtTipoNumPantalonera.Clear();
            txtColorNumPantalonera.Clear();
            txtTipoApellidos.Clear();
            txtColorApellidos.Clear();

            txtTipoGorra.Clear();
            txtColorGorra.Clear();
            txtCantGorra.Clear();
            txtTipoPecho.Clear();
            txtColorPecho.Clear();
            txtCantPecho.Clear();
            txtTipoManga.Clear();
            txtColorManga.Clear();
            txtCantManga.Clear();
            txtTipoTrabilla.Clear();
            txtColorTrabilla.Clear();
            txtCantTrabilla.Clear();
        }
        
        //Botón Registrar
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if(!this.usuario.getPermiso())
            {
                MessageBox.Show("Usted no tiene permiso para realizar esta acción");
                return;
            }
            this.llenarOrden();

            //Si es una orden nueva, muestra la ventana de jugadores
            if (this.orden.getId() == "")
            {
                if (!ConexionBd.insertar(this.orden))
                    MessageBox.Show("Error al insertar orden, intentelo de nuevo");
                VentanaJugadores ventanaJugadores = new VentanaJugadores(this.orden.getId());
                ventanaJugadores.ShowDialog();
                this.orden.setId("");
                this.limpiar();
            }
            //Si es una orden ya existente, no muestra la ventana jugadores
            else
            {
                //Se eliminan los elementos y bordados anteriores de la orden para dejarla "limpia"
                if (!ConexionBd.eliminarElementos(this.orden))
                    MessageBox.Show("Error al eliminar elemntos");
                if (!ConexionBd.eliminarBordados(this.orden))
                    MessageBox.Show("Error al eliminar bordados");

                //Se actualiza/reeinserta la nueva orden
                if (!ConexionBd.insertar(this.orden))
                    MessageBox.Show("Error al insertar orden, intentelo de nuevo");
                else
                    MessageBox.Show("Sus cambios han sido guardados");
            }
        }

        //Botón limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
    }
}
