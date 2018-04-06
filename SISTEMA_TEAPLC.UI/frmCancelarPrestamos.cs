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
    public partial class frmCancelarPrestamos : Form
    {
        private Gestor_Prestamos GestorPrestamos = new Gestor_Prestamos();
        public Colaborador Colaborador;
        private double MontoPendiente { get; set; }
        public frmPlanilla Planilla;

        public frmCancelarPrestamos()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(txtMontoCancelar, "Ingrese el monto a cancelar del pretamo seleccionado.");
            ttMensajes.SetToolTip(btnModificarMontoPrestamo, "Modificar el prestamo seleccionado.");
            ttMensajes.SetToolTip(btnCancelarTodosLosPrestamos, "Cancelar todos los prestamos.");
            ttMensajes.SetToolTip(btnCancelarUnPrestamo, "Cancelar un prestamo seleccionado.");
            ttMensajes.SetToolTip(btnAceptar, "Aceptar Monto a cancelar de los prestamos.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla de planillas.");
            ttMensajes.SetToolTip(lblMontoCancelado, "Monto total a cancelar de los prestamos.");
        }
       
        private void frmCancelarPrestamos_Load(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            try
            {                
                prestamo.Id_Colaborador = Colaborador.Id_Colaborador;
                prestamo.Id_Estado = 1;
                lblNombreColaborador.Text = "Cancelar Prestamos: " + Colaborador.Nombre;
                GestorPrestamos.ConsultarPrestamos(prestamo,dgvPrestamos);
                dgvPrestamos.Columns[0].Visible = false;
                dgvPrestamos.Columns[1].HeaderText = "Nombre";
                dgvPrestamos.Columns[2].HeaderText = "Descripción";
                dgvPrestamos.Columns[3].HeaderText = "Monto Prestamo";
                dgvPrestamos.Columns[4].HeaderText = "Monto Pendiente";
                lblMontoCancelado.Text = "Monto a cancelar (₡): " + MontoPendiente;
                btnCancelarUnPrestamo.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void btnCancelarUnPrestamo_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            try
            {
                if (!txtMontoCancelar.Equals(""))
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cancelar este monton del prestamo?",
                "Cancelar Prestamos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        prestamo.Id_Prestamo = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells[0].Value.ToString());
                        prestamo.MontoPendiente = txtMontoCancelar.Text;
                        if (GestorPrestamos.CancelarUnPrestamo(prestamo))
                        {
                            MessageBox.Show("¡Cancelo monto del prestamo correctamente!", "¡Exito!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            double monto = Convert.ToDouble(txtMontoCancelar.Text.Replace(".0000", ",0000"));
                            MontoPendiente = MontoPendiente + monto;
                            MostrarMontoPrestamo(MontoPendiente);

                        }
                        else
                        {
                            MessageBox.Show("¡Error, no se cancelo el monto!", "¡Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                   
                }
                else
                {
                    MessageBox.Show("¡Debe de ingresar todos los datos!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtMontoCancelar.Text = "";
                frmCancelarPrestamos_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancelarTodosLosPrestamos_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cancelar todos los prestamos?",
                "Cancelar Prestamos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    prestamo.Id_Colaborador = Colaborador.Id_Colaborador;
                    MontoPendiente = Convert.ToDouble(GestorPrestamos.CancelarTodosLosPrestamosPorColaborador(prestamo).Replace(".0000", ",0000"));
                    MostrarMontoPrestamo(MontoPendiente);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Ocurrio un problema!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }

        private void btnModificarMontoPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                txtMontoCancelar.Text = dgvPrestamos.CurrentRow.Cells[4].Value.ToString().Replace(",", ".");
                btnCancelarUnPrestamo.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Debe de seleccionar un resgistro!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Planilla.MostrarMontoPrestamo(MontoPendiente);
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("¡Debe de seleccionar un resgistro!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarMontoPrestamo(double montoPrestamo)
        {
            MontoPendiente = montoPrestamo;
            lblMontoCancelado.Text = string.Format("Monto a cancelar (₡): {0}", montoPrestamo);
        }
    }
}
