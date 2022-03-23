
using System;
using LogicaValidador;
namespace Program
{
    class Program
    {
        public static int rangoMinimo = -100;
        public static int rangoMaximo = 100;
        static void Main(string[] args)
        {
            int valorIngresado;
            string valorIngresadoString;
            int i;
            bool retornoFuncionValidar;
            bool retornoFuncionInt;
            bool banderaPrimerIngreso = true;
            int valorMaximoIngresado;
            int valorMinimoIngresado;
            int contadorDeIngresosExitosos;
            int acumuladorDeNumerosIngresados;
            int promedioNumerosIngresados;
            contadorDeIngresosExitosos = 0;
            acumuladorDeNumerosIngresados = 0;
            valorMaximoIngresado = 0;
            valorMinimoIngresado = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero a continuación: ");
                valorIngresadoString = Console.ReadLine();
                retornoFuncionInt = int.TryParse(valorIngresadoString, out valorIngresado);
                retornoFuncionValidar = Validador.Validar(valorIngresado, rangoMinimo, rangoMaximo);
                if (retornoFuncionValidar && retornoFuncionInt)
                {
                    if (banderaPrimerIngreso)
                    {
                        valorMaximoIngresado = valorIngresado;
                        valorMinimoIngresado = valorIngresado;
                        banderaPrimerIngreso = false;
                    }
                    else
                    {
                        if (valorIngresado > valorMaximoIngresado)
                        {
                            valorMaximoIngresado = valorIngresado;
                        }
                        if (valorIngresado < valorMinimoIngresado)
                        {
                            valorMinimoIngresado = valorIngresado;
                        }
                    }
                    acumuladorDeNumerosIngresados += valorIngresado;
                    contadorDeIngresosExitosos++;
                }
            }
            promedioNumerosIngresados = acumuladorDeNumerosIngresados / contadorDeIngresosExitosos;
            Console.WriteLine("Numero mayor ingresado: {0} | Numero menor ingresado: {1} | Promedio: {2}", valorMaximoIngresado, valorMinimoIngresado, promedioNumerosIngresados);
        }
    }
}




