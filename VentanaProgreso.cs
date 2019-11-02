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
    public partial class VentanaProgreso : Form
    {
        private string consultaSelect;
        private SqlDataAdapter adapterOrdenes = new SqlDataAdapter();
        private SqlCommandBuilder builderOrdenes = new SqlCommandBuilder();
        private DataTable tablaOrdenes = new DataTable();
        private SqlCommand commandOrdenes = new SqlCommand();

        public VentanaProgreso()
        {
            InitializeComponent();
            this.commandOrdenes.Connection = ConexionBd.con;

            //Configuracion del adapter
            this.consultaSelect = "SELECT * FROM OrdenesDeTrabajo WHERE estado = 1";
            ConexionBd.configAdapter(this.adapterOrdenes, this.builderOrdenes, this.consultaSelect);
            ConexionBd.actualizarAdapter(this.adapterOrdenes, this.tablaOrdenes);

            //Configuración del DataGrid
            dataGridOrdenes.DataSource = this.tablaOrdenes;
        }

        //Boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Orden orden = new Orden();
            orden.setId(dataGridOrdenes.CurrentRow.Cells[0].Value.ToString());
            ConexionBd.llenarOrden(orden);
            VentanaRegistrar vn = new VentanaRegistrar(orden);
            vn.Show();
        }

        //Boton finalizar
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string idDeOrden = dataGridOrdenes.CurrentRow.Cells[0].Value.ToString();
            if (ConexionBd.finalizarOrden(idDeOrden))
            {
                if (ConexionBd.eliminarJugadores(idDeOrden))
                {
                    OpenFileDialog buscador = new OpenFileDialog();
                    buscador.ShowDialog();
                    if (ConexionBd.insertar(buscador.FileName, idDeOrden))
                        ConexionBd.actualizarAdapter(adapterOrdenes, tablaOrdenes);
                }
                else
                    MessageBox.Show("Problema con eliminacion de jugadores");
            }
            else
                MessageBox.Show("Problema al finalizar la orden");


        }

        //Boton generar reporte
        private void btnReporte_Click(object sender, EventArgs e)
        {
        }

        //Boton agregar jugadores
        private void btnJugadores_Click(object sender, EventArgs e)
        {
            string idDeOrden = dataGridOrdenes.CurrentRow.Cells[0].Value.ToString();
            VentanaJugadores ventanaJugadores = new VentanaJugadores(idDeOrden);
            ventanaJugadores.ShowDialog();
        }

        //Boton recargar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ConexionBd.actualizarAdapter(adapterOrdenes, tablaOrdenes);
        }

        //Evento de la eleminacion de un renglon del Data Grid
        private void dataGridOrdenes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            adapterOrdenes.Update(tablaOrdenes);
        }
    }
}
