using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2interfaceUpg
{
    internal class Rectan : IShape
    {
        protected int width;
        protected int height;
        public Rectan(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return width * height;
        }

        public double Circumferance()
        {
            return width * 2 + height * 2;
        }
    }
    
}
