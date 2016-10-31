using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Sphere : ThreeDShape
    {
        public double radius{get; set;}

        public Sphere(string typeOfShape, double radius): base(typeOfShape)
        {
            this.radius = radius;
        }

        public Sphere()
            : this("", 0)
        {

        }

        public override double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 3);
        }

        public override string ToString()
        {
            return base.ToString() + "\nThe radius of the sphere is " + radius + "\nThe volume of the spgere is " + CalculateVolume();
        }
    }
}
