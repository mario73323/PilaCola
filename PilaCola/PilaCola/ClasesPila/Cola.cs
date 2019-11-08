using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaCola.ClasesPila
{
    class Cola
    {
        private Nodo inicio = new Nodo();
        private Nodo ultimo = new Nodo();
        public Cola()
        {
            inicio = null;
            ultimo = null;
        }
        public void Insertarcola()
        {
            Nodo ingresa = new Nodo();
            Console.WriteLine("Ingrese el dato para la cola");
            ingresa.Dato = IngresarDatocola();
            if (VaciaCola())
            {
                ingresa.Siguiente = inicio;
                inicio = ingresa;
                ultimo = ingresa;
            }
            else
            {
                ingresa.Siguiente = null;
                ultimo.Siguiente = ingresa;
                ultimo = ingresa;
            }
            Console.WriteLine("Dato Ingresado");

        }
        public void Mostrarcola()
        {
            Nodo temp = new Nodo();
            temp = inicio;
            if (!VaciaCola())
            {
                while (temp != null)
                {
                    Console.WriteLine("  " + temp.Dato);
                    temp = temp.Siguiente;
                }
            }
            else
                Console.WriteLine("La cola esta Vacia");
        }
        public void Eliminarcola()
        {
            if (!VaciaCola())
            {
                Console.WriteLine("Se elimino el numero " + inicio.Dato);
                inicio = inicio.Siguiente;
            }
            else
                Console.WriteLine("La cola esta vacia");
        }
        public void Vaciarcola()
        {
            while (!VaciaCola())
            {
                Eliminarcola();
            }
        }
        public Boolean VaciaCola()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }
        protected int IngresarDatocola()
        {
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Solo se aceptan numeros enteros");
                numero = IngresarDatocola();
            }
            return numero;
        }
    }
}
