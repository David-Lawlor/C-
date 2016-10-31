using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Shape : Object
    {
        public string Colour { get; set; }

        public Shape(string colour)
        {
            this.Colour = colour;
        }

        public Shape()
            : this("")
        {

        }

        public override string ToString()
        {
            return ("The colour of the shape is " + this.Colour) ;
        }

        public abstract void Translate(Vertex v);
    }
}
