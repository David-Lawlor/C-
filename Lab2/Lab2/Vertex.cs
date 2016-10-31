using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Vertex : Object
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }

        public Vertex(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        public Vertex()
            : this(0, 0)
        {

        }
    }
}
