using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTest
{
    class Piso : Inmueble
    {
        private int antiguedad;
        private int precioBase;
        private int numPiso;

        public Piso(int antiguedad, int precioBase, int numPiso, string direccion)
            : base(direccion)
        {
            this.antiguedad = antiguedad;
            this.precioBase = precioBase;
            this.numPiso = numPiso;
        }

        public double calcularPrecio()
        {
            int precioFinal = 0;

            if (antiguedad < 15)
            {
                precioFinal = (int)(precioBase * 0.99);
            }else
            {
                precioFinal = (int)(precioBase * 1.01);
            }
            if(numPiso <= 3)
            {
                precioFinal += (int)(precioBase * 0.03);
            }

            return precioFinal;
        }


        public string Direccion { get => direccion; set => direccion = value; }
    }
}
