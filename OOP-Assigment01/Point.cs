using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment01
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Distance(Point other)
        {
            double deltaX = other.X - X;
            double deltaY = other.Y - Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
