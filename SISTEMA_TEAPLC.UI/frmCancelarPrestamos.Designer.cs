namespace SISTEMA_TEAPLC.UI
{
    partial class frmCancelarPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelarPrestamos));
            this.tablaTiposTrabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAPLC_BD = new SISTEMA_TEAPLC.UI.TEAPLC_BD();
            this.tabla_Tipos_TrabajosTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.Tabla_Tipos_TrabajosTableAdapter();
            this.lblNombreColaborador = new System.Windows.Forms.Label();
            this.txtMontoCancelar = new System.Windows.Forms.TextBox();
            this.ttMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.lblMontoCancelado = new System.Windows.Forms.Label();
            this.btnCancelarUnPrestamo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelarTodosLosPrestamos = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificarMontoPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiposTrabajosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAPLC_BD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaTiposTrabajosBindingSource
            // 
            this.tablaTiposTrabajosBindingSource.DataMember = "Tabla_Tipos_Trabajos";
            this.tablaTiposTrabajosBindingSource.DataSource = this.tEAPLC_BD;
            // 
            // tEAPLC_BD
            // 
            this.tEAPLC_BD.DataSetName = "TEAPLC_BD";
            this.tEAPLC_BD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabla_Tipos_TrabajosTableAdapter
            // 
            this.tabla_Tipos_TrabajosTableAdapter.ClearBeforeFill = true;
            // 
            // lblNombreColaborador
            // 
            this.lblNombreColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColaborador.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNombreColaborador.Location = new System.Drawing.Point(0, 0);
            this.lblNombreColaborador.Name = "lblNombreColaborador";
            this.lblNombreColaborador.Size = new System.Drawing.Size(661, 51);
            this.lblNombreColaborador.TabIndex = 68;
            this.lblNombreColaborador.Text = "Cancelar Prestamos:  ";
            this.lblNombreColaborador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMontoCancelar
            // 
            this.txtMontoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCancelar.Location = new System.Drawing.Point(12, 77);
            this.txtMontoCancelar.Multiline = true;
            this.txtMontoCancelar.Name = "txtMontoCancelar";
            this.txtMontoCancelar.Size = new System.Drawing.Size(253, 26);
            this.txtMontoCancelar.TabIndex = 74;
            // 
            // ttMensajes
            // 
            this.ttMensajes.IsBalloon = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Monto a cancelar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToResizeColumns = false;
            this.dgvPrestamos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgvPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamos.Location = new System.Drawing.Point(12, 116);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestamos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            this.dgvPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(637, 212);
            this.dgvPrestamos.TabIndex = 98;
            // 
            // lblMontoCancelado
            // 
            this.lblMontoCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoCancelado.AutoSize = true;
            this.lblMontoCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCancelado.ForeColor = System.Drawing.Color.Blue;
            this.lblMontoCancelado.Location = new System.Drawing.Point(225, 344);
            this.lblMontoCancelado.Name = "lblMontoCancelado";
            this.lblMontoCancelado.Size = new System.Drawing.Size(187, 20);
            this.lblMontoCancelado.TabIndex = 99;
            this.lblMontoCancelado.Text = "Monto a cancelar (₡): ";
            this.lblMontoCancelado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelarUnPrestamo
            // 
            this.btnCancelarUnPrestamo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarUnPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarUnPrestamo.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.coin_us_dollar;
            this.btnCancelarUnPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarUnPrestamo.Location = new System.Drawing.Point(335, 70);
            this.btnCancelarUnPrestamo.Name = "btnCancelarUnPrestamo";
            this.btnCancelarUnPrestamo.Size = new System.Drawing.Size(145, 40);
            this.btnCancelarUnPrestamo.TabIndex = 102;
            this.btnCancelarUnPrestamo.Tag = "";
            this.btnCancelarUnPrestamo.Text = "Cancelar Uno";
            this.btnCancelarUnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarUnPrestamo.UseVisualStyleBackColor = false;
            this.btnCancelarUnPrestamo.Click += new System.EventHandler(this.btnCancelarUnPrestamo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.Success;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(548, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 40);
            this.btnAceptar.TabIndex = 100;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelarTodosLosPrestamos
            // 
            this.btnCancelarTodosLosPrestamos.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarTodosLosPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTodosLosPrestamos.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.coins;
            this.btnCancelarTodosLosPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarTodosLosPrestamos.Location = new System.Drawing.Point(491, 70);
            this.btnCancelarTodosLosPrestamos.Name = "btnCancelarTodosLosPrestamos";
            this.btnCancelarTodosLosPrestamos.Size = new System.Drawing.Size(158, 40);
            this.btnCancelarTodosLosPrestamos.TabIndex = 101;
            this.btnCancelarTodosLosPrestamos.Text = "Cancelar Todos";
            this.btnCancelarTodosLosPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarTodosLosPrestamos.UseVisualStyleBackColor = false;
            this.btnCancelarTodosLosPrestamos.Click += new System.EventHandler(this.btnCancelarTodosLosPrestamos_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.go_back32;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(537, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 39);
            this.btnRegresar.TabIndex = 73;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificarMontoPrestamo
            // 
            this.btnModificarMontoPrestamo.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarMontoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMontoPrestamo.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.edit32;
            this.btnModificarMontoPrestamo.Location = new System.Drawing.Point(271, 70);
            this.btnModificarMontoPrestamo.Name = "btnModificarMontoPrestamo";
            this.btnModificarMontoPrestamo.Size = new System.Drawing.Size(41, 40);
            this.btnModificarMontoPrestamo.TabIndex = 103;
            this.btnModificarMontoPrestamo.Tag = "";
            this.btnModificarMontoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMontoPrestamo.UseVisualStyleBackColor = false;
            this.btnModificarMontoPrestamo.Click += new System.EventHandler(this.btnModificarMontoPrestamo_Click);
            // 
            // frmCancelarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(661, 385);
            this.Controls.Add(this.btnModificarMontoPrestamo);
            this.Controls.Add(this.btnCancelarUnPrestamo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelarTodosLosPrestamos);
            this.Controls.Add(this.lblMontoCancelado);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontoCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblNombreColaborador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCancelarPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos a Cancelar";
            this.Load += new System.EventHandler(this.frmCancelarPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiposTrabajosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAPLC_BD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TEAPLC_BD tEAPLC_BD;
        private System.Windows.Forms.BindingSource tablaTiposTrabajosBindingSource;
        private TEAPLC_BDTableAdapters.Tabla_Tipos_TrabajosTableAdapter tabla_Tipos_TrabajosTableAdapter;
        private System.Windows.Forms.Label lblNombreColaborador;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtMontoCancelar;
        private System.Windows.Forms.ToolTip ttMensajes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label lblMontoCancelado;
        private System.Windows.Forms.Button btnCancelarUnPrestamo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelarTodosLosPrestamos;
        private System.Windows.Forms.Button btnModificarMontoPrestamo;
    }
}