using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface2
{
    class Superman: IVolador
    {
        public void volar()
        {
            Console.WriteLine("////");
            Console.WriteLine("ESTOY VOLANDO COMO SUPERMAN!");
            Console.WriteLine("////");

        }
    }
}
