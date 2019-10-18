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
            int[] x = new int[n]; int[] y = new int[n * 2]; int[] z = new int[n * 3]; int a = 0, b = 0;
            for (int i = 0; i < n; i++)
            {
                x[i] = i + 1;
            }

            for (int i = 0; i < n; i = i + 2)
            {
                y[i] = i + 2;
            }
            for (int i = 0; i < n; i = i + 3)
            {
                z[i] = i + 3;
            }
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0}     {1}     {2}", x[i], y[a], z[b]);
                a = a + 2;
                b = b + 3;
            }
            Console.ReadKey();
        }
    }
}
