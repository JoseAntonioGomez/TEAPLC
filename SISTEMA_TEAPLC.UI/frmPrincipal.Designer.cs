namespace SISTEMA_TEAPLC.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mitmProyectos = new System.Windows.Forms.ToolStripMenuItem();
            this.itmProyectos = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmPlanillas = new System.Windows.Forms.ToolStripMenuItem();
            this.itmPlanilla = new System.Windows.Forms.ToolStripMenuItem();
            this.itmColaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.itmPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEditarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnEmpresas = new System.Windows.Forms.Button();
            this.btnPlanillas = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.DarkGray;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmProyectos,
            this.mitmPlanillas,
            this.mitmUsuario,
            this.mitmSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(971, 25);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mitmProyectos
            // 
            this.mitmProyectos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmProyectos,
            this.itmEmpresas});
            this.mitmProyectos.Name = "mitmProyectos";
            this.mitmProyectos.Size = new System.Drawing.Size(77, 21);
            this.mitmProyectos.Text = "Proyectos";
            // 
            // itmProyectos
            // 
            this.itmProyectos.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.my_docs_48x48;
            this.itmProyectos.Name = "itmProyectos";
            this.itmProyectos.Size = new System.Drawing.Size(133, 22);
            this.itmProyectos.Text = "Proyectos";
            this.itmProyectos.Click += new System.EventHandler(this.itmProyectos_Click);
            // 
            // itmEmpresas
            // 
            this.itmEmpresas.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.company_32x32;
            this.itmEmpresas.Name = "itmEmpresas";
            this.itmEmpresas.Size = new System.Drawing.Size(133, 22);
            this.itmEmpresas.Text = "Empresas";
            this.itmEmpresas.Click += new System.EventHandler(this.itmEmpresas_Click);
            // 
            // mitmPlanillas
            // 
            this.mitmPlanillas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmPlanilla,
            this.itmColaboradores,
            this.itmPrestamos});
            this.mitmPlanillas.Name = "mitmPlanillas";
            this.mitmPlanillas.Size = new System.Drawing.Size(66, 21);
            this.mitmPlanillas.Text = "Planillas";
            // 
            // itmPlanilla
            // 
            this.itmPlanilla.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.sales_report24;
            this.itmPlanilla.Name = "itmPlanilla";
            this.itmPlanilla.Size = new System.Drawing.Size(141, 22);
            this.itmPlanilla.Text = "Planillas";
            this.itmPlanilla.Click += new System.EventHandler(this.itmPlanilla_Click);
            // 
            // itmColaboradores
            // 
            this.itmColaboradores.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.man24;
            this.itmColaboradores.Name = "itmColaboradores";
            this.itmColaboradores.Size = new System.Drawing.Size(141, 22);
            this.itmColaboradores.Text = "Empleados";
            this.itmColaboradores.Click += new System.EventHandler(this.itmColaboradores_Click);
            // 
            // itmPrestamos
            // 
            this.itmPrestamos.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.cash;
            this.itmPrestamos.Name = "itmPrestamos";
            this.itmPrestamos.Size = new System.Drawing.Size(141, 22);
            this.itmPrestamos.Text = "Prestamos";
            this.itmPrestamos.Click += new System.EventHandler(this.itmPrestamos_Click);
            // 
            // mitmUsuario
            // 
            this.mitmUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmEditarUsuario});
            this.mitmUsuario.Name = "mitmUsuario";
            this.mitmUsuario.Size = new System.Drawing.Size(65, 21);
            this.mitmUsuario.Text = "Usuario";
            // 
            // itmEditarUsuario
            // 
            this.itmEditarUsuario.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.keys24;
            this.itmEditarUsuario.Name = "itmEditarUsuario";
            this.itmEditarUsuario.Size = new System.Drawing.Size(159, 22);
            this.itmEditarUsuario.Text = "Editar Usuario";
            this.itmEditarUsuario.Click += new System.EventHandler(this.itmEditarUsuario_Click);
            // 
            // mitmSalir
            // 
            this.mitmSalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCerrarSesión});
            this.mitmSalir.Name = "mitmSalir";
            this.mitmSalir.Size = new System.Drawing.Size(45, 21);
            this.mitmSalir.Text = "Salir";
            // 
            // itmCerrarSesión
            // 
            this.itmCerrarSesión.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.Logout;
            this.itmCerrarSesión.Name = "itmCerrarSesión";
            this.itmCerrarSesión.Size = new System.Drawing.Size(171, 22);
            this.itmCerrarSesión.Text = "Salir del sistema";
            this.itmCerrarSesión.Click += new System.EventHandler(this.itmCerrarSesión_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnColaboradores);
            this.panel1.Controls.Add(this.btnPrestamos);
            this.panel1.Controls.Add(this.btnEmpresas);
            this.panel1.Controls.Add(this.btnPlanillas);
            this.panel1.Controls.Add(this.btnProyectos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 508);
            this.panel1.TabIndex = 14;
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnColaboradores.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaboradores.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.Man;
            this.btnColaboradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColaboradores.Location = new System.Drawing.Point(823, 16);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(122, 156);
            this.btnColaboradores.TabIndex = 18;
            this.btnColaboradores.Text = "Empleados";
            this.btnColaboradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrestamos.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.cash__2_;
            this.btnPrestamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrestamos.Location = new System.Drawing.Point(631, 16);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(122, 156);
            this.btnPrestamos.TabIndex = 17;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnEmpresas
            // 
            this.btnEmpresas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEmpresas.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnEmpresas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEmpresas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresas.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.company_128x128;
            this.btnEmpresas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpresas.Location = new System.Drawing.Point(430, 16);
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.Size = new System.Drawing.Size(122, 156);
            this.btnEmpresas.TabIndex = 16;
            this.btnEmpresas.Text = "Empresas";
            this.btnEmpresas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpresas.UseVisualStyleBackColor = true;
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            // 
            // btnPlanillas
            // 
            this.btnPlanillas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlanillas.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnPlanillas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPlanillas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanillas.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.Sales_report128;
            this.btnPlanillas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlanillas.Location = new System.Drawing.Point(232, 16);
            this.btnPlanillas.Name = "btnPlanillas";
            this.btnPlanillas.Size = new System.Drawing.Size(122, 156);
            this.btnPlanillas.TabIndex = 15;
            this.btnPlanillas.Text = "Planillas";
            this.btnPlanillas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlanillas.UseVisualStyleBackColor = true;
            this.btnPlanillas.Click += new System.EventHandler(this.btnPlanillas_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProyectos.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnProyectos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnProyectos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.my_docs_128x128;
            this.btnProyectos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProyectos.Location = new System.Drawing.Point(32, 16);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(120, 156);
            this.btnProyectos.TabIndex = 14;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProyectos.UseVisualStyleBackColor = true;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SISTEMA_TEAPLC.UI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEAPLC - Todo en Acabados para la Construcción";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mitmProyectos;
        private System.Windows.Forms.ToolStripMenuItem itmProyectos;
        private System.Windows.Forms.ToolStripMenuItem mitmPlanillas;
        private System.Windows.Forms.ToolStripMenuItem mitmUsuario;
        private System.Windows.Forms.ToolStripMenuItem itmPlanilla;
        private System.Windows.Forms.ToolStripMenuItem itmEditarUsuario;
        private System.Windows.Forms.ToolStripMenuItem itmColaboradores;
        private System.Windows.Forms.ToolStripMenuItem mitmSalir;
        private System.Windows.Forms.ToolStripMenuItem itmCerrarSesión;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem itmEmpresas;
        private System.Windows.Forms.ToolStripMenuItem itmPrestamos;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnEmpresas;
        private System.Windows.Forms.Button btnPlanillas;
        private System.Windows.Forms.Button btnProyectos;
    }
}

