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
using System.Windows.Controls;

namespace SISTEMA_TEAPLC.UI
{
    public partial class frmGestorPrestamos : Form
    {
        public frmPrincipal Principal;
        private Gestor_Prestamos GestorPrestamos = new Gestor_Prestamos();
        public frmGestorPrestamos()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(cbxColaboradores, "Seleccione el nombre del colaborador.");
            ttMensajes.SetToolTip(cbxEstado, "Seleccione el estado del prestamo.");
            ttMensajes.SetToolTip(btnConsultarTodosLosPrestamos, "Mostrar todos los prestamos.");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(txtDescripcion, "Ingrese la descripción del prestamo.");
            ttMensajes.SetToolTip(txtMonto, "Ingrese el monto del prestamo.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar un nuevo registro.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar.");
        }

        private void frmGestorPrestamos_Load(object sender, EventArgs e)
        {
            this.tabla_EstadosTableAdapter.Fill(this.tEAPLC_BD.Tabla_Estados);
            this.tabla_ColaboradoresTableAdapter.Fill(this.tEAPLC_BD.Tabla_Colaboradores);
            btnAgregarNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnConsultarTodosLosPrestamos.Enabled = false;
            cbxColaboradores.Text = "---Seleccione un colaborador---";
        }

        private void cbxColaboradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            try
            {
                prestamo.Id_Colaborador = Convert.ToInt32(cbxColaboradores.SelectedValue.ToString());
                prestamo.Id_Estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                GestorPrestamos.ConsultarPrestamos(prestamo, dgvPrestamos);
                dgvPrestamos.Columns[0].Visible = false;
                dgvPrestamos.Columns[1].HeaderText = "Nombre";
                dgvPrestamos.Columns[2].HeaderText = "Descripción";
                dgvPrestamos.Columns[3].HeaderText = "Monto Total";
                dgvPrestamos.Columns[4].HeaderText = "Monto Pendiente";
                btnAgregarNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;
                btnConsultarTodosLosPrestamos.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("¡De click al botón \"Regresar\" para volver a la pantalla principal!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Principal.Show();
            }
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            try
            {
                int cancelado = 2;
                prestamo.Id_Colaborador = Convert.ToInt32(cbxColaboradores.SelectedValue.ToString());
                prestamo.Id_Estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                GestorPrestamos.ConsultarPrestamos(prestamo, dgvPrestamos);
                dgvPrestamos.Columns[0].Visible = false;
                dgvPrestamos.Columns[1].HeaderText = "Nombre";
                dgvPrestamos.Columns[2].HeaderText = "Descripción";
                dgvPrestamos.Columns[3].HeaderText = "Monto Total";
                dgvPrestamos.Columns[4].HeaderText = "Monto Pendiente";
                if (prestamo.Id_Estado == cancelado)
                {
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = true;
                }
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
            Prestamo prestamo = new Prestamo();
            try
            {
                if (!ValidarDatosIngresados())
                {
                    prestamo.Id_Colaborador = Convert.ToInt32(cbxColaboradores.SelectedValue.ToString());
                    prestamo.Id_Estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    prestamo.Descripcion = txtDescripcion.Text;
                    prestamo.Monto = txtMonto.Text.Replace(",", ".");

                    if (GestorPrestamos.InsertarPrestamos(prestamo))
                    {
                        MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTextos();
                        GestorPrestamos.ConsultarPrestamos(prestamo, dgvPrestamos);
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
                txtDescripcion.Text = dgvPrestamos.CurrentRow.Cells[2].Value.ToString();
                txtMonto.Text = dgvPrestamos.CurrentRow.Cells[4].Value.ToString().Replace(",", ".");
            }
            catch (Exception)
            {

                MessageBox.Show("¡Seleccione bien el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            if (!ValidarDatosIngresados())
            {
                prestamo.Id_Prestamo = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells[0].Value.ToString());
                prestamo.Id_Colaborador = Convert.ToInt32(cbxColaboradores.SelectedValue.ToString());
                prestamo.Id_Estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                prestamo.Descripcion = txtDescripcion.Text;
                prestamo.Monto = txtMonto.Text.Replace(",", ".");

                if (GestorPrestamos.ModificarPrestamos(prestamo))
                {
                    MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            LimpiarTextos();
            GestorPrestamos.ConsultarPrestamos(prestamo, dgvPrestamos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            try
            {
                prestamo.Id_Prestamo = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells[0].Value.ToString());
                prestamo.Id_Colaborador = Convert.ToInt32(cbxColaboradores.SelectedValue.ToString());
                prestamo.Id_Estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorPrestamos.EliminarPrestamos(prestamo))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("¡No se pudo eliminar registro!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GestorPrestamos.ConsultarPrestamos(prestamo, dgvPrestamos);
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

        private void btnConsultarTodosLosPrestamos_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            try
            {
                prestamo.Id_Colaborador = Convert.ToInt32(cbxColaboradores.SelectedValue.ToString());
                GestorPrestamos.ConsultarTodosLosPrestamos(prestamo, dgvPrestamos);
                dgvPrestamos.Columns[0].Visible = false;
                dgvPrestamos.Columns[1].HeaderText = "Nombre";
                dgvPrestamos.Columns[2].HeaderText = "Descripción";
                dgvPrestamos.Columns[3].HeaderText = "Monto Total";
                dgvPrestamos.Columns[4].HeaderText = "Monto Pendiente";
                btnModificar.Enabled = false;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            catch (Exception)
            {

                MessageBox.Show("¡Ocurrio un problema desea continuar con el programa!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Principal.Show();
            }
        }

        private bool ValidarDatosIngresados()
        {
            return
                 txtMonto.Text.Equals("") ||
                 txtDescripcion.Text.Equals("");
        }

        private void LimpiarTextos()
        {
            txtMonto.Text = "";
            txtDescripcion.Text = "";
        }

    }
}
