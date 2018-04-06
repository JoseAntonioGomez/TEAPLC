using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISTEMA_TEAPLC.LN;

namespace SISTEMA_TEAPLC.UI
{
    public partial class frmPrincipal : Form
    {
        public string NombreUsuario { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarNombreUsuario(NombreUsuario);
            this.WindowState = FormWindowState.Maximized;
        }

        public void MostrarNombreUsuario(string nombreUsuario)
        {
            mitmSalir.Text = nombreUsuario;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void itmEditarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario Usuario = new frmUsuario();
            Usuario.NombreUsuario = NombreUsuario;
            Usuario.Principal = this;
            //this.Hide();
            Usuario.ShowDialog();
        }

        private void itmCerrarSesión_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void itmPlanilla_Click(object sender, EventArgs e)
        {
            frmPlanilla Planilla = new frmPlanilla();
            Planilla.Principal = this;
            Planilla.Show();
        }

        private void itmColaboradores_Click(object sender, EventArgs e)
        {
            frmColaborador Colaborador = new frmColaborador();
            Colaborador.Principal = this;
            Colaborador.ShowDialog();
        }

        private void itmProyectos_Click(object sender, EventArgs e)
        {
            frmProyectos proyecto = new frmProyectos();
            proyecto.Principal = this;
            proyecto.Show();
        }

        private void itmEmpresas_Click(object sender, EventArgs e)
        {
            frmGestorEmpresas empresas = new frmGestorEmpresas();
            empresas.Principal = this;
            //this.Hide();
            empresas.ShowDialog();
        }

        private void itmPrestamos_Click(object sender, EventArgs e)
        {
            frmGestorPrestamos prestamos = new frmGestorPrestamos();
            prestamos.Principal = this;
            //this.Hide();
            prestamos.ShowDialog();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            itmProyectos_Click(sender,e);
        }

        private void btnPlanillas_Click(object sender, EventArgs e)
        {
            itmPlanilla_Click(sender, e);
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            itmEmpresas_Click(sender, e);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            itmPrestamos_Click(sender, e);
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            itmColaboradores_Click(sender, e);
        }

        private void Salir()
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir del sistema?",
                "Salir del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
