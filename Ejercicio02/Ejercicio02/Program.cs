using System;
using LogicaEjercicio;
namespace Program
{
    class Program
    {
        static void Main(string[] args) { 
            string numeroIngresadoString;
            double numeroIngresado;
            bool retornoFuncionValidador;
            bool retornoFuncionInt;
            double numeroAlCuadrado;
            double numeroAlCubo;
            Console.WriteLine("Ingrese un numero a continuacion: ");
            numeroIngresadoString = Console.ReadLine();
            retornoFuncionInt = double.TryParse(numeroIngresadoString, out numeroIngresado);
            retornoFuncionValidador = Validador.validarNumeroPositivo(numeroIngresado);
            while(retornoFuncionInt == false || retornoFuncionValidador == false)
            {
                Console.WriteLine("ERROR, el valor ingresado no es un numero o es un numero negativo, reingrese a continuacion: ");
                numeroIngresadoString = Console.ReadLine();
                retornoFuncionInt = double.TryParse(numeroIngresadoString, out numeroIngresado);
                retornoFuncionValidador = Validador.validarNumeroPositivo(numeroIngresado);
            }
            Console.WriteLine("----------------------------------------");
            numeroAlCuadrado = Math.Pow(numeroIngresado, 2);
            numeroAlCubo = Math.Pow(numeroIngresado, 3);
            Console.WriteLine("{0}² = {1} | {2}³ = {3}" ,numeroIngresado,numeroAlCuadrado,numeroIngresado,numeroAlCubo);
        }
    }
}