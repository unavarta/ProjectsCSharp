using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface2
{
    class Program
    {
        static void Main(string[] args)
        {

            TowerControl atc = new TowerControl(); 
            Boeng sfs = new Boeng();
            Superman clarkEnt = new Superman();
            Duck patoPato = new Duck();

            int opcMenu = 0;


            do
            {
                Console.WriteLine("MENÚ DE COLA DE IMPRESIÓN. ");
                Console.WriteLine("OPCIONES MENÚ: ");
                Console.WriteLine("1 - AGREGAR BOENG 747. ");
                Console.WriteLine("2 - AGREGAR SUPERMAN. ");
                Console.WriteLine("3 - AGREGAR PATO. ");
                Console.WriteLine("4 - MOSTRAR VUELOS EN PROCESO.");
                Console.WriteLine("5 - SALIR. ");

                opcMenu = Convert.ToInt32(Console.ReadLine());

                switch (opcMenu)
                {
                    case 1:
                        Console.WriteLine("AGREGANDO UN BOENG 747...");
                        atc.agregarAtorre(sfs);

                        break;

                    case 2:
                        Console.WriteLine("AGREGANDO A SUPERMAN...");
                        atc.agregarAtorre(clarkEnt);
                        break;

                    case 3:
                        Console.WriteLine("AGREGANDO PATO...");
                        atc.agregarAtorre(patoPato);
                        break;

                    case 4:
                        Console.WriteLine("MOSTRANDO VOLADORES...");
                        atc.volarTodo();
                        break;
                    case 5:
                        Console.WriteLine("SALIENDO...");
                        break;
                    default:
                        Console.WriteLine("OPCIÓN NO CONTEMPLADA.");
                        break;
                }
            } while (opcMenu != 5);
            
            Console.ReadKey();




        }
    }
}
