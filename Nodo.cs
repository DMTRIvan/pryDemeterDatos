using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDemeterDatos
{
    internal class Nodo
    {
        private Int32 cod;
        private String nom;
        private String tra;
        private Nodo sig;


        //propiedades, para sacarle el privado a las variables
        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre 
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        public Nodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }







    }
}
