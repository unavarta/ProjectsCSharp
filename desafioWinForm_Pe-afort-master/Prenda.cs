using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms
{
    public abstract class Prenda
    {
        private bool _calidadEstandar;
        private bool _calidadPremium;

        public bool CalidadEstandar { get => _calidadEstandar; set => _calidadEstandar = value; }
        public bool CalidadPremium { get => _calidadPremium; set => _calidadPremium = value; }

        public abstract float calcularValor(float precio, int cant);

    }
}
