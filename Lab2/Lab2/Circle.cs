using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Circle : Shape
    {
        private Vertex origin;
        private int radius;

        public Circle(string colour, int x, int y, int radius)
            : base(colour)
        {
            this.origin = new Vertex(x, y);
            this.radius = radius;
        }

        public Circle()
            : this("", 0, 0, 0)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nLine origin: (" + origin.XCoord + ", " + origin.YCoord + ")" +
                "\nRadius: " + radius;
        }

        public override void Translate(Vertex v)
        {
            this.origin.XCoord += v.XCoord;
            this.origin.YCoord += v.YCoord;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2); 
        }
    }
}
