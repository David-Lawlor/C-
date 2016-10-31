using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Sphere : IHasVolume
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            this.Radius = radius;
        }

        public Sphere()
            : this(0)
        {

        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 3);
        }

        public override string ToString()
        {
            return "\nThe radius of the sphere is " + Radius + "\nThe volume of the sphere is " + CalculateVolume();
        }
    }
}

