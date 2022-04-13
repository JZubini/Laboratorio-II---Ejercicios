using Biblioteca;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Publicacion publicacion = new Publicacion("Batman", 50);
            Libro libro = new Libro(1234567891,"Horacio Quiroga", "Los cuentos de la selva", 120);
            Libro libro1 = new Libro(1234567891, "Tolkien", "El señor de los anillos", 120);
            Libro libro2 = new Libro(1234567891, "R R Martin", "Game of thrones", 120);
            Libro libro3 = new Libro(1234567891, "oracio Quiroga", "Cuentos de amor, de locura y de muerte", 120);
            Articulos articulos = new Articulos("UTN", "Herencia en C#", 1250);

            List<Publicacion> list = new List<Publicacion>();
            list.Add(libro);
            list.Add(libro1);
            list.Add(libro2);
            list.Add(libro3);
            list.Add(articulos);

            
            foreach (Publicacion item in list)
            {
                mostrarInformacion(item);
            }
        }

        public static void mostrarInformacion(Publicacion publicacion)
        {
            Console.WriteLine($"Titulo: {publicacion.Titulo}");
            Console.WriteLine($"Cantidad de páginas: {publicacion.CantidadDePaginas}");
            Console.WriteLine($"{publicacion.GetType().Name}");
        }
    }
}
