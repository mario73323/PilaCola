using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PilaCola.ClasesPila;
using PilaCola.ClasesCola;

namespace PilaCola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = false,opcion=false;
            while (opcion == false)
            {
                Console.WriteLine("Escoja un tipo de estructura \n1.-Pila \n2.-Cola \n3.-Salir");
                string estructura = Console.ReadLine();
                switch (estructura)
                {
                    case "1":
                        Pila pila = new Pila();
                        ciclo = false;
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
                        break;
                    case "2":
                        //cola
                        Cola cola = new Cola();
                        ciclo = false;
                        while (ciclo == false)
                        {
                            Console.WriteLine("Escoja una accion para la cola \n1.-Ingresar Dato \n2.-Eliminar Dato " +
                            "\n3.-Vaciar cola \n4.-Imprimir cola \n5.-Salir");
                            string op = Console.ReadLine();
                            switch (op)
                            {
                                case "1":
                                    cola.Insertarcola();
                                    Console.WriteLine("Presione un tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    cola.Eliminarcola();
                                    Console.WriteLine("Presione un tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    cola.Vaciarcola();
                                    Console.WriteLine("Presione un tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    cola.Mostrarcola();
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
                        break;
                    case "3":
                        opcion = true;
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

