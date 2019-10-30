using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_Cola.clases
{
    class EjercicioCola
    {
        public void ejerciciocola()
        {
            Cola cola = new Cola();
            bool bon = true;
            do
            {
                Console.Clear();


                Console.WriteLine("                           MENU");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" 1) Ingresar");
                Console.WriteLine(" 2) Recorrer");
                Console.WriteLine(" 3) Salir");
                int opcion = int.Parse(Console.ReadLine());



                switch (opcion)
                {
                    case 1: cola.InsertarNodo(); break;
                    case 2: cola.DesplegarCola(); break;
                    case 3: bon = false; break;
                    default:
                        Console.WriteLine("Escoja la opción correcta");
                        Console.ReadKey();
                        break;
                }
            } while (bon);
        }
    }
}
