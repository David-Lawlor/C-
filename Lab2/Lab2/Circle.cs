using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Circle : Shape
    {
        public Vertex Origin{get; set;}
        public int Radius { get; set; }

        public Circle(string colour, int x, int y, int radius)
            : base(colour)
        {
            this.Origin = new Vertex(x, y);
            this.Radius = radius;
        }

        public Circle()
            : this("", 0, 0, 0)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nLine origin: (" + Origin.XCoord + ", " + Origin.YCoord + ")" +
                "\nRadius: " + Radius;
        }

        public override void Translate(Vertex v)
        {
            this.Origin.XCoord += v.XCoord;
            this.Origin.YCoord += v.YCoord;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2); 
        }
    }
}
