namespace Biblioteca
{
    public class Publicacion
    {
        private string titulo;
        private int cantidadDePaginas;
        protected DateTime fechaDePublicacion;
        public Publicacion(string titulo, int cantidadDePaginas)
        {
            this.titulo = titulo;
            this.cantidadDePaginas = cantidadDePaginas;
        }

        public string Titulo
        {
            get { return titulo; }
        }

        public int CantidadDePaginas
        {
            get { return cantidadDePaginas; }
            set { cantidadDePaginas = value; }
        }


    }
}