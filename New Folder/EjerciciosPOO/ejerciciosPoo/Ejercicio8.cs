using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio8
    {
        public void ejercicio8()
        {
            Console.WriteLine("Ingrese un numero");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i <= n/2)
                {
                    Console.Write("     "+(i+i));

                }
                else
                {
                    Console.Write(" ");
                }
                if (i <= n/3)
                {
                    Console.WriteLine("     "+(i+i+i));
                }
                else
                {
                    Console.WriteLine(" ");
                }

            }

            
            Console.ReadKey();
        }
    }
}
