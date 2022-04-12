namespace LogicaEjercicio
{
    public class Bisiesto
    {
        public static bool esBisiesto(int añoIngresado)
        {
            if (añoIngresado % 100 == 0 && añoIngresado % 400 == 0) { 
                return true;
            }
            else
            {
                if (añoIngresado % 4 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}