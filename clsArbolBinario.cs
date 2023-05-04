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
            set { Inicio = value; }
        }

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

        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
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
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Grilla, R.Codigo, R.Nombre, R.Tramite); // Agrega las columnas necesarias
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            //Grilla.Rows.Add(row);
            Grilla.Refresh(); // Refresca la grilla después de agregar la fila
        }


    }
}
