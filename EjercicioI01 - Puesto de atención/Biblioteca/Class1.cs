using System;
using System.Threading;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero) : this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public static bool operator == (Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1.numero == c2.numero);
        }

    }

    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Clientes
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool resultado = value + this;
            }
        }

        public int ClientesPendiente
        {
            get
            {
                return this.clientes.Count;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1); 
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n,Cliente c)
        {
            if(c != n)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator == (Negocio n, Cliente c)
        {
            foreach(Cliente cliente in n.clientes)
            {
                if(cliente == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Negocio n, Cliente c)
        {
            return !(c == n);
        }

        
        
    }

    public class PuestoAtencion
    {
        private static int numeroActual;
        public enum EPuesto { Caja1, Caja2 };
        private EPuesto puesto;

        public PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }
    }
}