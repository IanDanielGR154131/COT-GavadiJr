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
            ConexionBd.insertar(this.orden);
            VentanaJugadores ventanaJugadores = new VentanaJugadores(this.orden);
            ventanaJugadores.ShowDialog();
            this.limpiar();
        }

        //Botón limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
    }
}
