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

        //Registra el objeto orden en la base de datos
        private void registrarOrden()
        {
            //Inserción de los elementos basicos de la Orden
            string consulta = String.Format("INSERT INTO OrdenesDeTrabajo VALUES ('{0}', '{1}' , '{2}', {3} )",
                                            orden.getNombreEquipo(), orden.getFecha().ToString("yyyy/MM/dd"),
                                            orden.getMaterialEspalda(), "1");
            MessageBox.Show(ConexionBd.registrar(consulta));

            //Obtiene el id de la orden que se acaba de registar
            this.orden.setId(this.getUltimoIdDeOrden());

            //Inserción de los elementos del uniforme de la Orden
            foreach(Elemento e in this.orden.listaElementos)
            {
                consulta = String.Format("INSERT INTO ElementosEnOrdenDeTrabajo values ({0} , {1} , '{2}' , '{3}')",
                                        this.orden.getId(), e.getId(), e.getColor(), e.getTipo());
                MessageBox.Show(ConexionBd.registrar(consulta) + "Elementos");
            }
            this.orden.listaElementos.Clear();

            //Inserción de los bordados del uniforme
            foreach(Bordado b in this.orden.listaBordados)
            {
                consulta = String.Format("INSERT INTO BordadosEnOrdenDeTrabajo values ({0} , {1} , '{2}' , '{3}', {4})",
                                        this.orden.getId(), b.getId(), b.getColor(), b.getDescripcion(), b.getCantidad());
                MessageBox.Show(ConexionBd.registrar(consulta) + "Bordado");
            }
            this.orden.listaBordados.Clear();
        }

        //Obtiene el Id de la ultima orden registrada en la BD
        private string getUltimoIdDeOrden()
        {
            string consulta = "select top 1 id from OrdenesDeTrabajo order by id desc";
            SqlDataReader reader = ConexionBd.consultar(consulta);
            reader.Read();
            string id = reader["id"].ToString();
            reader.Close();
            return id;
        }

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
        
        //Método del boton Registrar
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if(!this.usuario.getPermiso())
            {
                MessageBox.Show("Usted no tiene permiso para realizar esta accion");
                return;
            }
            this.llenarOrden();
            this.registrarOrden();
        }

        //Método que limpia el formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        //¡¡¡ Funcion creada por error !!!
        private void label20_Click(object sender, EventArgs e)
        {
        }
    }
}
