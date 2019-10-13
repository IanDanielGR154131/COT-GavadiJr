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
    public partial class VentanaRegistrar : Form 
    {
        private Orden orden;
        private ConexionBd conexion;
        
        public VentanaRegistrar()
        {
            InitializeComponent();
            //orden = new Orden();
            //conexion = new ConexionBd(); // Comeantado para trabajo en UI
            //conexion.conectar();
        }

        private void llenarOrden()
        {
            this.orden.setNombreEquipo(txtNombreEquipo.Text);
            this.orden.setMaterialEspalda(txtMaterialEspalda.Text);
        }

        private void registarOrden()
        {
            //Coneversion del estado "bool" de la orden a string para su uso en la consulta
            string estado;
            if (orden.getEstado())
                estado = "1";
            else
                estado = "0";

            string consulta = String.Format("insert into OrdenesDeTrabajo values ('{0}', '{1}' , '{2}', {3} )",
                                            orden.getNombreEquipo(), orden.getFecha().ToString("yyyy/MM/dd"),
                                            orden.getMaterialEspalda(), estado);
            MessageBox.Show(this.conexion.registrar(consulta));
        }

        //¡¡¡ Funcion creada por error !!!
        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            this.llenarOrden();
            this.registarOrden();
        }
    }
}
