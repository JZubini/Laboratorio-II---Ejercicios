using System;
using System.Text;
using Escuela;
namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudiante E1 = new Estudiante("Julián", "Zubini", "01");
            Estudiante E2 = new Estudiante("Franco", "Aguilar", "02");
            Estudiante E3 = new Estudiante("Marcelo", "Flores", "03");

            E1.setNotaPrimerParcial(8);
            E1.setNotaSegundoParcial(8);
            E2.setNotaPrimerParcial(7);
            E2.setNotaSegundoParcial(7);
            E3.setNotaPrimerParcial(1);
            E3.setNotaSegundoParcial(3);

            Console.WriteLine("--------Alumno 1--------");
            Console.WriteLine($"{E1.Mostrar()}");
            Console.WriteLine("--------Alumno 2--------");
            Console.WriteLine($"{E2.Mostrar()}");
            Console.WriteLine("--------Alumno 3--------");
            Console.WriteLine($"{E3.Mostrar()}");

        }
    }
}