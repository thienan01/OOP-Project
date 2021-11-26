using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
{
    class Triangle : Shape
    {
        public Triangle() { }
        public Triangle(Point p1, Point p2) : base(p1, p2) { }
        public override void Input()
        {
            base.Input();
            Type = "Triangle";
            Type2 = 4;
        }
        public override void Output()
        {
            base.Output();
        }
        public override double Area()
        {
            double result;
            Rectangle temp = new Rectangle(P1, P2);
            result = temp.Area(P1, P2);
            return result / (double)2;
        }
        public double Area(Point p1, Point p2)
        {
            double result;
            Rectangle temp = new Rectangle(p1, p1);
            result = temp.Area(p1, p2);
            return result / (double)2;
        }
    }
}
