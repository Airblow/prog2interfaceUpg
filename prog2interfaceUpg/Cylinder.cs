using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2interfaceUpg
{
    internal class Cylinder : IShape
    {
        protected int width;
        protected int height;


        public Cylinder(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            int radius = width / 2;
            return 2 * Math.PI * height + 2 * Math.PI * Math.Pow(radius, 2);
        }

        public double Circumferance()
        {
            int radius = height / 2;
            return 2*Math.PI * radius;
            
        }
    }
}
