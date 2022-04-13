using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Articulos : Publicacion
    {
        private string editorial;

        public Articulos(string editorial, string titulo, int cantidadDePaginas) : base(titulo, cantidadDePaginas)
        {
            this.editorial = editorial;
        }
    }
}
