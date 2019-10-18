using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Ejercicio3
    {
        public void ejercicio3()
        {
            Console.WriteLine("Factura... para ver el total dijite 0");
            int cant; double exit = 1, pre, pb, pv = 0, iva;
            for (int i = 0; exit != 0; i++)

            {
                Console.WriteLine("Ingrese la cantidad del producto: ");
                cant = int.Parse(Console.ReadLine());

                if (cant != 0)
                {

                    Console.WriteLine("Ingrese el precio unitario del producto: ");
                    pre = double.Parse(Console.ReadLine());
                    pb = cant * pre;
                    iva = pb * 0.12;
                    pv = pb + iva;


                }


            }
            Console.WriteLine("Total de la factura= " + pv);
            Console.ReadKey();
        }
    }
}
