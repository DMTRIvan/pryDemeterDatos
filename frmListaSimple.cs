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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple ListaDePersonas = new clsListaSimple();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            ListaDePersonas.Agregar(ObjNodo);
            ListaDePersonas.Recorrer(dgvGrilla);
            ListaDePersonas.Recorrer(lbListado);
            lstCodigo.Text = "";
            ListaDePersonas.Recorrer(lstCodigo);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDePersonas.Primero != null)
            {
                Int32 x = Convert.ToInt32(lstCodigo.Text);
                ListaDePersonas.Eliminar(x);
                ListaDePersonas.Recorrer(dgvGrilla);
                ListaDePersonas.Recorrer(lbListado);
                ListaDePersonas.Recorrer(lstCodigo);
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
            
        }
    }
}
