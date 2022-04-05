using System;
using System.Text;
namespace Escuela
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static Random rnd;


        static Estudiante()
        {
            Estudiante.rnd = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void setNotaPrimerParcial(int nota)
        {
            if (nota > 0)
            {
                this.notaPrimerParcial = nota;
            }
        }
        public void setNotaSegundoParcial(int nota)
        {
            if (nota > 0)
            {
                this.notaSegundoParcial = nota;
            }
        }

        private float calcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public double calcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return rnd.Next(6, 10);
            }
            else
            {
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb;
            sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} {this.apellido} - Número de legajo: {this.legajo}");
            sb.AppendLine($"Nota PP: {this.notaPrimerParcial} | Nota SP: {this.notaSegundoParcial}");
            sb.AppendLine($"{calcularPromedio()}");
            if (calcularNotaFinal() != -1){
                sb.AppendLine($"{calcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
    }
}