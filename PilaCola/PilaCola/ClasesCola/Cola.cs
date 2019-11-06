using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PilaCola.ClasesPila;

namespace PilaCola.ClasesCola
{
    public class Cola
    {
        private NodoCola inicio = new NodoCola();
        private NodoCola ultimo = new NodoCola();
        public Cola()
        {
            inicio = null;
            ultimo = null;
        }
        public void Insertarcola()
        {
            NodoCola ingresa = new NodoCola();
            Console.WriteLine("Ingrese el dato para la cola");
            ingresa.Datocola = IngresarDatocola();
            if (VaciaCola())
            {
                ingresa.Siguientecola = inicio;
                inicio = ingresa;
                ultimo = ingresa;
            }
            else
            {
                ingresa.Siguientecola = null;
                ultimo.Siguientecola = ingresa;
                ultimo = ingresa;
            }
            Console.WriteLine("Dato Ingresado");

        }
        public void Mostrarcola()
        {
            NodoCola temp = new NodoCola();
            temp = inicio;
            if (!VaciaCola())
            {
                while (temp != null)
                {
                    Console.WriteLine("  " + temp.Datocola);
                    temp = temp.Siguientecola;
                }
            }
            else
                Console.WriteLine("La cola esta Vacia");
        }
        public void Eliminarcola()
        {
            if (!VaciaCola())
            {
                Console.WriteLine("Se elimino el numero " + inicio.Datocola);
                inicio = inicio.Siguientecola;
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
