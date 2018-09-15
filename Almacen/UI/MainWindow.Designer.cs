namespace Almacen
{
    partial class MainWindow
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
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.hacerInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(12, 27);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(776, 411);
            this.dgvResultados.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.adicionalToolStripMenuItem,
            this.personasToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarInventarioToolStripMenuItem,
            this.hacerInventarioToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // mostrarInventarioToolStripMenuItem
            // 
            this.mostrarInventarioToolStripMenuItem.Name = "mostrarInventarioToolStripMenuItem";
            this.mostrarInventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarInventarioToolStripMenuItem.Text = "Mostrar inventario";
            this.mostrarInventarioToolStripMenuItem.Click += new System.EventHandler(this.mostrarInventarioToolStripMenuItem_Click);
            // 
            // adicionalToolStripMenuItem
            // 
            this.adicionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarCategoriasToolStripMenuItem,
            this.mostrarEstadosToolStripMenuItem,
            this.mostrarArticulosToolStripMenuItem,
            this.nuevaCategoriaToolStripMenuItem,
            this.nuevoEstadoToolStripMenuItem,
            this.nuevoArticuloToolStripMenuItem,
            this.editarArticuloToolStripMenuItem});
            this.adicionalToolStripMenuItem.Name = "adicionalToolStripMenuItem";
            this.adicionalToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.adicionalToolStripMenuItem.Text = "Adicional";
            // 
            // mostrarCategoriasToolStripMenuItem
            // 
            this.mostrarCategoriasToolStripMenuItem.Name = "mostrarCategoriasToolStripMenuItem";
            this.mostrarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarCategoriasToolStripMenuItem.Text = "Mostrar categorias";
            this.mostrarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.mostrarCategoriasToolStripMenuItem_Click);
            // 
            // mostrarEstadosToolStripMenuItem
            // 
            this.mostrarEstadosToolStripMenuItem.Name = "mostrarEstadosToolStripMenuItem";
            this.mostrarEstadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarEstadosToolStripMenuItem.Text = "Mostrar estados";
            this.mostrarEstadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEstadosToolStripMenuItem_Click);
            // 
            // mostrarArticulosToolStripMenuItem
            // 
            this.mostrarArticulosToolStripMenuItem.Name = "mostrarArticulosToolStripMenuItem";
            this.mostrarArticulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarArticulosToolStripMenuItem.Text = "Mostrar articulos";
            this.mostrarArticulosToolStripMenuItem.Click += new System.EventHandler(this.mostrarArticulosToolStripMenuItem_Click);
            // 
            // nuevaCategoriaToolStripMenuItem
            // 
            this.nuevaCategoriaToolStripMenuItem.Name = "nuevaCategoriaToolStripMenuItem";
            this.nuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaCategoriaToolStripMenuItem.Text = "Nueva categoria";
            this.nuevaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCategoriaToolStripMenuItem_Click);
            // 
            // nuevoEstadoToolStripMenuItem
            // 
            this.nuevoEstadoToolStripMenuItem.Name = "nuevoEstadoToolStripMenuItem";
            this.nuevoEstadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoEstadoToolStripMenuItem.Text = "Nuevo estado";
            this.nuevoEstadoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEstadoToolStripMenuItem_Click);
            // 
            // nuevoArticuloToolStripMenuItem
            // 
            this.nuevoArticuloToolStripMenuItem.Name = "nuevoArticuloToolStripMenuItem";
            this.nuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoArticuloToolStripMenuItem.Text = "Nuevo articulo";
            this.nuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.ingresaArticuloToolStripMenuItem_Click);
            // 
            // editarArticuloToolStripMenuItem
            // 
            this.editarArticuloToolStripMenuItem.Name = "editarArticuloToolStripMenuItem";
            this.editarArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarArticuloToolStripMenuItem.Text = "Borrar articulo";
            this.editarArticuloToolStripMenuItem.Click += new System.EventHandler(this.editarArticuloToolStripMenuItem_Click);
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarPersonaToolStripMenuItem,
            this.nuevoToolStripMenuItem});
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personasToolStripMenuItem.Text = "Personal";
            // 
            // mostrarPersonaToolStripMenuItem
            // 
            this.mostrarPersonaToolStripMenuItem.Name = "mostrarPersonaToolStripMenuItem";
            this.mostrarPersonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarPersonaToolStripMenuItem.Text = "Mostrar empleados";
            this.mostrarPersonaToolStripMenuItem.Click += new System.EventHandler(this.mostrarPersonaToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo empleado";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proximamenteToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // proximamenteToolStripMenuItem
            // 
            this.proximamenteToolStripMenuItem.Name = "proximamenteToolStripMenuItem";
            this.proximamenteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.proximamenteToolStripMenuItem.Text = "Proximamente...";
            this.proximamenteToolStripMenuItem.Click += new System.EventHandler(this.proximamenteToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslUser,
            this.toolStripStatusLabel2,
            this.tsslRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(17, 17);
            this.tsslUser.Text = "--";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel2.Text = "Rol:";
            // 
            // tsslRole
            // 
            this.tsslRole.Name = "tsslRole";
            this.tsslRole.Size = new System.Drawing.Size(17, 17);
            this.tsslRole.Text = "--";
            // 
            // hacerInventarioToolStripMenuItem
            // 
            this.hacerInventarioToolStripMenuItem.Name = "hacerInventarioToolStripMenuItem";
            this.hacerInventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hacerInventarioToolStripMenuItem.Text = "Hacer inventario";
            this.hacerInventarioToolStripMenuItem.Click += new System.EventHandler(this.hacerInventarioToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEstadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslRole;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerInventarioToolStripMenuItem;
    }
}

