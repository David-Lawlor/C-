using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Line("Blue", 0, 0, 3, 3));
            shapes.Add(new Line("Red", 0, 0, 2, 2));
            shapes.Add(new Circle("Green", 0, 0, 6));
            shapes.Add(new Circle("Yellow", 0, 0, 8));

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.ToString());
                if (s is Circle)
                {
                    Circle c = (Circle) s;
                    Console.WriteLine("The Area of the circle is {0}", c.Area());
                }
            }

            foreach (Shape s in shapes)
            {
                s.Translate(new Vertex(4, 4));
                Console.WriteLine(s.ToString());
                if (s is Circle)
                {
                    Circle c = (Circle)s;
                    Console.WriteLine("The Area of the circle is {0}", c.Area());
                }
            }

            Console.ReadLine();
        }
    }
}
