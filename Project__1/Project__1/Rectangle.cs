using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public Rectangle() { }
        public Rectangle(Point p1, Point p2) : base(p1, p2)
        { }

        public override void Input()
        {
            base.Input();
            Type = "Rectangle";
            Type2 = 3;
        }
        public override void Output()
        {
            base.Output();
        }
        public override double Area()
        {
            double result = 0;
            Point p = new Point();
            p.A = P1.A;
            p.B = P2.B;
            Line temp = new Line(P1, p);
            length = temp.Area(P1, p);
            temp = new Line(P2, p);
            width = temp.Area(P2, p);
            result = length * width;
            return result;
        }
        public double Area(Point x, Point y)
        {
            double result = 0;
            Point p = new Point();
            p.A = x.A;
            p.B = y.B;
            Line temp = new Line(x, p);
            length = temp.Area(x, p);
            temp = new Line(P2, p);
            width = temp.Area(y, p);
            result = length * width;
            return result;
        }
    }
}
