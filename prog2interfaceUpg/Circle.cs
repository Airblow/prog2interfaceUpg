using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2interfaceUpg
{
    internal class Circle : IShape
    {
        protected int width;
        public Circle(int width)
        {
            this.width = width;
        }

        public double Area()
        {
            int radius = this.width / 2;
            return Math.Pow(radius, 2) * Math.PI;
        }

        public double Circumferance()
        {
            return Math.PI * this.width;
        } 

    }
}
