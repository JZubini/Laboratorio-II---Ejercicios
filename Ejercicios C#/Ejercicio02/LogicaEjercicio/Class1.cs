namespace LogicaEjercicio
{
    public class Validador
    {
        public static bool validarNumeroPositivo(double numeroIngresado)
        {
            if(numeroIngresado > 0)
            {
                return true;
            }
            return false;
        }
    }
}