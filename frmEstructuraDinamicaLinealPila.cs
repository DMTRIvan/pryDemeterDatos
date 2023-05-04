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
    public partial class frmEstructuraDinamicaLinealPila : Form
    {
        public frmEstructuraDinamicaLinealPila()
        {
            InitializeComponent();
        }
        clsPila PilaDePersonas = new clsPila();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            PilaDePersonas.Agregar(ObjNodo);
            PilaDePersonas.Recorrer(dgvGrilla);
            PilaDePersonas.Recorrer(lbListado);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (PilaDePersonas.Primero != null)
            {

                lblCodigo1.Text = PilaDePersonas.Primero.Codigo.ToString();
                lblNombre1.Text = PilaDePersonas.Primero.Nombre;
                lblTramite1.Text = PilaDePersonas.Primero.Tramite;
                PilaDePersonas.Eliminar();
                PilaDePersonas.Recorrer(dgvGrilla);
                PilaDePersonas.Recorrer(lbListado);

            }
            else
            {
                lblCodigo1.Text = "";
                lblNombre1.Text = "";
                lblTramite1.Text = "";
            }
        }
    }
}
