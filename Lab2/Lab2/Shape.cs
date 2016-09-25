using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Shape : Object
    {
        private string colour { get; set; }

        public Shape(string colour)
        {
            this.colour = colour;
        }

        public Shape()
            : this("")
        {

        }

        public override string ToString()
        {
            return ("The colour of the shape is " + this.colour) ;
        }

        public abstract void Translate(Vertex v);
    }
}
