using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio7
    {
        public void ejercicio7()
        {
            Console.WriteLine("Columnas de numeros");
            int[] x = new int[100]; int y = 100;
            for (int i = 0; i < 100; i++)
            {
                x[i] = i + 1;
                Console.WriteLine("{0}   {1} ", x[i], y - i);
            }


            Console.ReadLine();
        }
    }
}
