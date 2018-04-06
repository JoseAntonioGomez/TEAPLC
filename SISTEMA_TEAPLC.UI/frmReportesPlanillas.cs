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
    public partial class frmReportesPlanillas : Form
    {
        Planilla Planilla;
        public frmReportesPlanillas(Planilla planilla)
        {
            InitializeComponent();
            Planilla = planilla;
        }

        private void frmReportesPlanillas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TEAPLC_BD.ConsultarPlanilla' Puede moverla o quitarla según sea necesario.
            this.ConsultarPlanillaTableAdapter.Fill(this.TEAPLC_BD.ConsultarPlanilla, Planilla.Fecha.Date);
            EnviarParametros();
            this.rprtVwrPlanillas.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
        }

        private void EnviarParametros()
        {
            string fechaPlanilla = Planilla.Fecha.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            ReportParameter fecha = new ReportParameter("Fecha", fechaPlanilla);
            this.rprtVwrPlanillas.LocalReport.SetParameters(fecha);
        }
    }
}
