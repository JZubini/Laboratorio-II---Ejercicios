using System;
using System.Text;

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

        public short getTinta()
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
                resultado = this.tinta + tinta;
                if(resultado >= 0 && resultado <= cantidadTintaMaxima) 
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
            StringBuilder sb;
            short cantidadDeTintaUtilizada;
            cantidadTintaActual = getTinta();
            cantidadDeTintaUtilizada = 0;
            sb = new StringBuilder();
            int i;
            if (cantidadTintaActual > 0) { 
                for (i = gasto; i > 0;i--)
                {
                    if (cantidadTintaActual == 0)
                    {
                        break;
                    }
                    cantidadDeTintaUtilizada--;
                    cantidadTintaActual--;
                    sb.Append("*");
                }
                SetTinta(cantidadDeTintaUtilizada);
            }
            dibujo = sb.ToString();
            if(dibujo is null)
            {
                return false;
            }
            return true;
        }
        
    }
}