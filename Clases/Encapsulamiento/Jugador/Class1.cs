using System;

namespace Biblioteca
{
    public class Jugador
    {
        public enum Color
        {
            Azul, Rojo, Verde
        }

        private Color color;
        private int dni;
        //private string nombre;
        private int partidosJugados;
        private int totalGoles;

        public Color ColorCamiseta
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;
            }

        }

        public float PromedioGoles
        {
            get
            {
                return (float)totalGoles / partidosJugados;
            }
        }



        public string Nombre { get; set; }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
        {
            this.dni = dni;
            this.Nombre = nombre;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }



    }

    public class Dias
    {
        private string[] diasHabiles = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };

        public string this[int index]
        {
            get
            {
                if (index < diasHabiles.Length)
                {
                    return diasHabiles[index];
                }
                return string.Empty;
            }
            set
            {
                if (index < diasHabiles.Length)
                {
                    diasHabiles[index] = value;
                }
            }
        }
    }
}