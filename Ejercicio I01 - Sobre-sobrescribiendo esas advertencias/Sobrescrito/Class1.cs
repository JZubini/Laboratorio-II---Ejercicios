namespace Biblioteca
{
    public class Sobrescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object? obj)
        {
            Sobrescrito sbr = obj as Sobrescrito;
            return sbr is not null && this == (Sobrescrito)obj;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}