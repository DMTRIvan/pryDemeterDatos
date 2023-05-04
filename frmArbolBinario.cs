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
            if (rbInOrdenAsc.Checked == true)
            {
                objArbol.RecorrerInOrdenAsc(lbListado);
                objArbol.RecorrerInOrdenAsc(lstCodigo);
                objArbol.RecorrerInOrdenAsc(dgvGrilla);
                objArbol.RecorrerInOrdenAsc(tvLista);
            }
            if (rbInOrdenDes.Checked == true)
            {
                objArbol.RecorrerInOrdenDes(lbListado);
                objArbol.RecorrerInOrdenDes(lstCodigo);
                objArbol.RecorrerInOrdenDes(dgvGrilla);
                objArbol.RecorrerInOrdenDes(tvLista);
            }
            if (rbPreOrden.Checked == true)
            {
                objArbol.RecorrerPreOrden(lbListado);
                objArbol.RecorrerPreOrden(lstCodigo);
                objArbol.RecorrerPreOrden(dgvGrilla);
                objArbol.RecorrerPreOrden(tvLista);
            }
            if (rbPostOrden.Checked == true)
            {
                objArbol.RecorrerPostOrden(lbListado);
                objArbol.RecorrerPostOrden(lstCodigo);
                objArbol.RecorrerPostOrden(dgvGrilla);
                objArbol.RecorrerPostOrden(tvLista);
            }

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void rbInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbol.Raiz != null)
            {
            objArbol.RecorrerInOrdenDes(lbListado);
            objArbol.RecorrerInOrdenDes(lstCodigo);
            objArbol.RecorrerInOrdenDes(dgvGrilla);
            objArbol.RecorrerInOrdenDes(tvLista);
            }
        }

        private void rbInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbol.Raiz != null)
            { 
            objArbol.RecorrerInOrdenAsc(lbListado);
            objArbol.RecorrerInOrdenAsc(lstCodigo);
            objArbol.RecorrerInOrdenAsc(dgvGrilla);
            objArbol.RecorrerInOrdenAsc(tvLista);
            }
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbol.Raiz != null)
            { 
            objArbol.RecorrerPreOrden(lbListado);
            objArbol.RecorrerPreOrden(lstCodigo);
            objArbol.RecorrerPreOrden(dgvGrilla);
            objArbol.RecorrerPreOrden(tvLista);
            }
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if(objArbol.Raiz != null)
            {
                objArbol.RecorrerPostOrden(lbListado);
                objArbol.RecorrerPostOrden(lstCodigo);
                objArbol.RecorrerPostOrden(dgvGrilla);
                objArbol.RecorrerPostOrden(tvLista);
            }
           
        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
