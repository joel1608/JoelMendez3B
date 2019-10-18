using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio4
    {
        public void ejercicio4()
        {
            int hora, x, pago;
            Console.WriteLine("CALCULADORA DE SALARIO SEMANAL");
            do
            {
                Console.WriteLine("Ingrese las horas que trabaja a la semana:");
                hora = int.Parse(Console.ReadLine());

                if (hora < 36)
                {
                    pago = hora * 15;
                    Console.WriteLine("Su pago es= {0}", pago);
                }

                else
                {
                    pago = ((hora - 35) * 22) + (35 * 15);
                    Console.WriteLine("Su pago es= {0}", pago);
                }
                Console.WriteLine("");
                Console.WriteLine("Desea  calcular otro salario");
                Console.WriteLine("Si --> (1)");
                Console.WriteLine("No --> (2)");
                x = int.Parse(Console.ReadLine());
            } while (x == 1);
            Console.WriteLine("Gracias");
            Console.ReadKey();
        }
    }
}
