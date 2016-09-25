using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Line : Shape
    {
        Vertex vertex1;
        Vertex vertex2;

        public Line(String colour, int x1, int y1, int x2, int y2)
            : base(colour)
        {
            vertex1 = new Vertex(x1, y1);
            vertex2 = new Vertex(x2, y2);
        }

        public Line()
            : this("", 0, 0, 0, 0)
        {

        }

        public override void Translate(Vertex v){
            this.vertex1.XCoord += v.XCoord;
            this.vertex1.YCoord += v.YCoord;
            this.vertex2.XCoord += v.XCoord;
            this.vertex2.YCoord += v.YCoord;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nLine origin: (" + vertex1.XCoord + ", " + vertex1.YCoord + ")" +
                "\nLine End: (" + vertex2.XCoord + ", " + vertex2.YCoord + ")";
        }
    }
}
