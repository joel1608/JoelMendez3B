using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio9
    {
        public void ejercicio9()
        {
            for (int j = 1; j <= 15; j++)
            {
                for (int i = 1; i <= 15; i++)
                {

                    int m = j * i;
                    Console.WriteLine(j + " x " + i + " = " + m);

                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
