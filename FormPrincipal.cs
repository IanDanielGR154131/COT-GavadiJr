using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Ordenes_Trabajo
{
    public partial class formPrincipal : Form
    {
        private Usuario usuario;
        private VentanaLogin ventanaLogin;
        private VentanaProgreso ventanaProgreso;

        public formPrincipal()
        {
            InitializeComponent();
            if (!ConexionBd.conectar()) 
                MessageBox.Show("Error: No se ha podido conectar con la base de datos");
            this.usuario = new Usuario();

            this.ventanaProgreso = new VentanaProgreso();
        }

        #region Funcionalidades ventana principal
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Maximizar y restaurar ventanas
        private bool maximizada = false;
        private const int widthNormal = 1200;
        private const int heightNormal = 600;

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (maximizada)
            {
                this.Size = new Size(widthNormal, heightNormal);
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                maximizada = false;
            }
            else
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                maximizada = true;
            }
           
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        // ABRE FORMULARIOS DENTRO DEL PANEL FORMULARIOS
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<MiForm>().FirstOrDefault(); // Busca el formulario
            // Si el form no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else // Si ya existe un formulario
            {
                formulario.BringToFront();
            }
        }

        private void desactivarPanelesActive()
        {
            panelBtn1Active.Visible = false;
            panelBtn2Active.Visible = false;
            panelBtn3Active.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VentanaRegistrar>();
            desactivarPanelesActive();
            panelBtn1Active.Visible = true;
        }

        private void btnEnProgreso_Click(object sender, EventArgs e)
        {
            this.ventanaProgreso.Show();
            desactivarPanelesActive();
            panelBtn2Active.Visible = true;
        }

        private void btnFinalizadas_Click(object sender, EventArgs e)
        {
            desactivarPanelesActive();
            panelBtn3Active.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            if (!this.usuario.getPermiso())
            {
                ventanaLogin = new VentanaLogin(this.usuario);
                ventanaLogin.ShowDialog();
            }
            else
                MessageBox.Show("Ya hay una sesión iniciada");        
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.usuario.logout();
            MessageBox.Show("Usted ha cerrado sesión");
        }
    }
}
