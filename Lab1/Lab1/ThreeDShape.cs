using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class ThreeDShape : Object
    {
        readonly string typeOfShape;

        public ThreeDShape(string typeOfShape)
        {
            this.typeOfShape = typeOfShape;
        }

        public ThreeDShape()
            : this("")
        {

        }

        public abstract double CalculateVolume();


        public override string ToString()
        {
            return "Type of shape: " + this.typeOfShape;
        }
    }

    class Test3DShape
    {
        static void Main()
        {
            ThreeDShape shape1 = new Sphere("Sphere", 5);
            ThreeDShape shape2 = new Sphere("Sphere", 7);

            Console.WriteLine(shape1.ToString());

            List<ThreeDShape> shapes = new List<ThreeDShape>();
            shapes.Add(shape1);
            shapes.Add(shape2);

            foreach (ThreeDShape s in shapes)
            {
                Console.WriteLine(s.ToString());
            }

            Console.ReadLine();
        }
    }
}


