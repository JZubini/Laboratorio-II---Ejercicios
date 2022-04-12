using System;
using Biblioteca;
namespace Program
{
    class Program
    {
        static void Main(string [] args)
        {
            /*
            #region Atributos
            Jugador jugador = new Jugador(123456,"Ale", 10, 5);
            Jugador jugador2 = new Jugador(987654, "Pedro", 20, 10);

            Console.WriteLine($"DNI original: {jugador.Dni}");
            jugador.Dni = 456789;
            Console.WriteLine($"DNI alterado: {jugador.Dni}");
            Console.WriteLine($"Total de goles: {jugador.TotalGoles}");
            Console.WriteLine("\n");
            Console.WriteLine($"Nombre original: {jugador.Nombre}");
            jugador.Nombre = "Pepe";
            Console.WriteLine($"Nombre alterado: {jugador.Nombre}");
            Console.WriteLine("\n");
            Console.WriteLine($"Promedio de goles: {jugador.PromedioGoles}");

            Console.WriteLine("\n");
            List<Jugador> jugadorList = new List<Jugador> { };
            jugadorList.Add(jugador);
            jugadorList.Add(jugador2);

            foreach(Jugador item in jugadorList)
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
                Console.WriteLine($"Promedio de goles: {item.PromedioGoles}");
            }
            #endregion
            Console.WriteLine("\n");
            #region Enumerados
            int colorComoEntero = (int)jugador.ColorCamiseta;
            //jugador.ColorCamiseta = Jugador.Color.Azul;
            jugador.ColorCamiseta = (Jugador.Color)2;
            Console.WriteLine($"Color camiseta: {jugador.ColorCamiseta}");
            Console.WriteLine($"Numero de color: {colorComoEntero}");
            #endregion
            */

            #region Indexadores

            Dias dias = new Dias();
            Console.WriteLine(dias[2]);
            
            #endregion

        }

    }
}




