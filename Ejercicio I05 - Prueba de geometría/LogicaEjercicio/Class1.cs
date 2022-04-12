namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public Punto(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float getArea()
        {
            return area;
        }
        public float getPerimetro()
        {
            return perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }

    }
}