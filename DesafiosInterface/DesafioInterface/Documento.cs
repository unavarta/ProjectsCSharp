﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface
{
    public class Documento: IImprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy un archivo Word!");
        }
    }
}
