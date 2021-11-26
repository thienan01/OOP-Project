using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(Point p1, Point p2) : base(p1, p2)
        { }
        public override void Input()
        {
            base.Input();
            Type = "Circle";
            Type2 = 2;
        }
        public override void Output()
        {
            base.Output();
        }
        public override double Area()
        {
            return (3.14 * (Math.Pow(P1.A - P2.A, 2) + Math.Pow(P1.B - P2.B, 2)));
        }
        public double Area(Point x, Point y)
        {
            double result = 3.14 * (Math.Pow(x.A - y.A, 2) + Math.Pow(x.B - y.B, 2));
            return result;
        }

    }
}
