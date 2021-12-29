using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Graphic
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(Point p1, Point p2) : base(p1, p2)
        { }
        public override void Input()
        {
            base.Input();
            TypeOfShape = "Circle";
            TypeNumOfShape = 4;
        }
        public override void Output()
        {
            base.Output();
        }
        public override double AreaOfLine()
        {
            return (3.14 * (Math.Pow(P1.A - P2.A, 2) + Math.Pow(P1.B - P2.B, 2)));
        }

        public double AreaOfCircle(Point x, Point y)
        {
            double AreaOfCircle = 3.14 * (Math.Pow(x.A - y.A, 2) + Math.Pow(x.B - y.B, 2));
            return AreaOfCircle;
        }
    }
}
