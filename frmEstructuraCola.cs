using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDemeterDatos
{
    public partial class frmEstructuraCola : Form
    {
        public frmEstructuraCola()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        clsCola FilaDePersonas = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;

                FilaDePersonas.Agregar(ObjNodo);
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lbListado);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {

                lblCodigo1.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombre1.Text = FilaDePersonas.Primero.Nombre;
                lblTramite1.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lbListado);

            }
            else
            {
                MessageBox.Show("La lista esta vacía");
                lblCodigo1.Text = "";
                lblNombre1.Text = "";
                lblTramite1.Text = "";
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEstructuraCola_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("En el campo Codigo solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
