namespace ClassLibrary1
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

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

    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
        public override string MiPropiedad
        {
            get
            {
                return miAtributo;
            }
        }
    }
}