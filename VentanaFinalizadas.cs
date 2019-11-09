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
    public partial class VentanaFinalizadas : Form
    {
        private string consultaSelect;
        private SqlDataAdapter adapterOrdenes = new SqlDataAdapter();
        private SqlCommandBuilder builderOrdenes = new SqlCommandBuilder();
        private DataTable tablaOrdenes = new DataTable();
        private SqlCommand commandOrdenes = new SqlCommand();

        public VentanaFinalizadas()
        {
            InitializeComponent();

            this.consultaSelect = "SELECT TOP 15 * FROM OrdenesDeTrabajo WHERE estado = 0";
            
            //Configuracion del command (Este cambia la consulta SELECT del adapter)
            this.commandOrdenes.Connection = ConexionBd.con;
            this.commandOrdenes.CommandType = CommandType.Text;
            this.commandOrdenes.CommandText = this.consultaSelect;

            //Configuracion del adapter            
            this.adapterOrdenes.SelectCommand = commandOrdenes;
            this.builderOrdenes.DataAdapter = this.adapterOrdenes;
            ConexionBd.actualizarAdapter(this.adapterOrdenes, this.tablaOrdenes);

            //Configuración del DataGrid
            dataGridOrdenes.DataSource = this.tablaOrdenes;
        }

        //Checkbox fecha
        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            datePickerInicio.Enabled = !datePickerInicio.Enabled;
            datePickerFin.Enabled = !datePickerFin.Enabled;
        }

        //DataGrid click
        private void dataGridOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string rutaImagen = dataGridOrdenes.CurrentRow.Cells[5].Value.ToString();
            picturBox.ImageLocation = rutaImagen;
        }

        //Boton proceso
        private void btnProceso_Click_1(object sender, EventArgs e)
        {
            string idDeOrden = dataGridOrdenes.CurrentRow.Cells[0].Value.ToString();
            if (ConexionBd.ponerEnProceso(idDeOrden))
                MessageBox.Show("La orden " + idDeOrden + " está nuevamente en proceso");
            else
                MessageBox.Show("No se ha podido poner en proceso la orden " + idDeOrden);
            ConexionBd.actualizarAdapter(adapterOrdenes, tablaOrdenes);
            picturBox.ImageLocation = "";
        }

        //Boton buscar
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.consultaSelect = "SELECT * FROM OrdenesDeTrabajo WHERE estado = 0 ";

            if (checkBoxFecha.Checked)
            {
                string fechaInicio = datePickerInicio.Value.ToString("yyyy/MM/dd");
                string fechaFin = datePickerFin.Value.ToString("yyyy/MM/dd");
                this.consultaSelect = this.consultaSelect + "AND fecha >= '{0}' AND fecha <= '{1}' ";
                this.consultaSelect = String.Format(this.consultaSelect, fechaInicio, fechaFin);
            }
            if (!String.IsNullOrEmpty(txtBusqueda.Text))
            {
                this.consultaSelect = this.consultaSelect + "AND nombreEquipo = '{0}' ";
                this.consultaSelect = String.Format(this.consultaSelect, txtBusqueda.Text);
            }
            if (!checkBoxFecha.Checked && String.IsNullOrEmpty(txtBusqueda.Text))
            {
                MessageBox.Show("Ingresa al menos nombre de equipo ó rango de fechas");
                return;
            }

            this.commandOrdenes.CommandText = this.consultaSelect;
            ConexionBd.actualizarAdapter(this.adapterOrdenes, this.tablaOrdenes);
        }
    }
}
