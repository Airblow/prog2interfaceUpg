using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2interfaceUpg
{
    internal class Sphere : IShape
    {
        protected int width;

        public Sphere(int width)
        {
            this.width = width;
        }

        public double Area()
        {
            return 4 * Math.PI * width;
        }

        public double Circumferance()
        {
            return Math.PI * width;
        }
    }
}
