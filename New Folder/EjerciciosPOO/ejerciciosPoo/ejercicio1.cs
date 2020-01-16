using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio1
    {
        public void ejercicio1()
        {
            int[] x; int mayor = 0;
            Console.Write("¿Cuántos números va a ingresar?\n");
            x = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("Ingrese el numero {0}\n", i + 1);
                x[i] = int.Parse(Console.ReadLine());

                if (x[i] > mayor)
                {
                    mayor = x[i];
                }


            }

            Console.Write("El número mayor es: " + mayor);
            Console.ReadLine();


        }

    }
}
