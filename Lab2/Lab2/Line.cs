using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Line : Shape
    {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }

        public Line(String colour, int x1, int y1, int x2, int y2)
            : base(colour)
        {
            Vertex1 = new Vertex(x1, y1);
            Vertex2 = new Vertex(x2, y2);
        }

        public Line()
            : this("", 0, 0, 0, 0)
        {

        }

        public override void Translate(Vertex v){
            this.Vertex1.XCoord += v.XCoord;
            this.Vertex1.YCoord += v.YCoord;
            this.Vertex2.XCoord += v.XCoord;
            this.Vertex2.YCoord += v.YCoord;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nLine origin: (" + Vertex1.XCoord + ", " + Vertex1.YCoord + ")" +
                "\nLine End: (" + Vertex2.XCoord + ", " + Vertex2.YCoord + ")";
        }
    }
}
