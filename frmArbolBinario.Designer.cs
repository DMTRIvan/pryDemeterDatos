
namespace pryDemeterDatos
{
    partial class frmArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.lbListado = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCodigo = new System.Windows.Forms.ComboBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pbGrafico = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvLista = new System.Windows.Forms.TreeView();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbInOrdenDes = new System.Windows.Forms.RadioButton();
            this.rbInOrdenAsc = new System.Windows.Forms.RadioButton();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcListado
            // 
            this.mrcListado.Controls.Add(this.lbListado);
            this.mrcListado.Controls.Add(this.dgvGrilla);
            this.mrcListado.Location = new System.Drawing.Point(30, 191);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Size = new System.Drawing.Size(575, 174);
            this.mrcListado.TabIndex = 20;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una lista y una grilla";
            // 
            // lbListado
            // 
            this.lbListado.BackColor = System.Drawing.Color.LightCyan;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCodigo);
            this.groupBox1.Controls.Add(this.cmdEliminar);
            this.groupBox1.Controls.Add(this.lblCodigoEliminar);
            this.groupBox1.Location = new System.Drawing.Point(396, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 98);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemento eliminado";
            // 
            // lstCodigo
            // 
            this.lstCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(56, 24);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(135, 21);
            this.lstCodigo.TabIndex = 4;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(116, 57);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 3;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(6, 27);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEliminar.TabIndex = 0;
            this.lblCodigoEliminar.Text = "Codigo";
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(176, 12);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(200, 162);
            this.mrcNuevoElemento.TabIndex = 18;
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
            // pbGrafico
            // 
            this.pbGrafico.Image = ((System.Drawing.Image)(resources.GetObject("pbGrafico.Image")));
            this.pbGrafico.Location = new System.Drawing.Point(12, 12);
            this.pbGrafico.Name = "pbGrafico";
            this.pbGrafico.Size = new System.Drawing.Size(134, 162);
            this.pbGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrafico.TabIndex = 17;
            this.pbGrafico.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvLista);
            this.groupBox2.Location = new System.Drawing.Point(612, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 320);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Arbol";
            // 
            // tvLista
            // 
            this.tvLista.BackColor = System.Drawing.Color.LightCyan;
            this.tvLista.Location = new System.Drawing.Point(6, 19);
            this.tvLista.Name = "tvLista";
            this.tvLista.Size = new System.Drawing.Size(188, 295);
            this.tvLista.TabIndex = 21;
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbPostOrden);
            this.gbOrdenar.Controls.Add(this.rbPreOrden);
            this.gbOrdenar.Controls.Add(this.rbInOrdenDes);
            this.gbOrdenar.Controls.Add(this.rbInOrdenAsc);
            this.gbOrdenar.Location = new System.Drawing.Point(396, 116);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(209, 76);
            this.gbOrdenar.TabIndex = 5;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Forma de ordenar";
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(99, 52);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(75, 17);
            this.rbPostOrden.TabIndex = 3;
            this.rbPostOrden.Text = "PostOrden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            this.rbPostOrden.CheckedChanged += new System.EventHandler(this.rbPostOrden_CheckedChanged);
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(101, 20);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(70, 17);
            this.rbPreOrden.TabIndex = 2;
            this.rbPreOrden.Text = "PreOrden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            this.rbPreOrden.CheckedChanged += new System.EventHandler(this.rbPreOrden_CheckedChanged);
            // 
            // rbInOrdenDes
            // 
            this.rbInOrdenDes.AutoSize = true;
            this.rbInOrdenDes.Location = new System.Drawing.Point(7, 52);
            this.rbInOrdenDes.Name = "rbInOrdenDes";
            this.rbInOrdenDes.Size = new System.Drawing.Size(82, 17);
            this.rbInOrdenDes.TabIndex = 1;
            this.rbInOrdenDes.Text = "InOrdenDes";
            this.rbInOrdenDes.UseVisualStyleBackColor = true;
            this.rbInOrdenDes.CheckedChanged += new System.EventHandler(this.rbInOrdenDes_CheckedChanged);
            // 
            // rbInOrdenAsc
            // 
            this.rbInOrdenAsc.AutoSize = true;
            this.rbInOrdenAsc.Checked = true;
            this.rbInOrdenAsc.Location = new System.Drawing.Point(9, 20);
            this.rbInOrdenAsc.Name = "rbInOrdenAsc";
            this.rbInOrdenAsc.Size = new System.Drawing.Size(81, 17);
            this.rbInOrdenAsc.TabIndex = 0;
            this.rbInOrdenAsc.TabStop = true;
            this.rbInOrdenAsc.Text = "InOrdenAsc";
            this.rbInOrdenAsc.UseVisualStyleBackColor = true;
            this.rbInOrdenAsc.CheckedChanged += new System.EventHandler(this.rbInOrdenAsc_CheckedChanged);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdGrabar.Location = new System.Drawing.Point(618, 338);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(188, 23);
            this.cmdGrabar.TabIndex = 21;
            this.cmdGrabar.Text = "Grabar archivo";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(824, 373);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.pbGrafico);
            this.Name = "frmArbolBinario";
            this.Text = "Estructura Ramificada - Arbol Binario";
            this.mrcListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.ListBox lbListado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstCodigo;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pbGrafico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvLista;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrdenDes;
        private System.Windows.Forms.RadioButton rbInOrdenAsc;
        private System.Windows.Forms.Button cmdGrabar;
    }
}