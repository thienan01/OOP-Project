using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Line : Shape
    {
        public Line(Point a, Point b) : base(a, b)
        {
            this.p1 = a;
            this.p2 = b;
        }
        public Line() { }
        ~Line() { }
        public new void Input(Point a, Point b)
        {
            base.Input(a, b);
        }

        public new void Output()
        {
            base.Output();
        }
        public double length()
        {
            return base.length();
        }
    }
}
