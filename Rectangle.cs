using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Expression-bodied property
        public double Area => Length * Width;

        // Expression-bodied method
        public double GetPerimeter() => 2 * (Length + Width);
    }
}
