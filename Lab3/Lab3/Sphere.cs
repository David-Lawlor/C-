using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Sphere : IHasVolume
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Sphere(string typeOfShape, double radius)
        {
            this.radius = radius;
        }

        public Sphere()
            : this("", 0)
        {

        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 3);
        }

        public override string ToString()
        {
            return base.ToString() + "\nThe radius of the sphere is " + radius + "\nThe volume of the sphere is " + CalculateVolume();
        }
    }
}

