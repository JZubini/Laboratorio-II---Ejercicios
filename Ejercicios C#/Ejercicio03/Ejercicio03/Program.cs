using System;
using LogicaEjercicio;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorIngresado;
            string valorIngresadoString;
            bool retornoFuncionInt;
            bool retornoFuncionPrimo;
            Console.WriteLine("Ingrese hasta que numero desea conocer: ");
            valorIngresadoString = Console.ReadLine();
            retornoFuncionInt = int.TryParse(valorIngresadoString, out valorIngresado);
            while(retornoFuncionInt == false)
            {
                Console.WriteLine("ERROR, el valor ingresado no es un numero, reingrese a continuacion o si desea abandonar ingrese 'salir' ");
                valorIngresadoString = Console.ReadLine();
                if(valorIngresadoString == "salir" || valorIngresadoString == "SALIR")
                {
                    Console.WriteLine("FIN DEL PROGRAMA");
                    return;
                }
                retornoFuncionInt = int.TryParse(valorIngresadoString, out valorIngresado);
            }
            for(int i = valorIngresado; i > 0; i--)
            {
                retornoFuncionPrimo = Primos.esPrimo(i);
                if (retornoFuncionPrimo)
                {
                    Console.WriteLine("{0}",i);
                }
            }
        }
    }
}