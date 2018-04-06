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
    public partial class frmGestorActividades : Form
    {
        public Colaborador Colaborador;
        private Gestor_Actividades GestorActividades = new Gestor_Actividades();
        public frmColaborador frmColaborador;

        public frmGestorActividades()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(lblNombreColaborador, "Nombre del colaborador.");
            ttMensajes.SetToolTip(dtpFechaInicio, "Seleccione la fecha de inicio");
            ttMensajes.SetToolTip(dtpFechaFinaliza, "Seleccione la fcha de finalización");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar un registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar un nuevo resgistro.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla principal.");
        }

        private void frmGestorActividades_Load(object sender, EventArgs e)
        {
            MostrarConsultarActividadesPorColaborador();
            btnGuardar.Enabled = false;
            this.MostrarNombreColaborador(Colaborador.Nombre);
        }

        public void MostrarNombreColaborador(string nombre)
        {
            lblNombreColaborador.Text = string.Format("Tiempo de actividad de: {0}", nombre);
        }

        private void MostrarConsultarActividadesPorColaborador()
        {
            try
            {
                Actividad actividad = new Actividad();
                actividad.Id_Colaborador = Colaborador.Id_Colaborador;
                GestorActividades.ConsultarActividadesPorColaborador(actividad, dgvActividades);
                dgvActividades.Columns[0].Visible = false;
                dgvActividades.Columns[1].HeaderText = "Nombre";
                dgvActividades.Columns[2].HeaderText = "Fecha de Inicio";
                dgvActividades.Columns[3].HeaderText = "Fecha de Finalización";
                dgvActividades.Columns[4].HeaderText = "Cantidad de Meses";
            }
            catch (Exception)
            {
                MessageBox.Show("¡Error, Ocurrio un problema!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Actividad actividad = new Actividad();
            try
            {
                actividad.Id_Colaborador = Colaborador.Id_Colaborador;
                actividad.Fecha_Inicio = Convert.ToDateTime(dtpFechaInicio.Text);
                actividad.Fecha_Finaliza = Convert.ToDateTime(dtpFechaFinaliza.Text);
                if (GestorActividades.InsertarActividadColaborador(actividad))
                {
                    MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarConsultarActividadesPorColaborador();
                }
                else
                {
                    MessageBox.Show("¡Registro no se pudo ingresar!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Error, Ocurrio un problema!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                dtpFechaInicio.Text = dgvActividades.CurrentRow.Cells[2].Value.ToString();
                dtpFechaFinaliza.Text = dgvActividades.CurrentRow.Cells[3].Value.ToString();
                btnAgregarNuevo.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Error, Ocurrio un problema!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actividad actividad = new Actividad();
            try
            {
                actividad.Id_Actividad = Convert.ToInt32(dgvActividades.CurrentRow.Cells[0].Value.ToString());
                actividad.Id_Colaborador = Colaborador.Id_Colaborador;
                actividad.Fecha_Inicio = Convert.ToDateTime(dtpFechaInicio.Text);
                actividad.Fecha_Finaliza = Convert.ToDateTime(dtpFechaFinaliza.Text);
                if (GestorActividades.ModificarActividadColaborador(actividad))
                {
                    MessageBox.Show("¡Registro modificado correctamente!", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarConsultarActividadesPorColaborador();
                    btnAgregarNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("¡Registro no se pudo modificar!", "¡Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Error, seleccione el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Actividad actividad = new Actividad();
            try
            {
                actividad.Id_Actividad = Convert.ToInt32(dgvActividades.CurrentRow.Cells[0].Value.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorActividades.EliminarActividadColaborador(actividad))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarConsultarActividadesPorColaborador();
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
                MessageBox.Show("¡Error, seleccione el registro!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
