using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio10
    {
        public void ejercicio10()
        {
            int n, s = 0, m = 1;
            do
            {
                Console.WriteLine("Elija una opción");
                Console.WriteLine("1) Salir");
                Console.WriteLine("2) Sumatoria");
                Console.WriteLine("3) Factorial");
                n = int.Parse(Console.ReadLine());
                if (2 == n)
                {

                    Console.WriteLine("¿Cuántos números va a sumar?");
                    int a = int.Parse(Console.ReadLine());
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        int b = int.Parse(Console.ReadLine());

                        s = s + b;
                    }
                    Console.WriteLine("La sumatoria es= {0}", s);
                }
                if (n == 3)
                {
                    Console.WriteLine("Ingrese un numero");
                    int g = int.Parse(Console.ReadLine());
                    if (g == 0)
                    {
                        Console.WriteLine("El número factorial es= {0}", m);
                    }
                    else
                    {
                        for (int i = 1; i <= g; i++)
                        {
                            m = m * i;
                        }
                        Console.WriteLine("El número factorial es= {0}", m);
                    }
                }
                if (1 != n && 2 != n && 3 != n)
                {
                    Console.WriteLine("Escoja una opcion entre el rango establecido");
                }
                Console.WriteLine("");

            } while (n != 1);
        }
    }
}
