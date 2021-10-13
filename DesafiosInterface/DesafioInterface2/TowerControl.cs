using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface2
{
    class TowerControl
    {
        List<IVolador> TorreControl = new List<IVolador>();



        public void volarTodo()
        {
            foreach (IVolador i in TorreControl)
            {
                i.volar();
            }
        }

        public void agregarAtorre(IVolador volador)
        {
            TorreControl.Add(volador);
        }

    }
}
