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
    public partial class frmGestorBancos : Form
    {
        Gestor_Cuentas_Bancarias GestorCuentasBancarias = new Gestor_Cuentas_Bancarias();

        public frmGestorBancos()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(txtNombre, "Ingrese el nombre del nuevo banco.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar un nuevo banco.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar.");
        }

        private void frmGestorBancos_Load(object sender, EventArgs e)
        {
            this.tabla_BancosTableAdapter.Fill(this.tEAPLC_BD.Tabla_Bancos);
            btnGuardar.Enabled = false;
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Banco nuevoBanco = new Banco();
            try
            {
                if (!txtNombre.Text.Equals(""))
                {
                    nuevoBanco.Nombre = txtNombre.Text;
                    if (GestorCuentasBancarias.InsertarBanco(nuevoBanco))
                    {
                        MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = "";
                        frmGestorBancos_Load(sender, e);
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
                txtNombre.Text = lbxBancos.Text;
                btnGuardar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Seleccione un resgistro!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            try
            {
                if (!txtNombre.Text.Equals(""))
                {
                    banco.Nombre = txtNombre.Text;
                    banco.Id_Banco = Convert.ToInt32(lbxBancos.SelectedValue.ToString());
                    btnGuardar.Enabled = false;
                    if (GestorCuentasBancarias.ModificarBanco(banco))
                    {
                        MessageBox.Show("¡Registro modificado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = "";
                        frmGestorBancos_Load(sender, e);
                        btnGuardar.Enabled = false;
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
            Banco banco = new Banco();
            try
            {
                if (lbxBancos.SelectedItem != null)
                {
                    banco.Id_Banco = Convert.ToInt32(lbxBancos.SelectedValue.ToString());
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (GestorCuentasBancarias.EliminarBanco(banco))
                        {
                            MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmGestorBancos_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("¡No se pudo eliminar registro!", "¡Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Seleccione un resgistro!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Seleccione un resgistro!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
