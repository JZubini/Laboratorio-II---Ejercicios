using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        short cilindrada;
        EColores color;

        public Moto(short cilindrada, EColores color, short cantidadRuedas, short cantidadPuertas, short cantidadMarchas) : base(cantidadRuedas, cantidadPuertas, cantidadMarchas)
        {
            this.cilindrada = cilindrada;
            this.color = color;
        }
    }
}
