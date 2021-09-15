using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_UrielNavarta
{
    class Camisa
    {
        private int precio;
        private int cantidad;
        private bool terminar;


        public Camisa()
        {
            this.precio = 1000;
            this.cantidad = 0;
        }

        public int getPrecio()
        {
            return this.precio;
        }

        public void setPrecio()
        {
            this.precio = 1000;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }

        public void setCantidadNegativo()
        {
            if (getCantidad() == 0)
            {
                Console.Clear();
                Console.WriteLine("------");
                Console.WriteLine("NO SE PUDEN QUITAR MÁS CAMISAS.");
                Console.WriteLine("------");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                this.cantidad -= 1;
            }
        }

        public void setCantidad()
        {
            Console.Clear();
            this.cantidad += 1;
        }

        public int totalCarrito()
        {
            int total = cantidad * 1000;
            return total;
        }
        
        public double descuento()
        {

            double precioFinal = 0;
            if (getCantidad() >= 3 && getCantidad() <= 5)
            {
               precioFinal = totalCarrito() * 0.9;
                
            
            }else if(cantidad > 5)
            {
                precioFinal = totalCarrito() * 0.8;
                
            }
            else
            {
                precioFinal = totalCarrito();
            }

            return precioFinal;
        }


        public int descuentoPorcentage(int cantidad)
        {
            int discount = 0;
            if (cantidad >= 3 && cantidad <= 5)
            {
                discount = 10;
            }else if (cantidad > 5)
            {
                discount = 20;
            }

            return discount;
        }

      
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
            Console.WriteLine("             -CAMISAS: {0}", getCantidad());
            Console.WriteLine("             -PRECIO: {0}", getPrecio());
            Console.WriteLine("             -DESCUENTO: {0}%", descuentoPorcentage(getCantidad()));
            Console.WriteLine("             -PRECIO FINAL: {0}",descuento() );
            opcionMenu = Convert.ToInt32(Console.ReadLine());

            if(opcionMenu == 1)
            {
                setCantidad();
            }if(opcionMenu == 2)
            {
                setCantidadNegativo();
            }if(opcionMenu == 3)
            {
                Console.Clear();
                Console.WriteLine("¿DESEA SALIR?");
                char salir2 = 'U';
                salir2 = Convert.ToChar(Console.ReadLine());
                if(salir2 == 'S')
                {
                   terminar = true;
                }
                if(salir2 == 'N')
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
