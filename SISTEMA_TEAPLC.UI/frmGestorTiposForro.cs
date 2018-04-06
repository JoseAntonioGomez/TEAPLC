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
    public partial class frmGestorTiposForro : Form
    {
        public frmGestorTiposForro()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(txtTipoForro, "Ingrese el nuevo tipo de forro.");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar un nuevo resgistro.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla principal.");
        }

        private Tipo_Forro TipoForro = new Tipo_Forro();

        private Gestor_Trabajos GestorTrabajos = new Gestor_Trabajos();

        private void frmGestorTiposForro_Load(object sender, EventArgs e)
        {
            this.tabla_Tipos_ForrosTableAdapter.Fill(this.tEAPLC_BD.Tabla_Tipos_Forros);
            btnGuardar.Enabled = false;
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtTipoForro.Text.Equals(""))
                {
                    TipoForro.Descripcion = txtTipoForro.Text;
                    if (GestorTrabajos.InsertarTipoForro(TipoForro))
                    {
                        MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoForro.Text = "";
                        frmGestorTiposForro_Load(sender, e);
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
            if (lbxTiposForros.SelectedItem != null)
            {
                txtTipoForro.Text = lbxTiposForros.Text;
                TipoForro.Id_Tipo_Forro = Convert.ToInt32(lbxTiposForros.SelectedValue.ToString());
                btnGuardar.Enabled = true;
                btnAgregarNuevo.Enabled = false;
            }
            else
            {
                MessageBox.Show("¡Seleccione un resgistro!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtTipoForro.Text.Equals(""))
            {
                TipoForro.Descripcion = txtTipoForro.Text;
                if (GestorTrabajos.ModificarTipoForro(TipoForro))
                {
                    MessageBox.Show("¡Registro modificado correctamente!", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTipoForro.Text = "";
                    frmGestorTiposForro_Load(sender, e);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbxTiposForros.SelectedItem != null)
            {
                TipoForro.Id_Tipo_Forro = Convert.ToInt32(lbxTiposForros.SelectedValue.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
            "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorTrabajos.EliminarTipoForros(TipoForro))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmGestorTiposForro_Load(sender, e);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
