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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosProgramador DatosProgramador = new frmDatosProgramador();
            DatosProgramador.ShowDialog();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraCola EstructuraCola = new frmEstructuraCola();
            EstructuraCola.ShowDialog();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDinamicaLinealPila EstructuraPila = new frmEstructuraDinamicaLinealPila();
            EstructuraPila.ShowDialog();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple ListaSimple = new frmListaSimple();
            ListaSimple.ShowDialog();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble ListaDoble = new frmListaDoble();
            ListaDoble.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario arbolBinario = new frmArbolBinario();
            arbolBinario.ShowDialog();
        }
    }
}
