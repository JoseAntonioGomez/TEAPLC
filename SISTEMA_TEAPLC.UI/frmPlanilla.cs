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
    public partial class frmPlanilla : Form
    {
        public frmPrincipal Principal;
        private Gestor_Planillas GestorPlanillas = new Gestor_Planillas();
        public double MontoPrestamo { get; set; }
        public frmPlanilla()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(txtHoras, "Ingrese la cantidad de horas trabajadas.");
            ttMensajes.SetToolTip(txtPrecio, "Ingrese el precio en colones por hora.");
            ttMensajes.SetToolTip(cbxEmpleado, "Buscar nombre del empleado.");
            ttMensajes.SetToolTip(txtMontoPrestamo, "Monto del prestamo a cancelar");
            ttMensajes.SetToolTip(dtpFecha, "Seleccione la fecha para ingresar la nueva planilla.");
            ttMensajes.SetToolTip(dtpBuscarPlanilla, "Seleccione la fecha para buscar una planilla.");
            ttMensajes.SetToolTip(btnBuscar, "Buscar planilla por fecha.");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(btnPrestamos, "Cancelar los prestamos del empleado.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar un nuevo registro.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla principal.");
            ttMensajes.SetToolTip(btnImprimir, "Imprimir reporte de la planilla.");
        }

        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            ObtenerDatosListaColaboradores();
            btnPrestamos.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            MostrarMontoPrestamo(MontoPrestamo);
            this.WindowState = FormWindowState.Maximized;
        }

        public void MostrarMontoPrestamo(double montoPrestamo)
        {
            txtMontoPrestamo.Text = string.Format("{0}", montoPrestamo);
        }

        private void ObtenerDatosListaColaboradores()
        {
            this.tabla_ColaboradoresTableAdapter.Fill(this.tEAPLC_BD.Tabla_Colaboradores);
            cbxEmpleado.Text = "---Seleccione un colaborador---";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Planilla planilla = new Planilla();
                planilla.Fecha = Convert.ToDateTime(dtpBuscarPlanilla.Text);
                GestorPlanillas.ConsultarPlanilla(planilla, dgvPlanilla);
                dgvPlanilla.Columns[0].Visible = false;
                dgvPlanilla.Columns[1].HeaderText = "Nombre";
                dgvPlanilla.Columns[2].HeaderText = "Cédula";
                dgvPlanilla.Columns[3].HeaderText = "Número de Horas";
                dgvPlanilla.Columns[4].HeaderText = "Precio por hora";
                dgvPlanilla.Columns[5].HeaderText = "Total Bruto";
                dgvPlanilla.Columns[6].HeaderText = "Monto de Prestamo";
                dgvPlanilla.Columns[7].HeaderText = "Total de Deducciones";
                dgvPlanilla.Columns[8].HeaderText = "total Neto";
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("¡Seleccione la fecha de la planilla!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                   
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            try
            {
                MontoPrestamo = Convert.ToDouble(txtMontoPrestamo.Text);
                Colaborador colaborador = new Colaborador();
                colaborador.Id_Colaborador = Convert.ToInt32(cbxEmpleado.SelectedValue.ToString());
                colaborador.Nombre = cbxEmpleado.Text;
                frmCancelarPrestamos cancelarPrestamo = new frmCancelarPrestamos();
                cancelarPrestamo.Planilla = this;
                cancelarPrestamo.Colaborador = colaborador;
                cancelarPrestamo.MostrarMontoPrestamo(MontoPrestamo);
                cancelarPrestamo.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                this.Principal.Show();
            }
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Planilla nuevaPlanilla = new Planilla();
            try
            {                
                if (!ValidarDatosIngresados())
                {
                    nuevaPlanilla.Id_Colaborador = Convert.ToInt32(cbxEmpleado.SelectedValue.ToString());
                    nuevaPlanilla.Numero_Horas = Convert.ToInt32(txtHoras.Text);
                    nuevaPlanilla.Precio_Horas = Convert.ToDecimal(txtPrecio.Text);
                    nuevaPlanilla.Fecha = Convert.ToDateTime(dtpFecha.Text);
                    nuevaPlanilla.Prestamo = Convert.ToDecimal(txtMontoPrestamo.Text);

                    if (GestorPlanillas.InsertarPlanilla(nuevaPlanilla))
                    {
                        MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTextos();
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
                Planilla planilla = new Planilla();
                cbxEmpleado.Text = dgvPlanilla.CurrentRow.Cells[1].Value.ToString();
                planilla.Numero_Horas = Convert.ToInt32(dgvPlanilla.CurrentRow.Cells[3].Value.ToString().Replace(".", ","));
                planilla.Precio_Horas = Convert.ToDecimal(dgvPlanilla.CurrentRow.Cells[4].Value.ToString().Replace(".", ","));
                planilla.Prestamo = Convert.ToDecimal(dgvPlanilla.CurrentRow.Cells[6].Value.ToString().Replace(".", ","));

                txtHoras.Text = string.Format("{0}",planilla.Numero_Horas);
                txtPrecio.Text = string.Format("{0}", planilla.Precio_Horas);
                txtMontoPrestamo.Text = string.Format("{0}", planilla.Prestamo);
                dtpFecha.Text = dtpBuscarPlanilla.Text;
                btnAgregarNuevo.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Planilla planilla = new Planilla();
            try
            {
                if (!ValidarDatosIngresados())
                {
                    planilla.Id_Planilla = Convert.ToInt32(dgvPlanilla.CurrentRow.Cells[0].Value.ToString());
                    planilla.Id_Colaborador = Convert.ToInt32(cbxEmpleado.SelectedValue.ToString());
                    planilla.Numero_Horas = Convert.ToInt32(txtHoras.Text);
                    planilla.Precio_Horas = Convert.ToDecimal(txtPrecio.Text);
                    planilla.Fecha = Convert.ToDateTime(dtpFecha.Text);
                    planilla.Prestamo = Convert.ToDecimal(txtMontoPrestamo.Text);

                    if (GestorPlanillas.ModificarPlanilla(planilla))
                    {
                        MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar_Click(sender,e);
                        LimpiarTextos();
                        btnAgregarNuevo.Enabled = true;
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
            Planilla planilla = new Planilla();
            try
            {
                planilla.Id_Planilla = Convert.ToInt32(dgvPlanilla.CurrentRow.Cells[0].Value.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorPlanillas.EliminarPlanilla(planilla))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar_Click(sender, e);
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

        private void cbxEncargados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMontoPrestamo.Enabled = true;
            btnPrestamos.Enabled = true;
        }

        public bool ValidarDatosIngresados()
        {
            return
                 txtHoras.Text.Equals("") || 
                 txtPrecio.Text.Equals("") || 
                 txtMontoPrestamo.Text.Equals("");
        }

        public void LimpiarTextos()
        {
            txtMontoPrestamo.Text = "0";
            txtHoras.Text = "";
            txtPrecio.Text = "";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Planilla planilla = new Planilla();
            planilla.Fecha = Convert.ToDateTime(dtpBuscarPlanilla.Text);
            frmReportesPlanillas reportePlanilla = new frmReportesPlanillas(planilla);
            reportePlanilla.ShowDialog();
        }
    }
}