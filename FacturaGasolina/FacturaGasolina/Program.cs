using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaGasolina.clase;

namespace FacturaGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true, b = true;

            Cliente c1 = new Cliente("Nombre", 1312386921,"Direccion",new List<Gasolina>());
            

            Console.WriteLine("Ingrese su apellidos y nombres");
            c1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de cédula"); 
            c1.Identificacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la direción");
            c1.Direccion = Console.ReadLine();

                
               
            
                
                Gasolina g1 = new Gasolina("Tipo de Gasolina", 2);

                TipoGasolina();
                Console.WriteLine("¿Cuantos Galones Compró?");
                g1.Galones = int.Parse(Console.ReadLine());

                Console.WriteLine("|---------------------------------------------------------");
                Console.WriteLine("|Datos del Cliente");
                Console.WriteLine("|Nombre:              {0}", c1.Nombre);
                Console.WriteLine("|Identificación:      {0}",c1.Identificacion);
                Console.WriteLine("|Dirección:           {0}",c1.Direccion);


                g1.Cliente = c1;
                c1.Gasolina.Add(g1);

                foreach (Gasolina item in c1.Gasolina)
                {
                    Console.WriteLine("|---------------------------------------------------------");
                    Console.WriteLine("|Datos de la Gasolina ");
                    Console.WriteLine("|---------------------------------------------------------");
                    Console.WriteLine("|Tipo de Gasolina:     {0} ", g1.Tipo);
                    Console.WriteLine("|Precio por Galón:     {0} ", g1.Precio);
                    Console.WriteLine("|Cantidad de Galones:  {0} ", g1.Galones);
                    Console.WriteLine("|---------------------------------------------------------");
                    Console.WriteLine("|                                    Subtotal =   ${0}    ", item.Subtotal());
                    Console.WriteLine("|                                    IVA =        ${0}    ", item.Iva());
                    Console.WriteLine("|                                    Total =      ${0}    ", item.Total());
                    Console.WriteLine("|---------------------------------------------------------");
                }
                Console.ReadKey();
            
                void TipoGasolina()
                {
                    Console.WriteLine("Ingrese el tipo de gasolina (Super ó Extra)");
                    bool ban;
                    do
                    {
                        switch (Console.ReadLine())
                        {
                            case "Super": g1.Tipo = "Super"; ban = false; break;
                            case "Extra": g1.Tipo = "Extra"; ban = false; break;
                            default:
                                Console.WriteLine("Ingrese el tipo de gasolina correcta"); ban = true;
                                break;
                        }
                    } while (ban);
                }

            
                string MenuCompraGasolina()
                {
                    Console.WriteLine("¿Desea realizar otra compra?");
                    Console.WriteLine("Si");
                    Console.WriteLine("No");
                    string opcion = Console.ReadLine();
                    return opcion;
                }
            

        }

    }
}
