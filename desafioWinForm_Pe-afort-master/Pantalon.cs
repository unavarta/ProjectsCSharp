using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms
{
    public class Pantalon : Prenda
    {
        private bool _esBermuda = true;

        public Pantalon(bool esBermuda)
        {
            _esBermuda = esBermuda;
        }

        public bool EsBermuda { set => _esBermuda = value; }

        public override float calcularValor(float precio, int cant)
        {
            float precioFinal = precio;
            if (_esBermuda)     { precioFinal -= precioFinal * 0.20f; }
            if (CalidadPremium) { precioFinal += precioFinal * 0.30f; }
            precioFinal = (float)precioFinal * cant;
            return precioFinal;
        }
    }
}
