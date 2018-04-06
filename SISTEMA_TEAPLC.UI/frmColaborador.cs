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
    public partial class frmColaborador : Form
    {
        public frmPrincipal Principal;
        public bool AbrioVentanaPrincipal;
        Gestor_Colaboradores GestorColaborador = new Gestor_Colaboradores();
        public frmColaborador()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(txtCedula,"Ingrese el número de cédula.");
            ttMensajes.SetToolTip(txtNombre, "Ingrese el nombre completo.");
            ttMensajes.SetToolTip(txtTelefono, "Ingrese el número de teléfono.");
            ttMensajes.SetToolTip(txtCorreo, "Ingrese el correo electrónico.");
            ttMensajes.SetToolTip(txtDireccion, "Ingrese la dirección o lugar de residencia.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar nuevo registro.");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(txtBuscarColaborador, "Ingrese el Nombre o Número de Cédula.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla principal.");
            ttMensajes.SetToolTip(btnCuentasBancarias, "Cuentas bancarias de los empleados");
            ttMensajes.SetToolTip(btnTiempoActividad, "Tiempo de la actividad de los empleados");
            AbrioVentanaPrincipal = true;
        }

        public frmColaborador(bool abrioVentanaPrincipal)
        {
            AbrioVentanaPrincipal = abrioVentanaPrincipal;
            InitializeComponent();
        }
        
        private void frmColaborador_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            this.WindowState = FormWindowState.Maximized;
        }

        private void MostrarDatos()
        {
            try
            {
                GestorColaborador.MostrarColaboradores(txtBuscarColaborador.Text, dgvColaboradores);
                dgvColaboradores.Columns[0].Visible = false;
                btnGuardar.Enabled = false;
                dgvColaboradores.Columns[1].HeaderText = "Nombre";
                dgvColaboradores.Columns[2].HeaderText = "Cédula";
                dgvColaboradores.Columns[3].HeaderText = "Teléfono";
                dgvColaboradores.Columns[4].HeaderText = "Correo";
                dgvColaboradores.Columns[5].HeaderText = "Dirección";

            }
            catch (Exception)
            {
                DialogResult respuesta = MessageBox.Show("Ocurrio un problema. ¿Desea continuar?",
                "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    Principal.Show();
                    this.Close();
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Colaborador nuevoColaborador = new Colaborador();
            try
            {
                if (!ValidarDatosIngresados())
                {
                    nuevoColaborador.Nombre = txtNombre.Text;
                    nuevoColaborador.Cedula = txtCedula.Text;
                    nuevoColaborador.Telefono = txtTelefono.Text;
                    nuevoColaborador.Correo = txtCorreo.Text;
                    nuevoColaborador.Direccion = txtDireccion.Text;
                    if (GestorColaborador.InsertarColaborador(nuevoColaborador))
                    {
                        MessageBox.Show("¡Colaborador registrado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("¡Colaborador no registrado!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Debe de ingresar todos los datos!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimpiarTextos();
                GestorColaborador.MostrarColaboradores(txtBuscarColaborador.Text, dgvColaboradores);
            }
            catch (Exception)
            {

                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            { 
                txtNombre.Text = dgvColaboradores.CurrentRow.Cells[1].Value.ToString();
                txtCedula.Text = dgvColaboradores.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvColaboradores.CurrentRow.Cells[3].Value.ToString();
                txtCorreo.Text = dgvColaboradores.CurrentRow.Cells[4].Value.ToString();
                txtDireccion.Text = dgvColaboradores.CurrentRow.Cells[5].Value.ToString();
                btnAgregarNuevo.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Seleccione bien el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void txtBuscarColaborador_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                GestorColaborador.MostrarColaboradores(txtBuscarColaborador.Text, dgvColaboradores);
            }
            catch (Exception)
            {

                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Colaborador colaborador = new Colaborador();
            try
            {
                colaborador.Id_Colaborador = Convert.ToInt32(dgvColaboradores.CurrentRow.Cells[0].Value.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorColaborador.EliminarColaborador(colaborador))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GestorColaborador.MostrarColaboradores(txtBuscarColaborador.Text, dgvColaboradores);
                    }
                    else
                    {
                        MessageBox.Show("¡No se pudo eliminar registro!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Colaborador colaborador = new Colaborador();
            try
            {
                colaborador.Id_Colaborador = Convert.ToInt32(dgvColaboradores.CurrentRow.Cells[0].Value.ToString());
                colaborador.Nombre = txtNombre.Text;
                colaborador.Cedula = txtCedula.Text;
                colaborador.Telefono = txtTelefono.Text;
                colaborador.Correo = txtCorreo.Text;
                colaborador.Direccion = txtDireccion.Text;
                if (!ValidarDatosIngresados())
                {
                    if (GestorColaborador.ModificarColaborador(colaborador))
                    {
                        MessageBox.Show("¡Registro modificado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTextos();
                        GestorColaborador.MostrarColaboradores(txtBuscarColaborador.Text, dgvColaboradores);
                        btnAgregarNuevo.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("¡Registro no se modificó correctamente!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Debe de ingresar todos los datos!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch (Exception)
            {

                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarDatosIngresados()
        {
            return
                 txtNombre.Equals("") || txtCedula.Equals("") || txtDireccion.Equals("")
                 || txtTelefono.Equals("") || txtCorreo.Equals("");
        }

        public void LimpiarTextos()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCedula.Text = "";
            txtCorreo.Text = "";
        }

        private void btnCuentasBancarias_Click(object sender, EventArgs e)
        {
            frmGestorCuentas cuentas = new frmGestorCuentas();
            Colaborador colaborador = new Colaborador();
            try
            {
                colaborador.Id_Colaborador = Convert.ToInt32(dgvColaboradores.CurrentRow.Cells[0].Value.ToString());
                colaborador.Nombre = dgvColaboradores.CurrentRow.Cells[1].Value.ToString();
                cuentas.Colaborador = colaborador;
                cuentas.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("¡Seleccione el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTiempoActividad_Click(object sender, EventArgs e)
        {
            frmGestorActividades cuentas = new frmGestorActividades();
            Colaborador colaborador = new Colaborador();
            try
            {
                colaborador.Id_Colaborador = Convert.ToInt32(dgvColaboradores.CurrentRow.Cells[0].Value.ToString());
                colaborador.Nombre = dgvColaboradores.CurrentRow.Cells[1].Value.ToString();
                cuentas.Colaborador = colaborador;
                cuentas.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("¡Seleccione el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmColaborador_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarVentana();
        }

        private void CerrarVentana()
        {
            Principal.Show();
            this.Close();
        }
    }
}
