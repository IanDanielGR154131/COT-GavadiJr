﻿using System;
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

        //Evento de la eleminacion de un renglon del Data Grid
        private void dataGridOrdenes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            adapterOrdenes.Update(tablaOrdenes);
        }

        //Boton recargar
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ConexionBd.actualizarAdapter(adapterOrdenes, tablaOrdenes);
        }

        //Boton agregar jugadores
        private void btnJugadores_Click_1(object sender, EventArgs e)
        {
            string idDeOrden = dataGridOrdenes.CurrentRow.Cells[0].Value.ToString();
            VentanaJugadores ventanaJugadores = new VentanaJugadores(idDeOrden);
            ventanaJugadores.ShowDialog();
        }
         //Boton exportar
        private void btnExportar_Click(object sender, EventArgs e)
        {
            string idDeOrden = dataGridOrdenes.CurrentRow.Cells[0].Value.ToString();
            int cate;
            cate = Convert.ToInt32(idDeOrden);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1, cate);
            this.JugadoresTableAdapter.Fill(this.DataSet1.Jugadores,cate);
            this.BordadosEnOrdenDetrabajoTableAdapter.Fill(this.DataSet1.BordadosEnOrdenDetrabajo,cate);
            this.ElementosEnOrdenDeTrabajoTableAdapter.Fill(this.DataSet1.ElementosEnOrdenDeTrabajo,cate);
            this.reportViewer1.RefreshReport();
          
            

        }
         
        //Boton Finalizar
        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            string idDeOrden = dataGridOrdenes.CurrentRow.Cells[0].Value.ToString();
            if (ConexionBd.finalizarOrden(idDeOrden))
            {
                if (ConexionBd.eliminarJugadores(idDeOrden))
                {
                    OpenFileDialog buscador = new OpenFileDialog();
                    buscador.ShowDialog();
                    if (ConexionBd.insertar(buscador.FileName, idDeOrden))
                        ConexionBd.actualizarAdapter(this.adapterOrdenes, this.tablaOrdenes);
                    else
                        MessageBox.Show("Error al cargar imagen");
                }
                else
                    MessageBox.Show("Problema con eliminacion de jugadores");
            }
            else
                MessageBox.Show("Problema al finalizar la orden");
        }

        //Boton modificar
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Orden orden = new Orden();
            orden.setId(dataGridOrdenes.CurrentRow.Cells[0].Value.ToString());
            ConexionBd.llenarOrden(orden);
            VentanaRegistrar vn = new VentanaRegistrar(orden);
            vn.Show();
        }

        private void VentanaProgreso_Load(object sender, EventArgs e)
        {
           

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
