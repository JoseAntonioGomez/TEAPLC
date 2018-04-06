namespace SISTEMA_TEAPLC.UI
{
    partial class frmReportesPlanillas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesPlanillas));
            this.ConsultarPlanillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TEAPLC_BD = new SISTEMA_TEAPLC.UI.TEAPLC_BD();
            this.rprtVwrPlanillas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsultarPlanillaTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.ConsultarPlanillaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarPlanillaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAPLC_BD)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultarPlanillaBindingSource
            // 
            this.ConsultarPlanillaBindingSource.DataMember = "ConsultarPlanilla";
            this.ConsultarPlanillaBindingSource.DataSource = this.TEAPLC_BD;
            // 
            // TEAPLC_BD
            // 
            this.TEAPLC_BD.DataSetName = "TEAPLC_BD";
            this.TEAPLC_BD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rprtVwrPlanillas
            // 
            this.rprtVwrPlanillas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Planillas";
            reportDataSource1.Value = this.ConsultarPlanillaBindingSource;
            this.rprtVwrPlanillas.LocalReport.DataSources.Add(reportDataSource1);
            this.rprtVwrPlanillas.LocalReport.ReportEmbeddedResource = "SISTEMA_TEAPLC.UI.ReportePlanillaEmpleados.rdlc";
            this.rprtVwrPlanillas.Location = new System.Drawing.Point(0, 0);
            this.rprtVwrPlanillas.Name = "rprtVwrPlanillas";
            this.rprtVwrPlanillas.Size = new System.Drawing.Size(829, 466);
            this.rprtVwrPlanillas.TabIndex = 0;
            // 
            // ConsultarPlanillaTableAdapter
            // 
            this.ConsultarPlanillaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportesPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 466);
            this.Controls.Add(this.rprtVwrPlanillas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportesPlanillas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Planillas";
            this.Load += new System.EventHandler(this.frmReportesPlanillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarPlanillaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAPLC_BD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rprtVwrPlanillas;
        private System.Windows.Forms.BindingSource ConsultarPlanillaBindingSource;
        private TEAPLC_BD TEAPLC_BD;
        private TEAPLC_BDTableAdapters.ConsultarPlanillaTableAdapter ConsultarPlanillaTableAdapter;
    }
}