using System.Text;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatadas;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public int PE
        {
            get
            {
                return this.partidosEmpatadas;
            }
            set
            {
                this.partidosEmpatadas = value;
            }
        }
        public int PG
        {
            get
            {
                return this.partidosGanados;
            }
            set
            {
                this.partidosGanados = value;
            }
        }
        public int PJ
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }
        public int PP
        {
            get
            {
                return this.partidosPerdidos;
            }
            set
            {
                this.partidosPerdidos = value;
            }
        }
        public int Puntuacion
        {
            get
            {
                return this.puntuacion;
            }
            set
            {
                this.puntuacion = value;
            }
        }
        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }
        

        public override bool Equals(object? obj)
        {
            Equipo equipo = obj as Equipo;
            return equipo is not null && this.Tipo == equipo.Tipo;
        }

        public static bool operator ==(Equipo EquipoA, Equipo EquipoB)
        {
            return (EquipoA.nombre == EquipoB.nombre) && Equals(EquipoA, EquipoB);
        }

        public static bool operator !=(Equipo EquipoA, Equipo EquipoB)
        {
            return !((EquipoA.nombre == EquipoB.nombre) && Equals(EquipoA, EquipoB));
        }

        protected string MostrarDatos()
        {
            StringBuilder retornoFuncion;
            retornoFuncion = new StringBuilder;
            retornoFuncion.Append($"El nombre del equipo es {this.nombre}");
            return retornoFuncion.ToString();
        }

        public virtual int GetDificultad() { }

        public static bool JugarPartido(Equipo EquipoA, Equipo EquipoB)
        {
            if(Equals(EquipoA, EquipoB))
            {

                return true;
            }
        }

    }
}