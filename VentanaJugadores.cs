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
    public partial class VentanaJugadores : Form
    {
        private string idOrden;
        private string consultaSelect;
        private SqlDataAdapter adapterJugadores = new SqlDataAdapter();
        private SqlCommandBuilder builderJugadores = new SqlCommandBuilder();
        private DataTable tablaJugadores = new DataTable();

        public VentanaJugadores(string idOrden)
        {
            InitializeComponent();
            cbTam.SelectedIndex = 0; //Poner el foco en un elemento del ComboBox
            this.idOrden = idOrden;

            //Configuracion del DataAdapter
            this.consultaSelect = "SELECT id, idDeOrden as #Orden, numeroDeJugador as Num, " +
                                "apellido as Apellido, tam as Tamaño from Jugadores WHERE idDeOrden = {0}";
            this.consultaSelect = String.Format(consultaSelect, this.idOrden);
            ConexionBd.configAdapter(this.adapterJugadores, this.builderJugadores, this.consultaSelect);
            this.actualizarTablaJugadores();
            
            //Configuracion del DataGrid
            dataGridJugadores.DataSource = this.tablaJugadores;
            dataGridJugadores.Columns[0].Visible = false;
            dataGridJugadores.Columns[1].ReadOnly = true;
        }

        //Actualiza el DataGrid
        public void actualizarTablaJugadores()
        {
            this.tablaJugadores.Clear();
            this.adapterJugadores.Fill(tablaJugadores);
        }

        //Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ConexionBd.insertar(new Jugador(txtApellido.Text, txtNumero.Text, cbTam.Text), this.idOrden))
                MessageBox.Show("Error al agregar jugador");
            else
                this.actualizarTablaJugadores();
        }

        //Boton Guardar cambios
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                this.adapterJugadores.Update(this.tablaJugadores);
                MessageBox.Show("Sus cambios han quedado guardados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //Evento de error en el DataGrid
        private void dataGridJugadores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }
}

