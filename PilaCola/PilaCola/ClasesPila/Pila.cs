using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaCola.ClasesPila
{
    public class Pila
    {
        private Nodo Primero = new Nodo();
        public  Pila()
        {
            Primero = null;
        }

        public void Insertar()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato para la pila");
            Nuevo.Dato = IngresarDato();

            Nuevo.Siguiente = Primero;
            Primero = Nuevo;
            Console.WriteLine("Dato Ingresado");
        }
        public Boolean VaciaPila()
        {
            if (Primero == null)
                return true;
            else
                return false;
        }

        public void Mostrar()
        {
            Nodo Temp = new Nodo();
            Temp = Primero;
            if (!VaciaPila())
            {
                while (Temp != null)
                {
                    Console.WriteLine("  " + Temp.Dato);
                    Temp = Temp.Siguiente;
                }
            }
            else
                Console.WriteLine("La pila esta Vacia");
        }
        public void Eliminar()
        {
            if (!VaciaPila())
            {
                Console.WriteLine("Se elimino el numero " + Primero.Dato);
                Primero = Primero.Siguiente;
            }
            else
                Console.WriteLine("La pila esta vacia");
        }
        public void Vaciar()
        {
            while (!VaciaPila())
            {
                Eliminar();
            }
        }

        protected int IngresarDato()
        {
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Solo se aceptan numeros enteros");
                numero = IngresarDato();
            }
            return numero;
        }

    }
}
