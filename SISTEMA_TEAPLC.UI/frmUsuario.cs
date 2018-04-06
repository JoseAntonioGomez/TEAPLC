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
using SISTEMA_TEAPLC.MODEL;

namespace SISTEMA_TEAPLC.UI
{
    public partial class frmUsuario : Form
    {
        public string NombreUsuario;
        public frmPrincipal Principal;
        Gestor_Usuarios GestorUsuarios = new Gestor_Usuarios();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            txtNuevoUsuario.Text = NombreUsuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario ViejoUsuario = new Usuario();
            Usuario NuevoUsuario = new Usuario();

            ViejoUsuario.Nombre_Usuario = NombreUsuario;
            ViejoUsuario.Password = txtPassword.Text;

            NuevoUsuario.Nombre_Usuario = txtNuevoUsuario.Text;
            NuevoUsuario.Password = txtNuevoPassword.Text;

            if (GestorUsuarios.ActualizarUsuario(NuevoUsuario,ViejoUsuario))
            {                
                MessageBox.Show("Datos de Usuario actualizados!!",
                "Usuario correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Principal.NombreUsuario = txtNuevoUsuario.Text;
                Principal.MostrarNombreUsuario(txtNuevoUsuario.Text);
                Principal.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Datos de Usuario no se actualizó!!",
                "Usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal.Show();
        }
    }
}
