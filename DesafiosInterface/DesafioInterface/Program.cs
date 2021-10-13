using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora kioskoUno = new Impresora();
            Foto selfie = new Foto();
            Documento trabajoPractico = new Documento();
            Contrato casamiento = new Contrato();
            int opcMenu = 0;


            do
            {
                Console.WriteLine("MENÚ DE COLA DE IMPRESIÓN. ");
                Console.WriteLine("OPCIONES MENÚ: ");
                Console.WriteLine("1 - AGREGAR FOTO. ");
                Console.WriteLine("2 - AGREGAR DOCUMENTO. ");
                Console.WriteLine("3 - AGREGAR CONTRATO. ");
                Console.WriteLine("4 - IMPRIMIR TODO.");
                Console.WriteLine("5 - SALIR. ");

                opcMenu = Convert.ToInt32(Console.ReadLine());

                switch (opcMenu)
                {
                    case 1:
                        Console.WriteLine("AGREGANDO FOTO...");
                        kioskoUno.AgregarImprimible(selfie);
                        break;

                    case 2:
                        Console.WriteLine("AGREGANDO DOCUMENTO...");
                        kioskoUno.AgregarImprimible(trabajoPractico);
                        break;

                    case 3:
                        Console.WriteLine("AGREGANDO CONTRATO...");
                        kioskoUno.AgregarImprimible(casamiento);
                        break;

                    case 4:
                        Console.WriteLine("IMPRIMIENDO TODO...");
                        kioskoUno.imprimirTodo();
                        break;
                    case 5:
                        Console.WriteLine("SALIENDO...");
                        break;
                    default:
                        Console.WriteLine("OPCIÓN NO CONTEMPLADA.");
                        break;
                }
            } while (opcMenu != 5);



        }
    }
}
