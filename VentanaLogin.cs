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

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(133, 133, 133);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton Login
        private void btnLogin_Click_1(object sender, EventArgs e)
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
