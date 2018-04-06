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
    public partial class frmGestorProyectos : Form
    {
        public frmGestorProyectos()
        {
            InitializeComponent();
            ttMensajes.SetToolTip(txtDescripcion, "Ingrese una descripción del proyecto.");
            ttMensajes.SetToolTip(txtNombre, "Ingrese el nombre del proyecto.");
            ttMensajes.SetToolTip(cbxEmpresas, "Seleccione una empresa.");
            ttMensajes.SetToolTip(cbxEncargados, "Seleccione un encargado.");
            ttMensajes.SetToolTip(btnModificar, "Modificar la información del registro.");
            ttMensajes.SetToolTip(btnEliminar, "Eliminar registro.");
            ttMensajes.SetToolTip(btnGuardar, "Guardar modificaciones de los registros.");
            ttMensajes.SetToolTip(btnAgregarNuevo, "Agregar un nuevo registro.");
            ttMensajes.SetToolTip(btnRegresar, "Regresar a la pantalla principal.");
        }

        public frmPrincipal Principal;
        private Gestor_Proyectos GestorProyectos = new Gestor_Proyectos();

        private void frmGestorProyectos_Load(object sender, EventArgs e)
        {
            this.tabla_ColaboradoresTableAdapter.Fill(this.tEAPLC_BD.Tabla_Colaboradores);
            this.tabla_EmpresasTableAdapter.Fill(this.tEAPLC_BD.Tabla_Empresas);
            cbxEmpresas.Text = "---Seleccione una empresa---";
            cbxEncargados.Text = "---Seleccione un encargado---";
            GestorProyectos.MostrarProyectos(dgvProyectos);
            dgvProyectos.Columns[0].Visible = false;
            btnGuardar.Enabled = false;
        }

        private void CerrarVentanas()
        {
            frmProyectos proyecto = new frmProyectos();
            proyecto.Principal = this.Principal;
            this.Hide();
            proyecto.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Proyecto nuevoProyecto = new Proyecto(); 
            if (!ValidarDatosIngresados())
            {
                nuevoProyecto.Id_Empresa = Convert.ToInt32(cbxEmpresas.SelectedValue.ToString());
                nuevoProyecto.Id_Encargado = Convert.ToInt32(cbxEncargados.SelectedValue.ToString());
                nuevoProyecto.Nombre = txtNombre.Text;
                nuevoProyecto.Descripcion = txtDescripcion.Text;

                if (GestorProyectos.InsertarProyecto(nuevoProyecto))
                {
                    MessageBox.Show("¡Registro ingresado correctamente!", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextos();
                    frmGestorProyectos_Load(sender, e);
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
                cbxEmpresas.Text = dgvProyectos.CurrentRow.Cells[1].Value.ToString();
                cbxEncargados.Text = dgvProyectos.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgvProyectos.CurrentRow.Cells[3].Value.ToString();
                txtDescripcion.Text = dgvProyectos.CurrentRow.Cells[4].Value.ToString();
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
            Proyecto proyecto = new Proyecto();
            try
            {
                if (!ValidarDatosIngresados())
                {
                    proyecto.Id_Proyecto = Convert.ToInt32(dgvProyectos.CurrentRow.Cells[0].Value.ToString());
                    proyecto.Id_Empresa = Convert.ToInt32(cbxEmpresas.SelectedValue.ToString());
                    proyecto.Id_Encargado = Convert.ToInt32(cbxEncargados.SelectedValue.ToString());
                    proyecto.Nombre = txtNombre.Text;
                    proyecto.Descripcion = txtDescripcion.Text;

                    if (GestorProyectos.ModificarProyectos(proyecto))
                    {
                        MessageBox.Show("¡Registro modificado correctamente!", "¡Exito!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTextos();
                        frmGestorProyectos_Load(sender, e);
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
                MessageBox.Show("¡Ocurrio un problema al modificar el registro!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Proyecto proyecto = new Proyecto();
            try
            {
                proyecto.Id_Proyecto = Convert.ToInt32(dgvProyectos.CurrentRow.Cells[0].Value.ToString());
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (GestorProyectos.EliminarProyectos(proyecto))
                    {
                        MessageBox.Show("¡Registro eliminado correctamente", "¡Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("¡No se pudo eliminar registro!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    frmGestorProyectos_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Ocurrio un problema al eliminar el registro!", "¡Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private bool ValidarDatosIngresados()
        {
            return
                 txtDescripcion.Equals("") ||
                 txtNombre.Equals("") ||
                 cbxEmpresas.Equals("---Seleccione una empresa---") ||
                 cbxEncargados.Equals("---Seleccione un encargado---");
        }

        private void LimpiarTextos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cbxEmpresas.Text = "---Seleccione una empresa---";
            cbxEncargados.Text = "---Seleccione un encargado---";
        }

        private void frmGestorProyectos_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarVentanas();
        }
    }
}
