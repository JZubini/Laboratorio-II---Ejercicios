using System;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public double getCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.getCotizacion() * d.cantidad);
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(Peso.getCotizacion() * d.cantidad);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator != (Dolar d, Euro e)
        {
            return (d.getCantidad != e.getCantidad);
        }

        public static bool operator != (Dolar d, Peso p)
        {
            return (d.getCantidad != p.getCantidad);
        }

        public static bool operator != (Dolar d1, Dolar d2)
        {
            return (d1.getCantidad == d2.getCantidad);
        }

        public static bool operator == (Dolar d, Euro e)
        {
            return (d.getCantidad == e.getCantidad);
        }

        public static bool operator == (Dolar d, Peso p)
        {
            return (d.getCantidad == p.getCantidad);
        }

        public static bool operator == (Dolar d1, Dolar d2)
        {
            return (d1.getCantidad == d2.getCantidad);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return 
        }
    }

    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Euro()
        {
            cotzRespectoDolar = 1 / 1.17d;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad,double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public static double getCotizacion()
        {
            return cotzRespectoDolar;
        }

    }

    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Peso()
        {
            cotzRespectoDolar = 102.65d;
        }

        public Peso(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public static double getCotizacion()
        {
            return cotzRespectoDolar;
        }

    }
}