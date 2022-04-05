namespace LogicaEjercicio
{
    public class Boligrafo
    {
        static short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public ConsoleColor getColor()
        {
            return this.color;
        }

        short getTinta()
        {
            return this.tinta;
        }

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        private void SetTinta(short tinta)
        {
            int resultado;
            if(tinta < 0)
            {
                resultado = this.tinta - tinta;
                if(resultado >= 0) 
                {
                    this.tinta = (short)resultado;
                }
            }
            if(tinta > 0)
            {
                resultado = this.tinta + tinta;
                if (resultado <= 100)
                {
                    this.tinta = (short)resultado;
                }
            }
        }

        public void Recargar()
        {
            int tintaNecesariaParaCompletar;
            tintaNecesariaParaCompletar = 100;
            tintaNecesariaParaCompletar -= getTinta();
            SetTinta((short)tintaNecesariaParaCompletar);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short cantidadTintaActual;
            cantidadTintaActual = getTinta();

        }
        
    }
}