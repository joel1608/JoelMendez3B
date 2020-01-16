using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estrategy.Clases;

namespace Estrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando la interface podemos llamar a las demaás estrategias.
            Candidatos c1 = new Cartero("el cartero del presidente");           
            Console.WriteLine("Soy {0}",c1.getNombre());
            Console.WriteLine(c1.Cuenta());
            Console.WriteLine("");

            Candidatos c2 = new Astronauta("Yuri Gagarin");
            Console.WriteLine("Soy {0}", c2.getNombre());
            Console.WriteLine(c2.Cuenta());
            Console.WriteLine("");

            Candidatos c3 = new Funcionario("Lenin Moreno");
            Console.WriteLine("Soy {0}", c3.getNombre());
            Console.WriteLine(c3.Cuenta());
            Console.WriteLine("");

            Candidatos c4 = new Ideal("Taxista");
            Console.WriteLine("Soy {0}", c4.getNombre());
            Console.WriteLine(c4.Cuenta());

            Console.ReadKey();
        }
    }
}
