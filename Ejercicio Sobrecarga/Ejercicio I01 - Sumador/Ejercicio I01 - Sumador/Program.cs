using System;
using LogicaEjercicio;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador();

            Console.WriteLine($"{s1.Sumar(1,2)}");
            Console.WriteLine($"{s2.Sumar("a", "b")}");

            Console.WriteLine("--------------------------");

            Console.WriteLine($"{s1 + s2}");
            Console.WriteLine($"{s1 | s2}");
        }
    }
}




