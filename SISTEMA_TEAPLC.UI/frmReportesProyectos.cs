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
using Microsoft.Reporting.WinForms;

namespace SISTEMA_TEAPLC.UI
{
    public partial class frmReportesProyectos : Form
    {
        public Trabajo Trabajo;
        public Proyecto Proyecto;
        DateTime Hoy = DateTime.Today;
       
        public frmReportesProyectos(Trabajo trabajo, Proyecto proyecto)
        {
            InitializeComponent();
            ttMensajes.SetToolTip(txtPersona, "Ingrese el nombre de la (as) persona (as) que dirige el mensaje.");
            ttMensajes.SetToolTip(txtMensaje, "Ingrese el mensaje.");
            ttMensajes.SetToolTip(btnAceptar, "Aceptar.");
            Trabajo = trabajo;
            Proyecto = proyecto;
        }
        public frmReportesProyectos()
        {

        }
        
        private void frmReportesProyectos_Load(object sender, EventArgs e)
        {
            this.ConsultarReporteTableAdapter.Fill(this.TEAPLC_BD.ConsultarReporte, Trabajo.Id_Proyecto);
            this.ConsultarCuentasTableAdapter.Fill(this.TEAPLC_BD.ConsultarCuentas, Proyecto.Id_Encargado);
            EnviarParametros();
            this.WindowState = FormWindowState.Maximized;
            rprtVwrProyecto.RefreshReport();
        }

        private void EnviarParametros()
        {
            string persona = " ";
            string mensaje = " ";
            string nota = " ";
            string fecha_actual = Hoy.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            ReportParameter fecha = new ReportParameter("Fecha", fecha_actual);
            this.rprtVwrProyecto.LocalReport.SetParameters(fecha);
            ReportParameter personaPar = new ReportParameter("Persona", persona);
            this.rprtVwrProyecto.LocalReport.SetParameters(personaPar);
            ReportParameter mensajePar = new ReportParameter("Mensaje", mensaje);
            this.rprtVwrProyecto.LocalReport.SetParameters(mensajePar);
            ReportParameter notaPar = new ReportParameter("Nota", nota);
            this.rprtVwrProyecto.LocalReport.SetParameters(notaPar);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool estanVacias = txtPersona.Text.Equals("") || txtMensaje.Text.Equals("") || txtNota.Text.Equals("");

            if (!estanVacias)
            {
                ReportParameter persona = new ReportParameter("Persona", txtPersona.Text);
                this.rprtVwrProyecto.LocalReport.SetParameters(persona);
                ReportParameter mensaje = new ReportParameter("Mensaje", txtMensaje.Text);
                this.rprtVwrProyecto.LocalReport.SetParameters(mensaje);
                ReportParameter notaPar = new ReportParameter("Nota", txtNota.Text);
                this.rprtVwrProyecto.LocalReport.SetParameters(notaPar);
                rprtVwrProyecto.RefreshReport();
            }
            else
            {
                MessageBox.Show("¡Debe de registrar los datos!", "¡Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
