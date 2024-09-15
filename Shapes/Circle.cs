using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle :Shape
    {
        double  PI = Math.PI;

        public Circle(double cordinate1) : base(cordinate1,0)
         {
          
         }

        public double Area()
        {
            return PI*height*height;
        }
    }
}
