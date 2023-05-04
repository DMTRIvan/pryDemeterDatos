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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {

        }
        clsListaDoble ListaDePersonas = new clsListaDoble();
        private void cmdAgregar_Click_1(object sender, EventArgs e)
        {
            
            
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                ListaDePersonas.Agregar(ObjNodo);

                if (rbAscendente.Checked == true)
                {
                    ListaDePersonas.Recorrer(dgvGrilla);
                    ListaDePersonas.Recorrer(lbListado);
                    lstCodigo.Text = "";
                    ListaDePersonas.Recorrer(lstCodigo);
                }
                else
                {
                    ListaDePersonas.RecorrerDescendete(dgvGrilla);
                    ListaDePersonas.RecorrerDescendete(lbListado);
                    lstCodigo.Text = "";
                    ListaDePersonas.RecorrerDescendete(lstCodigo);
                }

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDePersonas.Recorrer(dgvGrilla);
            ListaDePersonas.Recorrer(lbListado);
            lstCodigo.Text = "";
            ListaDePersonas.Recorrer(lstCodigo);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            
            ListaDePersonas.RecorrerDescendete(dgvGrilla);
            lstCodigo.Text = "";
            ListaDePersonas.RecorrerDescendete(lstCodigo);
            ListaDePersonas.RecorrerDescendete(lbListado);            
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            rbAscendente.Checked = true;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if ((ListaDePersonas.Primero != null) && (lstCodigo.Text != ""))
            {
                
                Int32 x = Convert.ToInt32(lstCodigo.SelectedItem);
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
