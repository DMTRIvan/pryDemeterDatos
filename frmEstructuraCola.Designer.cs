namespace pryDemeterDatos
{
    partial class frmEstructuraCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraCola));
            this.pbGrafico = new System.Windows.Forms.PictureBox();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.lbListado = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).BeginInit();
            this.mrcNuevoElemento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGrafico
            // 
            this.pbGrafico.Image = ((System.Drawing.Image)(resources.GetObject("pbGrafico.Image")));
            this.pbGrafico.Location = new System.Drawing.Point(13, 13);
            this.pbGrafico.Name = "pbGrafico";
            this.pbGrafico.Size = new System.Drawing.Size(134, 162);
            this.pbGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrafico.TabIndex = 0;
            this.pbGrafico.TabStop = false;
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.txtTramite);
            this.mrcNuevoElemento.Controls.Add(this.txtNombre);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigo);
            this.mrcNuevoElemento.Controls.Add(this.cmdAgregar);
            this.mrcNuevoElemento.Controls.Add(this.lblTramite);
            this.mrcNuevoElemento.Controls.Add(this.lblNombre);
            this.mrcNuevoElemento.Controls.Add(this.lblCodigo);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(177, 13);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(200, 162);
            this.mrcNuevoElemento.TabIndex = 1;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(76, 82);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(56, 116);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 3;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 85);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTramite1);
            this.groupBox1.Controls.Add(this.lblNombre1);
            this.groupBox1.Controls.Add(this.lblCodigo1);
            this.groupBox1.Controls.Add(this.cmdEliminar);
            this.groupBox1.Controls.Add(this.lblTramiteEliminar);
            this.groupBox1.Controls.Add(this.lblNombreEliminar);
            this.groupBox1.Controls.Add(this.lblCodigoEliminar);
            this.groupBox1.Location = new System.Drawing.Point(406, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemento eliminado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTramite1
            // 
            this.lblTramite1.AutoSize = true;
            this.lblTramite1.Location = new System.Drawing.Point(91, 85);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(0, 13);
            this.lblTramite1.TabIndex = 6;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(92, 57);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(0, 13);
            this.lblNombre1.TabIndex = 5;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(91, 28);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo1.TabIndex = 4;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(56, 116);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 3;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.AutoSize = true;
            this.lblTramiteEliminar.Location = new System.Drawing.Point(6, 85);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(42, 13);
            this.lblTramiteEliminar.TabIndex = 2;
            this.lblTramiteEliminar.Text = "Tramite";
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Location = new System.Drawing.Point(7, 57);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(44, 13);
            this.lblNombreEliminar.TabIndex = 1;
            this.lblNombreEliminar.Text = "Nombre";
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(6, 28);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEliminar.TabIndex = 0;
            this.lblCodigoEliminar.Text = "Codigo";
            // 
            // mrcListado
            // 
            this.mrcListado.Controls.Add(this.lbListado);
            this.mrcListado.Controls.Add(this.dgvGrilla);
            this.mrcListado.Location = new System.Drawing.Point(31, 192);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Size = new System.Drawing.Size(575, 174);
            this.mrcListado.TabIndex = 3;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una lista y una grilla";
            // 
            // lbListado
            // 
            this.lbListado.FormattingEnabled = true;
            this.lbListado.Location = new System.Drawing.Point(6, 24);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(186, 134);
            this.lbListado.TabIndex = 1;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvGrilla.Location = new System.Drawing.Point(222, 24);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(344, 134);
            this.dgvGrilla.TabIndex = 0;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // frmEstructuraCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.pbGrafico);
            this.Name = "frmEstructuraCola";
            this.Text = "Estructura Dinámica Lineal - Cola";
            this.Load += new System.EventHandler(this.frmEstructuraCola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).EndInit();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mrcListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrafico;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblTramiteEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.ListBox lbListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
    }
}