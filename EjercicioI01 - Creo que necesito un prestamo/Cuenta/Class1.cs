using System;

namespace Program
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string getTitutar()
        {
            return this.titular;
        }

        public bool setTitular(string titular)
        {
            if (!string.IsNullOrEmpty(titular))
            {
                this.titular = titular;
                return true;
            }
            return false;
        }

        public decimal getCantidad()
        {
            return this.cantidad;
        }

        public bool setCantidad(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad = cantidad;
                return true;
            }
            return false;
        }

        public void mostrar()
        {
            Console.WriteLine($"Titular: {getTitutar()}");
            Console.WriteLine($"Cantidad: {getCantidad()}");
        }

        public bool ingreso(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad += cantidad;
                return true;
            }
            return false;
        }

        public bool retirar(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad -= cantidad;
                return true;
            }
            return false;
        }

    }
}