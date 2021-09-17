using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_UrielNavarta
{
    class Program
    {
        static void Main(string[] args)
        {

            bool terminar = false;
            Utilidad menu = new Utilidad();


            do
            {
                menu.menuprincipal(ref terminar);

            } while (!terminar);

        }
    }
}
