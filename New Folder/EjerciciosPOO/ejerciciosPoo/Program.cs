using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Ejercicio1 P1 = new Ejercicio1();
                Ejercicio2 P2 = new Ejercicio2();
                Ejercicio3 P3 = new Ejercicio3();
                Ejercicio4 P4 = new Ejercicio4();
                Ejercicio5 P5 = new Ejercicio5();
                Ejercicio6 P6 = new Ejercicio6();
                Ejercicio7 P7 = new Ejercicio7();
                Ejercicio8 P8 = new Ejercicio8();
                Ejercicio9 P9 = new Ejercicio9();
                Ejercicio10 P10 = new Ejercicio10();

                bool b = true;
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                         MENÚ");
                    Console.WriteLine(" ");
                    Console.WriteLine("(1) Ejercicio 1      (2) Ejercicio 2     (3) Ejercicio 3 ");
                    Console.WriteLine("");
                    Console.WriteLine("(4) Ejercicio 4      (5) Ejercicio 5     (6) Ejercicio 6 ");
                    Console.WriteLine("");
                    Console.WriteLine("(7) Ejercicio 7      (8) Ejercicio 8     (9) Ejercicio 9 ");
                    Console.WriteLine("");
                    Console.WriteLine("(10) Ejercicio 10    (11) Salir");
                    Console.WriteLine("");

                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (n > 11)
                    {
                        Console.WriteLine("ESCOJA LA OPCIÓN CORRECTA");
                        Console.ReadKey();
                    }

                    if (n == 11)
                    {
                        b = false;
                    }

                    switch (n)
                    {
                        case 1: P1.ejercicio1(); break;
                        case 2: P2.ejercicio2(); break;
                        case 3: P3.ejercicio3(); break;
                        case 4: P4.ejercicio4(); break;
                        case 5: P5.ejercicio5(); break;
                        case 6: P6.ejercicio6(); break;
                        case 7: P7.ejercicio7(); break;
                        case 8: P8.ejercicio8(); break;
                        case 9: P9.ejercicio9(); break;
                        case 10: P10.ejercicio10(); break;

                    }

                } while (true == b);


                

            
        }
    }
}
