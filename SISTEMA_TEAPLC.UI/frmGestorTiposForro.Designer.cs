namespace SISTEMA_TEAPLC.UI
{
    partial class frmGestorTiposForro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestorTiposForro));
            this.txtTipoForro = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxTiposForros = new System.Windows.Forms.ListBox();
            this.tablaTiposForrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAPLC_BD = new SISTEMA_TEAPLC.UI.TEAPLC_BD();
            this.tabla_Tipos_ForrosTableAdapter = new SISTEMA_TEAPLC.UI.TEAPLC_BDTableAdapters.Tabla_Tipos_ForrosTableAdapter();
            this.ttMensajes = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiposForrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAPLC_BD)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipoForro
            // 
            this.txtTipoForro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoForro.Location = new System.Drawing.Point(12, 67);
            this.txtTipoForro.Multiline = true;
            this.txtTipoForro.Name = "txtTipoForro";
            this.txtTipoForro.Size = new System.Drawing.Size(326, 26);
            this.txtTipoForro.TabIndex = 82;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.go_back32;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(346, 370);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 39);
            this.btnRegresar.TabIndex = 81;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.edit32;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(346, 106);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 40);
            this.btnModificar.TabIndex = 80;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.Save322;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(346, 152);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.TabIndex = 79;
            this.btnGuardar.Tag = "";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevo.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.add232;
            this.btnAgregarNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(346, 60);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(110, 40);
            this.btnAgregarNuevo.TabIndex = 77;
            this.btnAgregarNuevo.Text = "Agregar";
            this.btnAgregarNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.delete232;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(346, 198);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 40);
            this.btnEliminar.TabIndex = 78;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 51);
            this.label1.TabIndex = 76;
            this.label1.Text = "Agregar Nuevos Tipos de Forros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxTiposForros
            // 
            this.lbxTiposForros.DataSource = this.tablaTiposForrosBindingSource;
            this.lbxTiposForros.DisplayMember = "Descripcion";
            this.lbxTiposForros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTiposForros.FormattingEnabled = true;
            this.lbxTiposForros.ItemHeight = 18;
            this.lbxTiposForros.Location = new System.Drawing.Point(12, 99);
            this.lbxTiposForros.Name = "lbxTiposForros";
            this.lbxTiposForros.Size = new System.Drawing.Size(326, 310);
            this.lbxTiposForros.TabIndex = 75;
            this.lbxTiposForros.ValueMember = "Id_Tipo_Forro";
            // 
            // tablaTiposForrosBindingSource
            // 
            this.tablaTiposForrosBindingSource.DataMember = "Tabla_Tipos_Forros";
            this.tablaTiposForrosBindingSource.DataSource = this.tEAPLC_BD;
            // 
            // tEAPLC_BD
            // 
            this.tEAPLC_BD.DataSetName = "TEAPLC_BD";
            this.tEAPLC_BD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabla_Tipos_ForrosTableAdapter
            // 
            this.tabla_Tipos_ForrosTableAdapter.ClearBeforeFill = true;
            // 
            // ttMensajes
            // 
            this.ttMensajes.IsBalloon = true;
            // 
            // frmGestorTiposForro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(467, 414);
            this.Controls.Add(this.txtTipoForro);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxTiposForros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(483, 453);
            this.MinimumSize = new System.Drawing.Size(483, 453);
            this.Name = "frmGestorTiposForro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Forros";
            this.Load += new System.EventHandler(this.frmGestorTiposForro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiposForrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAPLC_BD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipoForro;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTiposForros;
        private TEAPLC_BD tEAPLC_BD;
        private System.Windows.Forms.BindingSource tablaTiposForrosBindingSource;
        private TEAPLC_BDTableAdapters.Tabla_Tipos_ForrosTableAdapter tabla_Tipos_ForrosTableAdapter;
        private System.Windows.Forms.ToolTip ttMensajes;
    }
}