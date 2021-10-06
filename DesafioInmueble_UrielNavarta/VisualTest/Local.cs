using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTest
{
    class Local : Inmueble
    {
        private int antiguedad;
        private int precioBase;
        private int mtsCuadr;
        private int numwinds;

        public Local(int antiguedad, int precioBase, int mtsCuadr, int numwinds, string direccion)
            : base (direccion)
        {
            this.antiguedad = antiguedad;
            this.precioBase = precioBase;
            this.mtsCuadr = mtsCuadr;
            this.numwinds = numwinds;
        
        }

        public double calcularPrecio()
        {
            int precioFinal = 0;
            precioFinal = precioBase;

            if (mtsCuadr > 50)
            {
                precioFinal += (int)(precioBase * 0.01); 
            }else
            {
                precioFinal = precioBase;
            }

            if(numwinds <= 1)
            {
                precioFinal -= (int)(precioBase * 0.01);
            }else if (numwinds >= 4)
            {
                precioFinal += (int)(precioBase * 0.02);
            }

            return precioFinal;

        }
    }
}
