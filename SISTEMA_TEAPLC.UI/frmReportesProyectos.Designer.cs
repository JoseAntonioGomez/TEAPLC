namespace SISTEMA_TEAPLC.UI
{
    partial class frmReportesProyectos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesProyectos));
            this.ConsultarReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TEAPLC_BD = new SISTEMA_TEAPLC.UI.TEAPLC_BD();
            this.ConsultarCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConsultarTrabajosProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rprtVwrProyecto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tabla_TrabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConsultarTrabajosProyectoTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.ConsultarTrabajosProyectoTableAdapter();
            this.ConsultarReporteTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.ConsultarReporteTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ttMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultarCuentasTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.ConsultarCuentasTableAdapter();
            this.Tabla_TrabajosTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.Tabla_TrabajosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAPLC_BD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarTrabajosProyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_TrabajosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultarReporteBindingSource
            // 
            this.ConsultarReporteBindingSource.DataMember = "ConsultarReporte";
            this.ConsultarReporteBindingSource.DataSource = this.TEAPLC_BD;
            // 
            // TEAPLC_BD
            // 
            this.TEAPLC_BD.DataSetName = "TEAPLC_BD";
            this.TEAPLC_BD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConsultarCuentasBindingSource
            // 
            this.ConsultarCuentasBindingSource.DataMember = "ConsultarCuentas";
            this.ConsultarCuentasBindingSource.DataSource = this.TEAPLC_BD;
            // 
            // ConsultarTrabajosProyectoBindingSource
            // 
            this.ConsultarTrabajosProyectoBindingSource.DataMember = "ConsultarTrabajosProyecto";
            this.ConsultarTrabajosProyectoBindingSource.DataSource = this.TEAPLC_BD;
            // 
            // rprtVwrProyecto
            // 
            this.rprtVwrProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.ConsultarReporteBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ConsultarCuentasBindingSource;
            this.rprtVwrProyecto.LocalReport.DataSources.Add(reportDataSource1);
            this.rprtVwrProyecto.LocalReport.DataSources.Add(reportDataSource2);
            this.rprtVwrProyecto.LocalReport.ReportEmbeddedResource = "SISTEMA_TEAPLC.UI.ReporteTrabajosProyecto.rdlc";
            this.rprtVwrProyecto.Location = new System.Drawing.Point(0, 162);
            this.rprtVwrProyecto.Name = "rprtVwrProyecto";
            this.rprtVwrProyecto.Size = new System.Drawing.Size(910, 388);
            this.rprtVwrProyecto.TabIndex = 0;
            // 
            // Tabla_TrabajosBindingSource
            // 
            this.Tabla_TrabajosBindingSource.DataMember = "Tabla_Trabajos";
            this.Tabla_TrabajosBindingSource.DataSource = this.TEAPLC_BD;
            // 
            // ConsultarTrabajosProyectoTableAdapter
            // 
            this.ConsultarTrabajosProyectoTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultarReporteTableAdapter
            // 
            this.ConsultarReporteTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mensaje:";
            // 
            // txtPersona
            // 
            this.txtPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersona.Location = new System.Drawing.Point(86, 12);
            this.txtPersona.Multiline = true;
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(685, 25);
            this.txtPersona.TabIndex = 3;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(86, 43);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(685, 43);
            this.txtMensaje.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.Success;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(777, 95);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ttMensajes
            // 
            this.ttMensajes.IsBalloon = true;
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(86, 92);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(685, 43);
            this.txtNota.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota:";
            // 
            // ConsultarCuentasTableAdapter
            // 
            this.ConsultarCuentasTableAdapter.ClearBeforeFill = true;
            // 
            // Tabla_TrabajosTableAdapter
            // 
            this.Tabla_TrabajosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportesProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(910, 550);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rprtVwrProyecto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportesProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Proyectos";
            this.Load += new System.EventHandler(this.frmReportesProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAPLC_BD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarTrabajosProyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_TrabajosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rprtVwrProyecto;
        private System.Windows.Forms.BindingSource Tabla_TrabajosBindingSource;
        private TEAPLC_BD TEAPLC_BD;
        private System.Windows.Forms.BindingSource ConsultarTrabajosProyectoBindingSource;
        private TEAPLC_BDTableAdapters.ConsultarTrabajosProyectoTableAdapter ConsultarTrabajosProyectoTableAdapter;
        private System.Windows.Forms.BindingSource ConsultarReporteBindingSource;
        private TEAPLC_BDTableAdapters.ConsultarReporteTableAdapter ConsultarReporteTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolTip ttMensajes;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ConsultarCuentasBindingSource;
        private TEAPLC_BDTableAdapters.ConsultarCuentasTableAdapter ConsultarCuentasTableAdapter;
        private TEAPLC_BDTableAdapters.Tabla_TrabajosTableAdapter Tabla_TrabajosTableAdapter;
    }
}