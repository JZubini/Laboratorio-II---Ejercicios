using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        int pesoCarga;
        EColores color;

        public Camion(int pesoCarga, EColores color,short cantidadRuedas, short cantidadPuertas, short cantidadDeMarchas) : base(cantidadRuedas, cantidadPuertas, cantidadDeMarchas)
        {
            this.pesoCarga = pesoCarga;
            this.color = color;
        }
    }
}
