using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PilaCola.ClasesPila;
//using PilaCola.ClasesCola;

namespace PilaCola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pila
            
            Pila pila = new Pila();
            bool ciclo = false;
            while (ciclo == false)
            {
                Console.WriteLine("Escoja una accion para la Pila \n1.-Ingresar Dato \n2.-Eliminar Dato " +
                "\n3.-Vaciar Pila \n4.-Imprimir Pila \n5.-Salir");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        pila.Insertar();
                        Console.WriteLine("Presione un tecla para continuar");
                        Console.ReadKey();
                        break;
                    case "2":
                        pila.Eliminar();
                        Console.WriteLine("Presione un tecla para continuar");
                        Console.ReadKey();
                        break;
                    case "3":
                        pila.Vaciar();
                        Console.WriteLine("Presione un tecla para continuar");
                        Console.ReadKey();
                        break;
                    case "4":
                        pila.Mostrar();
                        Console.WriteLine("Presione un tecla para continuar");
                        Console.ReadKey();
                        break;
                    case "5":
                        ciclo = true;
                        break;
                    default:
                        Console.WriteLine("No se Escogio ninguna opcion, escoja una opcion valida");
                        Console.WriteLine("Presione un tecla para continuar");
                        break;
                }
                Console.Clear();
            }

        }
    }
}
