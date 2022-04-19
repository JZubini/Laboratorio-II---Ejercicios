using System;
using System.Text;
namespace Program
{
    class Program
    {
        /*
        private static bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                Console.WriteLine($"{item}");
                if (item != '0' && item != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public static string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                int potencias;
                double acumuladorOperacion;
                potencias = binario.Length;
                potencias--;
                acumuladorOperacion = 0;
                foreach(char item in binario)
                {
                    Console.WriteLine($"Potencias: {potencias}");
                    Console.WriteLine($"Items: {item}");
                    Console.WriteLine($"Math.Pow: {Math.Pow(2, potencias)}");
                    acumuladorOperacion = acumuladorOperacion + (Char.GetNumericValue(item) * Math.Pow(2, potencias));
                    potencias--;
                    Console.WriteLine($"Acumulador: {acumuladorOperacion}");
                }
                
                return acumuladorOperacion.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }
        */

        public static string DecimalBinario(string numero)
        {
            double valorConvertido;
            double valorAbsoluto;
            int valorEntero;
            int operacionDivision;
            int operacionResto;
            StringBuilder retornoFuncion;
            valorConvertido = Convert.ToDouble(numero);
            valorAbsoluto = Math.Abs(valorConvertido);
            valorEntero = (int)Math.Floor(valorAbsoluto); 
            retornoFuncion = new StringBuilder();
            do
            {
                operacionDivision = valorEntero / 2;
                operacionResto = valorEntero % 2;
                retornoFuncion.Append(operacionResto);
                valorEntero = operacionDivision;     
            } while (valorEntero > 0);
            return retornoFuncion.ToString();   
        }

        static void Main(string[] args)
        {
            string binario = "11";
            binario = Console.ReadLine();
            Console.WriteLine($"{DecimalBinario(binario)}"); 
        }
    }
}




