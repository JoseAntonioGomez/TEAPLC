using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISTEMA_TEAPLC.MODEL;
using SISTEMA_TEAPLC.LN;

namespace SISTEMA_TEAPLC.UI
{
    public partial class frmGestorCuentas : Form
    {
        public Colaborador Colaborador;
        private Gestor_Cuentas_Bancarias GestorCuentas = new Gestor_Cuentas_Bancarias();
        public frmColaborador frmColaborador;
        public frmGestorCuentas()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(lblNombreColaborador, "Nombre del colaborador.");
            ttMensajes.SetToolTip(txtCuentaCliente, "Ingrese el numero de cuenta cliente.");
            ttMensajes.SetToolTip(txtNumeroCuenta, "Ingrese el numero de cuenta.");
            ttMensajes.SetToolTip(cbxBanco, "Buscar banco.");
            ttMensajes.SetToolTip(cbxMoneda, "Seleccione el tipo de moneda");
            ttMensajes.SetToolTip(cbxTipoCuenta, "Seleccione el tipo de cuenta");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(btnAgregarBanco, "Agregar un nuevo banco.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar una nueva cuenta.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla principal.");
            ttMensajes.SetToolTip(btnRefrescar, "Refrescar la ventana.");
        }

        private void frmGestorCuentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tEAPLC_BD.Tabla_Monedas' Puede moverla o quitarla según sea necesario.
            this.tabla_MonedasTableAdapter.Fill(this.tEAPLC_BD.Tabla_Monedas);
            // TODO: esta línea de código carga datos en la tabla 'tEAPLC_BD.Tabla_Tipos_Cuentas' Puede moverla o quitarla según sea necesario.
            this.tabla_Tipos_CuentasTableAdapter.Fill(this.tEAPLC_BD.Tabla_Tipos_Cuentas);
            this.CargarListaBancos();
            this.MostrarNombreColaborador(Colaborador.Nombre);
            this.MostrarConsultaCuentas();
            btnGuardar.Enabled = false;
        }

        private void MostrarConsultaCuentas()
        {
            Cuenta cuenta = new Cuenta();
            try
            {
                cuenta.Id_Colaborador = Colaborador.Id_Colaborador;
                GestorCuentas.ConsultarCuentas(cuenta, dgvCuentas);
                dgvCuentas.Columns[0].Visible = false;                
                dgvCuentas.Columns[1].HeaderText = "Banco";
                dgvCuentas.Columns[2].HeaderText = "Número de Cuenta";
                dgvCuentas.Columns[3].HeaderText = "Cuenta cliente";
                dgvCuentas.Columns[4].HeaderText = "Moneda";
                dgvCuentas.Columns[5].HeaderText = "Tipo de Cuenta";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema!!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarNombreColaborador(string nombre)
        {
            lblNombreColaborador.Text = string.Format("Cuentas bancarias de: {0}", nombre);
        }

        private void CargarListaBancos()
        {
            // TODO: esta línea de código carga datos en la tabla 'tEAPLC_BD.Tabla_Bancos' Puede moverla o quitarla según sea necesario.
            this.tabla_BancosTableAdapter.Fill(this.tEAPLC_BD.Tabla_Bancos);
        }

        private bool ValidarCampos()
        {
            return txtCuentaCliente.Text.Equals("") || txtNumeroCuenta.Text.Equals("");
        }

        private void LimpiarCaampos()
        {
            txtNumeroCuenta.Text = "";
            txtCuentaCliente.Text = "";
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            try
            {
                if (!ValidarCampos())
                {
                    cuenta.Id_Colaborador = Colaborador.Id_Colaborador;
                    cuenta.Numero_Cuenta = txtNumeroCuenta.Text;
                    cuenta.Numero_Cuenta_Cliente = Convert.ToInt64(txtCuentaCliente.Text);
                    cuenta.Id_Banco = Convert.ToInt32(cbxBanco.SelectedValue.ToString());
                    cuenta.Id_Moneda = Convert.ToInt32(cbxMoneda.SelectedValue.ToString());
                    cuenta.Id_Tipo_Cuenta = Convert.ToInt32(cbxTipoCuenta.SelectedValue.ToString());

                    if (GestorCuentas.InsertarCuenta(cuenta))
                    {
                        MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCaampos();
                        frmGestorCuentas_Load(sender, e);
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
                cbxBanco.Text = dgvCuentas.CurrentRow.Cells[1].Value.ToString();
                txtNumeroCuenta.Text = dgvCuentas.CurrentRow.Cells[2].Value.ToString();
                txtCuentaCliente.Text = dgvCuentas.CurrentRow.Cells[3].Value.ToString();
                cbxMoneda.Text = dgvCuentas.CurrentRow.Cells[4].Value.ToString();
                cbxTipoCuenta.Text = dgvCuentas.CurrentRow.Cells[5].Value.ToString();                
                btnGuardar.Enabled = true;
                btnAgregarNuevo.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Seleccione un resgistro!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            try
            {
                if (!ValidarCampos())
                {
                    cuenta.Id_Cuenta = Convert.ToInt32(dgvCuentas.CurrentRow.Cells[0].Value.ToString());
                    cuenta.Id_Colaborador = Colaborador.Id_Colaborador;
                    cuenta.Numero_Cuenta = txtNumeroCuenta.Text;
                    cuenta.Numero_Cuenta_Cliente = Convert.ToInt64(txtCuentaCliente.Text);
                    cuenta.Id_Banco = Convert.ToInt32(cbxBanco.SelectedValue.ToString());
                    cuenta.Id_Moneda = Convert.ToInt32(cbxMoneda.SelectedValue.ToString());
                    cuenta.Id_Tipo_Cuenta = Convert.ToInt32(cbxTipoCuenta.SelectedValue.ToString());

                    if (GestorCuentas.ModificarCuenta(cuenta))
                    {
                        MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCaampos();
                        frmGestorCuentas_Load(sender, e);
                        btnGuardar.Enabled = false;
                        btnAgregarNuevo.Enabled = true;
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
            catch (Exception)
            {
                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            try
            {
                cuenta.Id_Cuenta = Convert.ToInt32(dgvCuentas.CurrentRow.Cells[0].Value.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorCuentas.EliminarCuenta(cuenta))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmGestorCuentas_Load(sender, e);
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

                MessageBox.Show("¡Seleccione bien el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarBanco_Click(object sender, EventArgs e)
        {
            frmGestorBancos bancos = new frmGestorBancos();
            bancos.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarListaBancos();
        }
    }
}
