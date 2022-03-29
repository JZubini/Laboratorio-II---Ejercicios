using System;
using LogicaEjercicio;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            string anioInicioString;
            string anioFinalString;
            int anioInicioInt;
            int anioFinalInt;
            bool retornoFuncionIntAnioInicio;
            bool retornoFuncionIntAnioFinal;
            bool retonoFuncionEsBisiesto;
            Console.WriteLine("Ingrese el año de inicio: ");
            anioInicioString = Console.ReadLine();
            Console.WriteLine("Ingrese el año final: ");
            anioFinalString = Console.ReadLine();
            retornoFuncionIntAnioInicio = int.TryParse(anioInicioString, out anioInicioInt);
            retornoFuncionIntAnioFinal = int.TryParse(anioFinalString, out anioFinalInt);
            if (retornoFuncionIntAnioInicio == true && retornoFuncionIntAnioFinal == true)
            {
                for (int i = anioInicioInt; i <= anioFinalInt;i++)
                {
                    retonoFuncionEsBisiesto = Bisiesto.esBisiesto(i);
                    if (retonoFuncionEsBisiesto)
                    {
                        Console.WriteLine("{0}",i);
                    }
                }
            }
        }
    }
}