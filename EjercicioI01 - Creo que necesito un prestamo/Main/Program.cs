using System;
using Program;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta C1 = new Cuenta("Julián Zubini", 5000);
            string respuestaUsuarioString;
            int respuestaUsuarioInt;
            bool retornoFuncionInt;
            decimal cantidadADepositar;
            decimal cantidadARetirar;
            do
            {
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al sistema de gestion, seleccione una opcion a continuacion: ");
                Console.WriteLine("1 - Mostrar datos");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Retirar");
                Console.WriteLine("4 - Salir");
                respuestaUsuarioString = Console.ReadLine();
                retornoFuncionInt = int.TryParse(respuestaUsuarioString, out respuestaUsuarioInt);
                switch (respuestaUsuarioInt)
                {
                    case 1:
                        C1.mostrar();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto a depositar: ");
                        cantidadADepositar = decimal.Parse(Console.ReadLine());
                        C1.ingreso(cantidadADepositar);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el monto a retirar: ");
                        cantidadARetirar = decimal.Parse(Console.ReadLine());
                        C1.retirar(cantidadARetirar);
                        break;
                    case 4:
                        Console.WriteLine("Fin del programa");
                        return;
                }
            } while (respuestaUsuarioInt != 4);

        }
    }
}