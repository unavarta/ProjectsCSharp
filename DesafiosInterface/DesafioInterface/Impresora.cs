using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface
{
    public class Impresora
    {

        List<IImprimible> colaImpresion = new List<IImprimible>();

        public void imprimirTodo()
        {
            foreach (IImprimible i in colaImpresion)
            {
                i.imprimir();
            }
        }

        public void AgregarImprimible(IImprimible unimp)
        {
            colaImpresion.Add(unimp);
        }


    }
}
