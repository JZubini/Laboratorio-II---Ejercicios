using System;
using System.Text;
using LogicaEjercicio;
namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Boligrafo Azul = new Boligrafo(0, ConsoleColor.Blue);
            Boligrafo Rojo = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;
            #region Funcion getColor
            Console.WriteLine("------Función getColor------");
            Console.WriteLine($"{Azul.getColor()}");
            Console.WriteLine($"{Rojo.getColor()}");
            Console.WriteLine("----------------------------");
            #endregion
            #region Funcion getTinta
            Console.WriteLine("------Función getTinta------");
            Console.WriteLine($"{Azul.getTinta()}");
            Console.WriteLine($"{Rojo.getTinta()}");
            Console.WriteLine("----------------------------");
            #endregion
            #region Función recargar
            Console.WriteLine("------Función Recargar------");
            Console.WriteLine($"Tinta actual: {Rojo.getTinta()}");
            Rojo.Recargar();
            Console.WriteLine($"Tinta recargada: {Rojo.getTinta()}");
            Console.WriteLine("----------------------------");
            #endregion
            #region Pintar
            Azul.Pintar(5, out dibujo);
            if (dibujo != "")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{dibujo}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("No hay tinta en la lapicera para dibujar");
            }
            #endregion
        }
    }
}