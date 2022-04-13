using System;
using System.Text;

namespace Ingresante
{
    public class Ingresantes
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresantes(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb;
            sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dirección: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"País: {this.pais}");
            foreach (string item in cursos)
            {
                sb.AppendLine($"Curso/s: {this.cursos}");
            }
            return sb.ToString();
        }
    }
}