using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pila_Cola.clases
{
    class EjercicioPila
    {
        public void ejerciciopila()
        {
            CStack mipila = new CStack();
            bool ben = true;
            do
            {
                int valor = Menu();
                switch (valor)
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero");
                        mipila.Push(int.Parse(Console.ReadLine()));
                        Console.ReadKey(); break;
                    case 2:
                        Console.WriteLine(mipila.Pop());
                        Console.ReadKey(); break;
                    case 3:
                        Console.WriteLine(mipila.Peek());
                        Console.ReadKey(); break;
                    case 4: ben = false; break;
                    default:
                        Console.WriteLine("Escoja la opción correcta");
                        Console.ReadKey();
                        break;
                }
            } while (ben);

            int Menu()
            {
                Console.Clear();


                Console.WriteLine("                           MENU");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" 1) Apilar");
                Console.WriteLine(" 2) Desapilar");
                Console.WriteLine(" 3) Mirar cima");
                Console.WriteLine(" 4) Salir");
                int opcion = int.Parse(Console.ReadLine());
                return opcion;
            }

        }
         
        
    }
}
