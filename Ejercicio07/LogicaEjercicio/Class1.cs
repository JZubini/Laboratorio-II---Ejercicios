namespace LogicaEjercicio
{
    public class Sueldo
    {
        public const int bonoPorAñoDeAntiguedad = 150;
        public static double importeACobrar(int valorPorHoras, int aniosDeAntiguedad, int cantidadDeHoras)
        {
            double precioEnBruto;
            double bonoPorAntiguedadTotal;
            double montoBruto;
            double montoFinal;
            double descuentos;
            precioEnBruto = valorPorHoras * cantidadDeHoras;
            bonoPorAntiguedadTotal = aniosDeAntiguedad * bonoPorAñoDeAntiguedad;
            montoBruto = precioEnBruto + bonoPorAntiguedadTotal;
            descuentos = (montoBruto * 13) / 100;
            montoFinal = montoBruto - descuentos;
            return montoFinal;
        }
    }
}