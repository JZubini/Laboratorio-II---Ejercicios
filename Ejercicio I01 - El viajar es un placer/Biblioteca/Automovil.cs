namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        int cantidadPasajeros;
        EColores color;
        public Automovil(int cantidadPasajeros, short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas) : base(cantidadRuedas, cantidadPuertas, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
            this.color = color;
        }



    }
}