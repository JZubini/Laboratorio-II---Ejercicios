namespace Biblioteca
{
    public sealed class Libro : Publicacion
    {
        private int ISBN;
        private string autor;

        public Libro(int iSBN, string autor, string titulo, int cantidadDePaginas)
            : base(titulo, cantidadDePaginas)
        {
            ISBN = iSBN;
            this.autor = autor;
            this.fechaDePublicacion = DateTime.Now;
        }
         
        

    }
}
