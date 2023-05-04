namespace pryDemeterDatos
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
            this.msPantallaDeInicio = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPantallaDeInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPantallaDeInicio
            // 
            this.msPantallaDeInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.linealesToolStripMenuItem,
            this.noLinealesToolStripMenuItem});
            this.msPantallaDeInicio.Location = new System.Drawing.Point(0, 0);
            this.msPantallaDeInicio.Name = "msPantallaDeInicio";
            this.msPantallaDeInicio.Size = new System.Drawing.Size(280, 24);
            this.msPantallaDeInicio.TabIndex = 0;
            this.msPantallaDeInicio.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.datosToolStripMenuItem.Text = "Datos del programador";
            this.datosToolStripMenuItem.Click += new System.EventHandler(this.datosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // linealesToolStripMenuItem
            // 
            this.linealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.linealesToolStripMenuItem.Name = "linealesToolStripMenuItem";
            this.linealesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.linealesToolStripMenuItem.Text = "Lineales";
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.dobleToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listasToolStripMenuItem.Text = "Listas enlazadas";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // dobleToolStripMenuItem
            // 
            this.dobleToolStripMenuItem.Name = "dobleToolStripMenuItem";
            this.dobleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.dobleToolStripMenuItem.Text = "Doble";
            this.dobleToolStripMenuItem.Click += new System.EventHandler(this.dobleToolStripMenuItem_Click);
            // 
            // noLinealesToolStripMenuItem
            // 
            this.noLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioToolStripMenuItem,
            this.grafosToolStripMenuItem});
            this.noLinealesToolStripMenuItem.Name = "noLinealesToolStripMenuItem";
            this.noLinealesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.noLinealesToolStripMenuItem.Text = "No lineales";
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arbolBinarioToolStripMenuItem.Text = "Arbol binario";
            this.arbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioToolStripMenuItem_Click);
            // 
            // grafosToolStripMenuItem
            // 
            this.grafosToolStripMenuItem.Name = "grafosToolStripMenuItem";
            this.grafosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grafosToolStripMenuItem.Text = "Grafos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 123);
            this.Controls.Add(this.msPantallaDeInicio);
            this.MainMenuStrip = this.msPantallaDeInicio;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras de datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msPantallaDeInicio.ResumeLayout(false);
            this.msPantallaDeInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPantallaDeInicio;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobleToolStripMenuItem;
    }
}

