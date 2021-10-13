using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface2
{
    class Boeng: IVolador
    {
        public void volar()
        {
            Console.WriteLine("////");
            Console.WriteLine("ESTOY VOLANDO EN UN BOENG 747!");
            Console.WriteLine("////");

        }
    }
}
