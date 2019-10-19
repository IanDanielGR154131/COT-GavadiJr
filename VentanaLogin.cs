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
    public partial class VentanaLogin : Form
    {
        Usuario usuario;

        public VentanaLogin(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        //Boton Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.usuario.login(txtPassword.Text))
            {
                MessageBox.Show("Usted ha iniciado sesión");
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña equivocada");
                txtPassword.Clear();
            }            
        }
    }
}
