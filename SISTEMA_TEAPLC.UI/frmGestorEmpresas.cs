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
    public partial class frmGestorEmpresas : Form
    {
        public frmPrincipal Principal;
        private Gestor_Empresas GestorEmpresas = new Gestor_Empresas();

        public frmGestorEmpresas()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(txtDireccion, "Ingrese la dirección.");
            ttMensajes.SetToolTip(txtNombre, "Ingrese el nombre de la empresa.");
            ttMensajes.SetToolTip(txtCorreo, "Ingrese un correo eletrónico.");
            ttMensajes.SetToolTip(txtTelefono, "Ingrese un número de teléfono.");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar un nuevo registro.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla principal.");

        }

        private void frmGestorEmpresas_Load(object sender, EventArgs e)
        {
            GestorEmpresas.MostrarEmpresas(dgvEmpresas);
            dgvEmpresas.Columns[0].Visible = false;
            btnGuardar.Enabled = false;
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Empresa nuevaEmpresa = new Empresa();
            if (!ValidarDatosIngresados())
            {
                nuevaEmpresa.Direccion = txtDireccion.Text;
                nuevaEmpresa.Correo = txtCorreo.Text;
                nuevaEmpresa.Nombre = txtNombre.Text;
                nuevaEmpresa.Telefono = txtTelefono.Text;

                if (GestorEmpresas.InsertarEmpresas(nuevaEmpresa))
                {
                    MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextos();
                    frmGestorEmpresas_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("¡Error, no se ingreso el registo!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¡Debe de ingresar todos los datos!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = dgvEmpresas.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = dgvEmpresas.CurrentRow.Cells[2].Value.ToString();
                txtCorreo.Text = dgvEmpresas.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvEmpresas.CurrentRow.Cells[4].Value.ToString();
                btnGuardar.Enabled = true;
                btnAgregarNuevo.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Seleccione bien el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            if (!ValidarDatosIngresados())
            {
                empresa.Id_Empresa = Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value.ToString());
                empresa.Direccion = txtDireccion.Text;
                empresa.Correo = txtCorreo.Text;
                empresa.Nombre = txtNombre.Text;
                empresa.Telefono = txtTelefono.Text;

                if (GestorEmpresas.ModificarEmpresas(empresa))
                {
                    MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextos();
                    frmGestorEmpresas_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("¡Error, no se ingreso el registo!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¡Debe de ingresar todos los datos!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnAgregarNuevo.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            try
            {
                empresa.Id_Empresa = Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorEmpresas.EliminarEmpresas(empresa))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("¡No se pudo eliminar registro!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    frmGestorEmpresas_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Seleccione bien el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal.Show();
        }

        private bool ValidarDatosIngresados()
        {
            return
                 txtNombre.Text.Equals("") ||
                 txtCorreo.Text.Equals("") ||             
                 txtDireccion.Text.Equals("") ||
                 txtTelefono.Text.Equals("");
        }

        private void LimpiarTextos()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }
    }
}
