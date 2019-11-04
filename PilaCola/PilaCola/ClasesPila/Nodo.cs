using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaCola.ClasesPila
{
    public class Nodo
    {
        
        private int dato;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        private Nodo siguiente;

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }


    }
}
