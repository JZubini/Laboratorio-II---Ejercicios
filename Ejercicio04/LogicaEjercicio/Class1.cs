namespace LogicaEjercicio
{
    public class Divisores
    {

        public static bool esNumeroPerfecto(int numero)
        {
            bool retornoFuncionEsDivisor;
            int acumuladorDeDivisores;
            acumuladorDeDivisores = 0;
            for (int i = numero - 1; i > 0; i--)
            {
                retornoFuncionEsDivisor = Divisores.esDivisor(numero, i);
                if (retornoFuncionEsDivisor)
                {
                    acumuladorDeDivisores += i;
                }
            }
            if(acumuladorDeDivisores == numero)
            {
                return true;
            }
            return false;
        }


        public static bool esDivisor(int numeroIngresado, int numeroDivisor)
        {
            if (numeroIngresado % numeroDivisor == 0)
            {
                return true;
            }
            return false;
        }



    }
}