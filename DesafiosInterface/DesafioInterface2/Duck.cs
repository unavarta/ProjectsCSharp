using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface2
{
    class Duck: IVolador
    {
       public void volar()
        {
            Console.WriteLine("////");
            Console.WriteLine("ESTOY VOLANDO COMO UN PATO! CUACK!");
            Console.WriteLine("////");

        }
    }
}
