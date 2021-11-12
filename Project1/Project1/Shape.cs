using System;
using System.Collections.Generic;
using System.Text;
namespace Project1
{
    class Shape : Point
    {
        protected Point p1;
        protected Point p2;
        public Shape() { }
        public Shape(Point a, Point b)
        {
            this.p1 = a;
            this.p2 = b;
        }
        ~Shape() { }
        public new void Input(Point a, Point b)
        {
            this.p1 = a;
            this.p2 = b;
        }

        public new void Output()
        {
            Console.WriteLine("Point 1:");
            this.p1.Output();
            Console.WriteLine("Point 2:");
            this.p2.Output();
        }
        public double length()
        {
            return Math.Sqrt(Math.Pow(this.p2.valueX - this.p1.valueX, 2) + Math.Pow(this.p2.valueY - this.p1.valueY, 2));
        }
        public double length2(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.valueX - b.valueX, 2) + Math.Pow(a.valueY - b.valueY, 2));
        }
    }
}
