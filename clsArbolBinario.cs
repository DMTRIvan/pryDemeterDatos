using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDemeterDatos
{
    class clsArbolBinario
    {
        private clsNodo Inicio;

        public clsNodo Raiz
        {
            get { return Inicio;}
            set { Inicio = value;}
        }
        //jajajaaj
        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if(Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if(Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if(Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }

        //Comienzan los RecorrerInOrdenAsc 
        public void RecorrerInOrdenAsc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void RecorrerInOrdenAsc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }
        public void RecorrerInOrdenAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void RecorrerInOrdenAsc(TreeView Tree)
        {
            Tree.Nodes.Clear();
            InOrdenAsc(Tree, Raiz);
        }

        //Comienzan los RecorrerInOrdenDes
        public void RecorrerInOrdenDes(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }
        public void RecorrerInOrdenDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);
        }
        public void RecorrerInOrdenDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }
        public void RecorrerInOrdenDes(TreeView Tree)
        {
            Tree.Nodes.Clear();
            InOrdenDes(Tree, Raiz);
        }

        //Comienzan los RecorrerPreOrden
        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }
        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        public void RecorrerPreOrden(TreeView Tree)
        {
            Tree.Nodes.Clear();
            PreOrden(Tree, Raiz);
        }

        //Comienzan los RecorrerPostOrden
        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }
        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        public void RecorrerPostOrden(TreeView Tree)
        {
            Tree.Nodes.Clear();
            PostOrden(Tree, Raiz);
        }






        //Comienzan los ListBox
        //in orden ascendente para ListBox
        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if(R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }

        //in orden descendente para ListBox
        public void InOrdenDes(ListBox Lst, clsNodo R)
        {

            if (R.Derecho != null)
            {
                InOrdenDes(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDes(Lst, R.Izquierdo);
            } 
        }

        //Pre orden para ListBox (R-I-D)
        public void PreOrden(ListBox Lst, clsNodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrden(Lst, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Lst, R.Derecho);   
        }

        //Post orden para list box (I-D-R)
        public void PostOrden(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Lst, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Lst, R.Derecho);
            Lst.Items.Add(R.Codigo);
        }


        //Comienzan los combobox
        //in orden ascendente para ComboBox
        public void InOrdenAsc(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Combo, R.Izquierdo);
            }
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Combo, R.Derecho);
            }
        }

        //in orden descendente para ComboBox
        public void InOrdenDes(ComboBox Combo, clsNodo R)
        {

            if (R.Derecho != null)
            {
                InOrdenDes(Combo, R.Derecho);
            }
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDes(Combo, R.Izquierdo);
            }
        }

        //Pre orden para ComboBox (R-I-D)
        public void PreOrden(ComboBox Combo, clsNodo R)
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrden(Combo, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Combo, R.Derecho);
        }

        //Post orden para ComboBox (I-D-R)
        public void PostOrden(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Combo, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
        }


        //Comienzan los DataGridView
        //in orden ascendente para DataGridView
        public void InOrdenAsc(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Grilla, R.Izquierdo);
            }

            //Agrego una nueva fila a la grilla con los datos del nodo
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Grilla, R.Codigo, R.Nombre, R.Tramite); // Agrega las columnas necesarias
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Derecho != null)
            {
                InOrdenAsc(Grilla, R.Derecho);
            }
        }

        //in orden descendente para DataGridView
        public void InOrdenDes(DataGridView Grilla, clsNodo R)
        {

            if (R.Derecho != null)
            {
                InOrdenDes(Grilla, R.Derecho);
            }

            //Agrego una nueva fila a la grilla con los datos del nodo
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Grilla, R.Codigo, R.Nombre, R.Tramite); // Agrega las columnas necesarias
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);


            if (R.Izquierdo != null)
            {
                InOrdenDes(Grilla, R.Izquierdo);
            }
        }

        //Pre orden para DataGridView (R-I-D)
        public void PreOrden(DataGridView Grilla, clsNodo R)
        {
            //Agrego una nueva fila a la grilla con los datos del nodo
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Grilla, R.Codigo, R.Nombre, R.Tramite); // Agrega las columnas necesarias
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Izquierdo != null) PreOrden(Grilla, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Grilla, R.Derecho);
        }

        //Post orden para DataGridView (I-D-R)
        public void PostOrden(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Grilla, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Grilla, R.Derecho);
            //Agrego una nueva fila a la grilla con los datos del nodo
            //DataGridViewRow row = new DataGridViewRow();
            //row.CreateCells(Grilla, R.Codigo, R.Nombre, R.Tramite); // Agrega las columnas necesarias
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            //Grilla.Rows.Add(row);
        }


        ////Comienzan los TreeView
        ////in orden ascendente para TreeView
        //public void InOrdenAsc(TreeView Tree, clsNodo R)
        //{
        //    if (R.Izquierdo != null)
        //    {
        //        InOrdenAsc(Tree, R.Izquierdo);
        //    }
        //    Tree.Nodes.Add(R.Codigo.ToString());
        //    if (R.Derecho != null)
        //    {
        //        InOrdenAsc(Tree, R.Derecho);
        //    }
        //}

        ////in orden descendente para TreeView
        //public void InOrdenDes(TreeView Tree, clsNodo R)
        //{

        //    if (R.Derecho != null)
        //    {
        //        InOrdenDes(Tree, R.Derecho);
        //    }
        //    Tree.Nodes.Add(R.Codigo.ToString());
        //    if (R.Izquierdo != null)
        //    {
        //        InOrdenDes(Tree, R.Izquierdo);
        //    }
        //}
        ////Pre orden para TreeView (R-I-D)
        //public void PreOrden(TreeView Tree, clsNodo R)
        //{
        //    Tree.Nodes.Add(R.Codigo.ToString());
        //    if (R.Izquierdo != null) PreOrden(Tree, R.Izquierdo);
        //    if (R.Derecho != null) PreOrden(Tree, R.Derecho);
        //}

        ////Post orden para TreeView (I-D-R)
        //public void PostOrden(TreeView Tree, clsNodo R)
        //{
        //    if (R.Izquierdo != null) PostOrden(Tree, R.Izquierdo);
        //    if (R.Derecho != null) PostOrden(Tree, R.Derecho);
        //    Tree.Nodes.Add(R.Codigo.ToString());
        //}




    }
}
