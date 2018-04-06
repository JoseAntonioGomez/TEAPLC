namespace SISTEMA_TEAPLC.UI
{
    partial class frmGestorCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestorCuentas));
            this.cbxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.tablaTiposCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAPLC_BD = new SISTEMA_TEAPLC.UI.TEAPLC_BD();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cbxBanco = new System.Windows.Forms.ComboBox();
            this.tablaBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.txtCuentaCliente = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.cbxMoneda = new System.Windows.Forms.ComboBox();
            this.tablaMonedasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarBanco = new System.Windows.Forms.Button();
            this.lblNombreColaborador = new System.Windows.Forms.Label();
            this.tabla_BancosTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.Tabla_BancosTableAdapter();
            this.tabla_Tipos_CuentasTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.Tabla_Tipos_CuentasTableAdapter();
            this.tabla_MonedasTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.Tabla_MonedasTableAdapter();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.ttMensajes = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiposCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAPLC_BD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMonedasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipoCuenta
            // 
            this.cbxTipoCuenta.DataSource = this.tablaTiposCuentasBindingSource;
            this.cbxTipoCuenta.DisplayMember = "Descripcion";
            this.cbxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCuenta.FormattingEnabled = true;
            this.cbxTipoCuenta.Location = new System.Drawing.Point(465, 113);
            this.cbxTipoCuenta.Name = "cbxTipoCuenta";
            this.cbxTipoCuenta.Size = new System.Drawing.Size(136, 26);
            this.cbxTipoCuenta.TabIndex = 141;
            this.cbxTipoCuenta.ValueMember = "Id_Tipo_Cuenta";
            // 
            // tablaTiposCuentasBindingSource
            // 
            this.tablaTiposCuentasBindingSource.DataMember = "Tabla_Tipos_Cuentas";
            this.tablaTiposCuentasBindingSource.DataSource = this.tEAPLC_BD;
            // 
            // tEAPLC_BD
            // 
            this.tEAPLC_BD.DataSetName = "TEAPLC_BD";
            this.tEAPLC_BD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.go_back32;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(746, 401);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 39);
            this.btnRegresar.TabIndex = 140;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cbxBanco
            // 
            this.cbxBanco.AccessibleName = "";
            this.cbxBanco.DataSource = this.tablaBancosBindingSource;
            this.cbxBanco.DisplayMember = "Nombre";
            this.cbxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBanco.FormattingEnabled = true;
            this.cbxBanco.Location = new System.Drawing.Point(73, 51);
            this.cbxBanco.Name = "cbxBanco";
            this.cbxBanco.Size = new System.Drawing.Size(291, 26);
            this.cbxBanco.TabIndex = 139;
            this.cbxBanco.ValueMember = "Id_Banco";
            // 
            // tablaBancosBindingSource
            // 
            this.tablaBancosBindingSource.DataMember = "Tabla_Bancos";
            this.tablaBancosBindingSource.DataSource = this.tEAPLC_BD;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.Save322;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(128, 401);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.TabIndex = 138;
            this.btnGuardar.Tag = "";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevo.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.add232;
            this.btnAgregarNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(748, 99);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(110, 40);
            this.btnAgregarNuevo.TabIndex = 137;
            this.btnAgregarNuevo.Text = "Agregar";
            this.btnAgregarNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevo.UseVisualStyleBackColor = false;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.edit32;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(12, 401);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 40);
            this.btnModificar.TabIndex = 136;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.delete232;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(244, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 40);
            this.btnEliminar.TabIndex = 135;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 134;
            this.label1.Text = "Número de Cuenta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(244, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 133;
            this.label2.Text = "Número de Cuenta Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(15, 112);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(226, 26);
            this.txtNumeroCuenta.TabIndex = 132;
            // 
            // txtCuentaCliente
            // 
            this.txtCuentaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCliente.Location = new System.Drawing.Point(247, 112);
            this.txtCuentaCliente.MaxLength = 17;
            this.txtCuentaCliente.Name = "txtCuentaCliente";
            this.txtCuentaCliente.Size = new System.Drawing.Size(212, 26);
            this.txtCuentaCliente.TabIndex = 131;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBanco.Location = new System.Drawing.Point(12, 55);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(55, 18);
            this.lblBanco.TabIndex = 130;
            this.lblBanco.Text = "Banco:";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToResizeColumns = false;
            this.dgvCuentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgvCuentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuentas.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuentas.Location = new System.Drawing.Point(12, 148);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCuentas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            this.dgvCuentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentas.Size = new System.Drawing.Size(844, 247);
            this.dgvCuentas.TabIndex = 129;
            // 
            // cbxMoneda
            // 
            this.cbxMoneda.DataSource = this.tablaMonedasBindingSource;
            this.cbxMoneda.DisplayMember = "Descripcion";
            this.cbxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMoneda.FormattingEnabled = true;
            this.cbxMoneda.Location = new System.Drawing.Point(606, 113);
            this.cbxMoneda.Name = "cbxMoneda";
            this.cbxMoneda.Size = new System.Drawing.Size(136, 26);
            this.cbxMoneda.TabIndex = 143;
            this.cbxMoneda.ValueMember = "Id_Moneda";
            // 
            // tablaMonedasBindingSource
            // 
            this.tablaMonedasBindingSource.DataMember = "Tabla_Monedas";
            this.tablaMonedasBindingSource.DataSource = this.tEAPLC_BD;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(462, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 144;
            this.label3.Text = "Tipo de Cuenta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(604, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 145;
            this.label4.Text = "Moneda:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarBanco
            // 
            this.btnAgregarBanco.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBanco.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.add124;
            this.btnAgregarBanco.Location = new System.Drawing.Point(370, 47);
            this.btnAgregarBanco.Name = "btnAgregarBanco";
            this.btnAgregarBanco.Size = new System.Drawing.Size(35, 33);
            this.btnAgregarBanco.TabIndex = 142;
            this.btnAgregarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarBanco.UseVisualStyleBackColor = false;
            this.btnAgregarBanco.Click += new System.EventHandler(this.btnAgregarBanco_Click);
            // 
            // lblNombreColaborador
            // 
            this.lblNombreColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColaborador.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNombreColaborador.Location = new System.Drawing.Point(0, 0);
            this.lblNombreColaborador.Name = "lblNombreColaborador";
            this.lblNombreColaborador.Size = new System.Drawing.Size(870, 45);
            this.lblNombreColaborador.TabIndex = 146;
            this.lblNombreColaborador.Text = "Cuentas bancarias de:";
            this.lblNombreColaborador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabla_BancosTableAdapter
            // 
            this.tabla_BancosTableAdapter.ClearBeforeFill = true;
            // 
            // tabla_Tipos_CuentasTableAdapter
            // 
            this.tabla_Tipos_CuentasTableAdapter.ClearBeforeFill = true;
            // 
            // tabla_MonedasTableAdapter
            // 
            this.tabla_MonedasTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.refresh32;
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(746, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(112, 39);
            this.btnRefrescar.TabIndex = 147;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // ttMensajes
            // 
            this.ttMensajes.IsBalloon = true;
            // 
            // frmGestorCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(870, 453);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblNombreColaborador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMoneda);
            this.Controls.Add(this.btnAgregarBanco);
            this.Controls.Add(this.cbxTipoCuenta);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cbxBanco);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.txtCuentaCliente);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.dgvCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestorCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Cuentas Bancarias";
            this.Load += new System.EventHandler(this.frmGestorCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiposCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAPLC_BD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMonedasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoCuenta;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cbxBanco;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtCuentaCliente;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.ComboBox cbxMoneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarBanco;
        private System.Windows.Forms.Label lblNombreColaborador;
        private TEAPLC_BD tEAPLC_BD;
        private System.Windows.Forms.BindingSource tablaBancosBindingSource;
        private TEAPLC_BDTableAdapters.Tabla_BancosTableAdapter tabla_BancosTableAdapter;
        private System.Windows.Forms.BindingSource tablaTiposCuentasBindingSource;
        private TEAPLC_BDTableAdapters.Tabla_Tipos_CuentasTableAdapter tabla_Tipos_CuentasTableAdapter;
        private System.Windows.Forms.BindingSource tablaMonedasBindingSource;
        private TEAPLC_BDTableAdapters.Tabla_MonedasTableAdapter tabla_MonedasTableAdapter;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ToolTip ttMensajes;
    }
}