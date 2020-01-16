using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio6
    {
        public void ejercicio6()
        {
            Console.WriteLine("Ingrese el tamaño del rombo");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = n - i - 1; 1 <= j; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
