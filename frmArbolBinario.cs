using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo Persona = new clsNodo();
                Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
                Persona.Nombre = txtNombre.Text;
                Persona.Tramite = txtTramite.Text;

                objArbol.Agregar(Persona);

                if (objArbol.Raiz != null)
                {
                    objArbol.Equilibrar();
                }
                recorridos();

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos", "Error");
            }
            
        }
        public void recorridos()
        {
            if (objArbol.Raiz != null)
            {
                objArbol.RecorrerInOrdenAsc(tvLista);
                if (rbInOrdenAsc.Checked == true)
                {
                    objArbol.RecorrerInOrdenAsc(lbListado);
                    objArbol.RecorrerInOrdenAsc(lstCodigo);
                    objArbol.RecorrerInOrdenAsc(dgvGrilla);

                }
                if (rbInOrdenDes.Checked == true)
                {
                    objArbol.RecorrerInOrdenDes(lbListado);
                    objArbol.RecorrerInOrdenDes(lstCodigo);
                    objArbol.RecorrerInOrdenDes(dgvGrilla);

                }
                if (rbPreOrden.Checked == true)
                {
                    objArbol.RecorrerPreOrden(lbListado);
                    objArbol.RecorrerPreOrden(lstCodigo);
                    objArbol.RecorrerPreOrden(dgvGrilla);

                }
                if (rbPostOrden.Checked == true)
                {
                    objArbol.RecorrerPostOrden(lbListado);
                    objArbol.RecorrerPostOrden(lstCodigo);
                    objArbol.RecorrerPostOrden(dgvGrilla);

                }
            }
            
        }
        private void rbInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbol.Raiz != null)
            {
            objArbol.RecorrerInOrdenDes(lbListado);
            objArbol.RecorrerInOrdenDes(lstCodigo);
            objArbol.RecorrerInOrdenDes(dgvGrilla);
            
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
            
            }
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if(objArbol.Raiz != null)
            {
                objArbol.RecorrerPostOrden(lbListado);
                objArbol.RecorrerPostOrden(lstCodigo);
                objArbol.RecorrerPostOrden(dgvGrilla);
                
            }
           
        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (objArbol.Raiz != null && lstCodigo.SelectedIndex != -1)
            {
                objArbol.Equilibrar(Convert.ToInt32(lstCodigo.SelectedItem));
                recorridos();

                if (objArbol.Raiz == null)
                {
                    
                    dgvGrilla.Rows.Clear();
                    lstCodigo.Items.Clear();
                    lbListado.Items.Clear();
                    tvLista.Nodes.Clear();
                }
            }
            else
            {
                MessageBox.Show("No se encontro ningun dato", "Error");
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("En el campo Codigo solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (objArbol.Raiz != null)
            {

                StreamWriter sw = new StreamWriter("Arbol.csv");
                if (rbInOrdenAsc.Checked == true)
                {
                    objArbol.RecorrerInOrdenAsc(sw);

                }
                if (rbInOrdenDes.Checked == true)
                {
                    objArbol.RecorrerInOrdenDes(sw);

                }
                if (rbPreOrden.Checked == true)
                {
                    objArbol.RecorrerPreOrden(sw);

                }
                if (rbPostOrden.Checked == true)
                {
                    objArbol.RecorrerPostOrden(sw);

                }
                sw.Dispose();
                MessageBox.Show("Se creo con exito el archivo!!", "Aviso");
            }
            else
            {
                MessageBox.Show("No hay ningun dato cargado, no se puede crear el archivo", "Aviso");
            }
        }
    }
}
