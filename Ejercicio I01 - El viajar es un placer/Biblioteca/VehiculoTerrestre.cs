using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoTerrestre
    {
        public enum EColores
        {
            Rojo,Blanco,Azul,Gris,Negro
        }
        short cantidadRuedas;
        short cantidadPuertas;
        short cantidadDeMarchas;


        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, short cantidadDeMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadDeMarchas = cantidadDeMarchas;
            
        }
    }
}
