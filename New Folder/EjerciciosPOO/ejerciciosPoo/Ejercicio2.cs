using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio2
    {
        public void ejercicio2()
        {
            Console.WriteLine("Ingrese el tamaño del cuadrado");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0 && n <= 50)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");

                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < n - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }

            }
            Console.ReadKey();
        }
    }
}
