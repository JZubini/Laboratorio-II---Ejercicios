using System;
using LogicaEjercicio;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retornoFuncionEsNumeroPerfecto;
            int contadorDeNumerosPerfectos;
            int incrementador; 
            contadorDeNumerosPerfectos = 0;
            incrementador = 1;
            while (contadorDeNumerosPerfectos < 4)
            {
                retornoFuncionEsNumeroPerfecto = Divisores.esNumeroPerfecto(incrementador);
                if (retornoFuncionEsNumeroPerfecto)
                {
                    contadorDeNumerosPerfectos++;
                    Console.WriteLine("{0}",incrementador);
                }
                incrementador++;
            }
        }
    }
}