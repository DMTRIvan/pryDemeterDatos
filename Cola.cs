using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDemeterDatos
{
    //No lo usamos. Usamos el clsCola
    internal class Cola
    {
        public clsNodo Primero;
        public clsNodo Ultimo;

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }

            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }







    }
}
