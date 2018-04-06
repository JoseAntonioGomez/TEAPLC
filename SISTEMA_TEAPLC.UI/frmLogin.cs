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
    public partial class frmLogin : Form
    {
        Gestor_Usuarios GestorUsuario = new Gestor_Usuarios();

        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            lblFecha.Text = fecha_actual;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Usuario Usuario = new Usuario();
            frmPrincipal Principal = new frmPrincipal();
            try
            {
                Usuario.Nombre_Usuario = txtUsuario.Text;
                Usuario.Password = txtPassword.Text;
                if (GestorUsuario.IniciarSesion(Usuario))
                {
                    MessageBox.Show("Bienvenido al Sistema!!", 
                        "Usuario correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Principal.NombreUsuario = Usuario.Nombre_Usuario;
                    Principal.Show();
                    this.Hide();   
                }
                else
                {
                    MessageBox.Show("Usuario no registrado!!", 
                        "Usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema!!", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
