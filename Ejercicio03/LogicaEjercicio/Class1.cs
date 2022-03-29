using System;
namespace LogicaEjercicio
{
    public class Primos
    {
        public static bool esPrimo(double numero)
        {
            decimal raizDelNumero;
            int parteEntera;
            int contadorDeDivisores;
            contadorDeDivisores = 0;
            raizDelNumero = (decimal)Math.Sqrt(numero);
            parteEntera = (int)Math.Truncate(raizDelNumero);
            for (int i = parteEntera; i > 0; i--)
            {
                if(numero % i == 0)
                {
                    contadorDeDivisores++;
                }
                if(contadorDeDivisores > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}