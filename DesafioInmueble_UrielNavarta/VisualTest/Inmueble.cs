using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTest
{
    abstract class Inmueble
    {
        protected string direccion;
      

        //getters and setters
        public string Direccion { get => direccion; set => direccion = value; }

        //constructor
        public Inmueble(string direccion)
        {
            this.direccion = direccion;
        }



    }
}
