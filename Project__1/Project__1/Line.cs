using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
{
    class Line : Shape
    {
        public Line() { }
        public Line(Point p1, Point p2) : base(p1, p2)
        { }

        public override void Input()
        {
            base.Input();
            Type = "Line";
            Type2 = 1;
        }
        public override void Output()
        {
            base.Output();
        }
        public override double Area()
        {
            return (Math.Sqrt(Math.Pow(this.P1.A - this.P2.A, 2) + Math.Pow(this.P1.B - this.P2.B, 2)));
        }
        public double Area(Point a, Point b)
        {
            double result;
            result = (Math.Sqrt(Math.Pow(a.A - b.A, 2) + Math.Pow(a.B - b.B, 2)));
            return result;
        }

    }
}
