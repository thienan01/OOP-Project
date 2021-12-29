using System;
using System.Collections.Generic;
using System.Text;
using Project1.Graphic;

namespace Project1.Graphic
{
    class Line : Shape
    {
        public Line() { }
        public Line(Point p1, Point p2) : base(p1, p2)
        { }

        public override void Input()
        {
            base.Input();
            TypeOfShape = "Line";
            TypeNumOfShape = 1;
        }
        public override void Output()
        {
            base.Output();
        }
        public override double AreaOfLine()
        {
            return (Math.Sqrt(Math.Pow(this.P1.A - this.P2.A, 2) + Math.Pow(this.P1.B - this.P2.B, 2)));
        }
        public double AreaOfLine(Point a, Point b)
        {
            double result;
            result = (Math.Sqrt(Math.Pow(a.A - b.A, 2) + Math.Pow(a.B - b.B, 2)));
            return result;
        }
    }
}
