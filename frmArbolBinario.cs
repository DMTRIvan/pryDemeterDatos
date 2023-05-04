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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario objArbol = new clsArbolBinario();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            objArbol.Agregar(Persona);
            objArbol.Recorrer(lbListado);
            objArbol.Recorrer(lstCodigo);
            objArbol.Recorrer(dgvGrilla);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
