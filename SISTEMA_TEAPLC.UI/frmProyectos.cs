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
    public partial class frmProyectos : Form
    {
        public frmPrincipal Principal;
        Gestor_Trabajos GestorTrabajos = new Gestor_Trabajos();
              
        public frmProyectos()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(txtArea, "Ingrese el área en metros cuadrados.");
            ttMensajes.SetToolTip(txtPrecio, "Ingrese el precio en colones.");
            ttMensajes.SetToolTip(cbxProyectos, "Buscar Proyecto.");
            ttMensajes.SetToolTip(cbxTiposForros, "Seleccione el tipo de forro.");
            ttMensajes.SetToolTip(txtDescripcion, "Seleccione una descripción.");
            ttMensajes.SetToolTip(btnAgregarNuevoProyecto, "Agregar un nuevo Proyecto.");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(btnAgregarNuevoTipoForro, "Agregar un nuevo tipo de forro.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar un nuevo trabajo del proyecto.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla principal.");
            ttMensajes.SetToolTip(btnRefrescar, "Refrescar la ventana.");
            ttMensajes.SetToolTip(btnImprimir, "Imprimir reporte del proyecto.");
        }

        private void frmProyectos_Load(object sender, EventArgs e)
        {
            CargarListaProyecto();
            CargarListas();
            btnAgregarNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void CargarListas()
        {
            this.tabla_Tipos_ForrosTableAdapter.Fill(this.tEAPLC_BD.Tabla_Tipos_Forros);
            cbxTiposForros.Text = "---Seleccione el tipo de forro---";            
        }

        private void CargarListaProyecto()
        {
            this.tabla_ProyectosTableAdapter.Fill(this.tEAPLC_BD.Tabla_Proyectos);
            cbxProyectos.Text = "---Buscar Proyecto---";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal.Show();
        }

        private void cbxProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trabajo TrabajosProyectos = new Trabajo();
            try
            {
                TrabajosProyectos.Id_Proyecto = Convert.ToInt32(cbxProyectos.SelectedValue.ToString());
                GestorTrabajos.MostrarTrabajosProyectos(TrabajosProyectos, dgvTrabajosDelProyectos);
                dgvTrabajosDelProyectos.Columns[0].Visible = false;
                dgvTrabajosDelProyectos.Columns[1].HeaderText = "Descripción";
                dgvTrabajosDelProyectos.Columns[2].HeaderText = "Área (m2)";
                dgvTrabajosDelProyectos.Columns[3].HeaderText = "Forro";
                dgvTrabajosDelProyectos.Columns[4].HeaderText = "Precio / (m2)";
                dgvTrabajosDelProyectos.Columns[5].HeaderText = "Total";
                lblMontoTotal.Text = "Monto Total (₡): " + GestorTrabajos.ObtenerMontoTotalPorProyecto(TrabajosProyectos);
                btnAgregarNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("¡De click al botón \"Regresar\" para volver a la pantalla principal!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Principal.Show();                
            }
            
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Trabajo TrabajosProyectos = new Trabajo();
            try
            {
                if (!ValidarDatosIngresados())
                {
                    TrabajosProyectos.Id_Proyecto = Convert.ToInt32(cbxProyectos.SelectedValue.ToString());
                    TrabajosProyectos.Tipo_Trabajo = txtDescripcion.Text;
                    TrabajosProyectos.Id_Tipo_Forro = Convert.ToInt32(cbxTiposForros.SelectedValue.ToString());
                    TrabajosProyectos.Precio = txtPrecio.Text.Replace(",", ".");
                    TrabajosProyectos.Area = txtArea.Text.Replace(",", ".");

                    if (GestorTrabajos.InsertarTrabajo(TrabajosProyectos))
                    {
                        MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTextos();
                        GestorTrabajos.MostrarTrabajosProyectos(TrabajosProyectos, dgvTrabajosDelProyectos);
                        lblMontoTotal.Text = "Monto Total (₡): " + 
                        GestorTrabajos.ObtenerMontoTotalPorProyecto(TrabajosProyectos);
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

                MessageBox.Show("¡Error, no se ingreso el registo!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                txtDescripcion.Text = dgvTrabajosDelProyectos.CurrentRow.Cells[1].Value.ToString();
                txtArea.Text = dgvTrabajosDelProyectos.CurrentRow.Cells[2].Value.ToString().Replace(",", ".");
                cbxTiposForros.Text = dgvTrabajosDelProyectos.CurrentRow.Cells[3].Value.ToString();
                txtPrecio.Text = dgvTrabajosDelProyectos.CurrentRow.Cells[4].Value.ToString().Replace(",", ".");
                btnAgregarNuevo.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("¡Seleccione bien el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Trabajo TrabajosProyectos = new Trabajo();
            try
            {
                if (!ValidarDatosIngresados())
                {
                    TrabajosProyectos.Id_Proyecto = Convert.ToInt32(cbxProyectos.SelectedValue.ToString());
                    TrabajosProyectos.Id_Trabajo = Convert.ToInt32(dgvTrabajosDelProyectos.CurrentRow.Cells[0].Value.ToString());
                    TrabajosProyectos.Tipo_Trabajo = txtDescripcion.Text;
                    TrabajosProyectos.Id_Tipo_Forro = Convert.ToInt32(cbxTiposForros.SelectedValue.ToString());
                    TrabajosProyectos.Precio = txtPrecio.Text.Replace(",", ".");
                    TrabajosProyectos.Area = txtArea.Text.Replace(",", ".");

                    if (GestorTrabajos.ModificarTrabajos(TrabajosProyectos))
                    {
                        MessageBox.Show("¡Registro modificado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTextos();
                        GestorTrabajos.MostrarTrabajosProyectos(TrabajosProyectos, dgvTrabajosDelProyectos);
                        lblMontoTotal.Text = "Monto Total (₡): " +
                        GestorTrabajos.ObtenerMontoTotalPorProyecto(TrabajosProyectos);
                        btnAgregarNuevo.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("¡Error, no se modifico el registo!", "¡Error!",
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

                MessageBox.Show("¡Error, no se modificó el registo!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Trabajo TrabajosProyectos = new Trabajo();
            try
            {
                TrabajosProyectos.Id_Trabajo = Convert.ToInt32(dgvTrabajosDelProyectos.CurrentRow.Cells[0].Value.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorTrabajos.EliminarTrabajos(TrabajosProyectos))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("¡No se pudo eliminar registro!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GestorTrabajos.MostrarTrabajosProyectos(TrabajosProyectos, dgvTrabajosDelProyectos);
                    lblMontoTotal.Text = "Monto Total (₡): " + GestorTrabajos.ObtenerMontoTotalPorProyecto(TrabajosProyectos);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("¡Seleccione bien el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosIngresados()
        {
            return
                 txtArea.Text.Equals("")||
                 txtPrecio.Text.Equals("")||
                 txtDescripcion.Text.Equals("");
        }

        private void LimpiarTextos()
        {
            txtPrecio.Text = "";
            txtArea.Text = "";
            txtDescripcion.Text = "";
            cbxTiposForros.Text = "---Seleccione el tipo de forro---";
        }

        private void btnAgregarNuevoTipoForro_Click(object sender, EventArgs e)
        {
            frmGestorTiposForro gestorTipoForro = new frmGestorTiposForro();
            gestorTipoForro.ShowDialog();
        }

        private void btnAgregarNuevoProyecto_Click(object sender, EventArgs e)
        {
            frmGestorProyectos frmGestorProyectos = new frmGestorProyectos();
            frmGestorProyectos.Principal = this.Principal;
            frmGestorProyectos.Show();
            this.Hide();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarListas();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Trabajo TrabajosProyectos = new Trabajo();
            Proyecto proyecto = new Proyecto();
            try
            {
                TrabajosProyectos.Id_Proyecto = Convert.ToInt32(cbxProyectos.SelectedValue.ToString());
                proyecto.Id_Encargado = Convert.ToInt32(GestorTrabajos.ObtenerIdEncargado(TrabajosProyectos));
                frmReportesProyectos reporte = new frmReportesProyectos(TrabajosProyectos, proyecto);
                reporte.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("¡Error, ocurrió un problema!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void frmProyectos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Principal.Show();
        }
    }
}
