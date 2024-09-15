using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Shape
    {

        double _height = 0;
        double _width = 0;

        public double height
        {
            get { return _height; }
            set { _height = height; }
        }

        public double width
        {
            get { return _width; }
            set { _width = width; }
        }

        public Shape()
        {
         _height = 0;
            _width = 0;
        }

        public Shape(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double Area()
            { return _height * _width; }


    }
}
