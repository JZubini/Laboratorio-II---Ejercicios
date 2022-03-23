namespace LogicaValidador
{
    public class Validador
    {
        public static bool Validar(int valor, int valorMinimo, int valorMax)
        {
            if (valor > valorMinimo && valor < valorMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}