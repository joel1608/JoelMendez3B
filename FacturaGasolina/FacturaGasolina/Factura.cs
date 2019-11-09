using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaGasolina.clase;

namespace FacturaGasolina
{
    class Factura
    {
        static void Main(string[] args)
        {
            bool a=true,b = true;
            int i = 0;

            Cliente c1 = new Cliente("Nombre", 1312386921,"Direccion",new List<Producto>());
            

            Console.WriteLine("Ingrese sus apellidos y nombres");
            c1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de cédula"); 
            c1.Identificacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la direción");
            c1.Direccion = Console.ReadLine();
            
                do
                {
                
                    Producto gi = new Producto("Tipo de Gasolina", 2);

                    TipoGasolina();
                    Console.WriteLine("¿Cuantos Galones Compró?");
                    gi.Galones = int.Parse(Console.ReadLine());

                    Console.WriteLine("|---------------------------------------------------------");
                    Console.WriteLine("|Datos del Cliente");
                    Console.WriteLine("|Nombre:              {0}", c1.Nombre);
                    Console.WriteLine("|Identificación:      {0}", c1.Identificacion);
                    Console.WriteLine("|Dirección:           {0}", c1.Direccion);


                    gi.Cliente = c1;
                    c1.Producto.Add(gi);

                    foreach (Producto item in c1.Producto)
                    {

                        Console.WriteLine("|---------------------------------------------------------");
                        Console.WriteLine("|Datos de la Gasolina ");
                        Console.WriteLine("|---------------------------------------------------------");
                        Console.WriteLine("|Tipo de Gasolina:     {0} ", gi.Tipo);
                        Console.WriteLine("|Precio por Galón:     {0} ", gi.Precio);
                        Console.WriteLine("|Cantidad de Galones:  {0} ", gi.Galones);
                        Console.WriteLine("|---------------------------------------------------------");
                        Console.WriteLine("|                                    Subtotal =   ${0}    ", item.Subtotal());
                        Console.WriteLine("|                                    IVA =        ${0}    ", item.Iva());
                        Console.WriteLine("|                                    Total =      ${0}    ", item.Total());
                        Console.WriteLine("|---------------------------------------------------------");
                    }
                    Console.ReadKey();


                    void TipoGasolina()
                    {
                        Console.WriteLine("Ingrese el tipo de gasolina");
                        Console.WriteLine("Super");
                        Console.WriteLine("Extra");
                        bool ban;
                        do
                        {
                            switch (Console.ReadLine())
                            {
                                case "Super": gi.Tipo = "Super"; ban = false; break;
                                case "Extra": gi.Tipo = "Extra"; ban = false; break;
                                default:
                                    Console.WriteLine("Ingrese el tipo de gasolina correcta"); ban = true;
                                    break;
                            }
                        } while (ban);
                    }
                
                    bool MenuCompraGasolina()
                    {
                        Console.WriteLine("¿Desea realizar otra compra?");
                        Console.WriteLine("Si");
                        Console.WriteLine("No");
                        string opcion = Console.ReadLine();
                        bool ban;
                        do
                        {
                            switch (Console.ReadLine())
                            {
                                case "Si": a = true; ban = false; break;
                                case "No": a = false; ban = false; break;
                                default:
                                    Console.WriteLine("Ingrese Si ó No"); ban = true;
                                    break;
                            }
                        } while (ban);
                        return a;
                    }
                b = MenuCompraGasolina();


                    i += 1;
                } while (b);
            
        }

    }
}
