using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_UrielNavarta
{
    class Utilidad
    {
        Camisa shirts = new Camisa();


        private bool terminar;

        public void menuprincipal(ref bool terminar)
        {
            int opcionMenu;

            Console.WriteLine("SHOPPING ONLINE - MENU PRINCIPAL");
            Console.WriteLine("--------");
            Console.WriteLine("1. AÑADIR CAMISA AL CARRO DE COMPRAS.");
            Console.WriteLine("2. QUITAR CAMISA DEL CARRO DE COMPRAS");
            Console.WriteLine("3. SALIR");
            Console.WriteLine("--------");
            Console.WriteLine("¿QUÉ DESEA HACER?");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("             -CAMISAS: {0}", shirts.getCantidad());
            Console.WriteLine("             -PRECIO: {0}", shirts.getPrecio());
            Console.WriteLine("             -DESCUENTO: {0}%", shirts.descuentoPorcentage(shirts.getCantidad()));
            Console.WriteLine("             -PRECIO FINAL: {0}", shirts.descuento());
            opcionMenu = Convert.ToInt32(Console.ReadLine());

            if (opcionMenu == 1)
            {
                shirts.setCantidad();
            }
            if (opcionMenu == 2)
            {
                shirts.setCantidadNegativo();
            }
            if (opcionMenu == 3)
            {
                Console.Clear();
                Console.WriteLine("¿DESEA SALIR?");
                char salir2 = 'U';
                salir2 = Convert.ToChar(Console.ReadLine());
                if (salir2 == 'S')
                {
                    terminar = true;
                }
                if (salir2 == 'N')
                {
                    terminar = false;
                }
                else
                {
                    Console.WriteLine("LA OPCIÓN INGRESADA ES INCORRECTA.");
                }


            }
        }
    }
}
