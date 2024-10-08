using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2interfaceUpg
{
    internal class Triangle: IShape
    {
        protected int width;
        protected int height;

        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return (width * height) / 2;
        }

        public double Circumferance()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(height,2) + Math.Pow(width,2));
            return width + height + hypotenuse;
        }
    }
}
