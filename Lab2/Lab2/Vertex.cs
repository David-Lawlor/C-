using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Vertex : Object
    {
        private int xCoord;

        public int XCoord
        {
            get { return xCoord; }
            set { xCoord = value; }
        }
        private int yCoord;

        public int YCoord
        {
            get { return yCoord; }
            set { yCoord = value; }
        }

        public Vertex(int xCoord, int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public Vertex()
            : this(0, 0)
        {

        }
    }
}
