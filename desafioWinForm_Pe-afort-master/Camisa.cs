using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms
{
    public class Camisa : Prenda
    {
        private bool esMangaCorta;

        public Camisa(bool esMangaCorta)
        {
            this.esMangaCorta = esMangaCorta;
        }

        public bool EsMangaCorta { get => esMangaCorta; set => esMangaCorta = value; }

        public override float calcularValor(float precio, int cant)
        {
            float precioFinal = precio;
            if (esMangaCorta) { precioFinal -= precioFinal * 0.10f; }
            else if (CalidadPremium) { precioFinal += precioFinal * 0.30f; }
            precioFinal = (float)precioFinal * cant;
            return precioFinal;
        }
    }
}
