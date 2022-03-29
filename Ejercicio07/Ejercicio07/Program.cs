using System;
using LogicaEjercicio;
namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            string valorPorHoraString;
            string nombreEmpleadoString;
            string aniosDeAntiguedadString;
            string cantidadDeHorasTrabajadasString;
            string respuestaUsuario;

            int valorPorHoraInt;
            int aniosDeAntiguedadInt;
            int cantidadDeHorasTrabajadasInt;
            double montoNeto;
            double retornoFuncionImporteACobrar;

            bool retornoFuncionIntValorPorHora;
            bool retornoFuncionIntAnios;
            bool retornoFuncionIntCantidadDeHoras;

            montoNeto = 0;
            do
            {

                Console.WriteLine("Ingrese el valor por hora: ");
                valorPorHoraString = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombreEmpleadoString = Console.ReadLine();
                Console.WriteLine("Ingrese los años de antiguedad: ");
                aniosDeAntiguedadString = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
                cantidadDeHorasTrabajadasString = Console.ReadLine();

                retornoFuncionIntValorPorHora = int.TryParse(valorPorHoraString, out valorPorHoraInt);
                retornoFuncionIntAnios = int.TryParse(aniosDeAntiguedadString, out aniosDeAntiguedadInt);
                retornoFuncionIntCantidadDeHoras = int.TryParse(cantidadDeHorasTrabajadasString, out cantidadDeHorasTrabajadasInt);
                if (retornoFuncionIntValorPorHora == true && retornoFuncionIntAnios == true && retornoFuncionIntCantidadDeHoras == true)
                {
                    retornoFuncionImporteACobrar = Sueldo.importeACobrar(valorPorHoraInt, aniosDeAntiguedadInt, cantidadDeHorasTrabajadasInt);
                    montoNeto += retornoFuncionImporteACobrar;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Nombre del empleado: {0}" , nombreEmpleadoString);
                    Console.WriteLine("Anios de antiguedad: {0}" ,aniosDeAntiguedadInt);
                    Console.WriteLine("Valor por hora: {0}" ,valorPorHoraInt);
                    Console.WriteLine("Monto a cobrar: {0}" ,retornoFuncionImporteACobrar);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("¿Desea seguir calculando salarios?");
                    respuestaUsuario = Console.ReadLine();
                }
                else
                {
                    respuestaUsuario = "si";
                }
            } while ((respuestaUsuario == "si" || respuestaUsuario == "SI" || respuestaUsuario == "Si" || respuestaUsuario == "sI"));
            Console.WriteLine("Monto neto a cobrar: {0}" ,montoNeto);
        }
    }
}