using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Graphic
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
            TypeOfShape = "Rectangle";
            TypeNumOfShape = 2;
        }
        public override void Output()
        {
            base.Output();
        }
        public override double AreaOfLine()
        {
            double AreaRectangle = 0;
            Point p = new Point();
            p.A = P1.A;
            p.B = P2.B;
            Line temp = new Line(P1, p);
            length = temp.AreaOfLine(P1, p);
            temp = new Line(P2, p);
            width = temp.AreaOfLine(P2, p);
            if (P1.A == P2.A)
                AreaRectangle = length * P1.A;
            else if (P1.B == P2.B)
                AreaRectangle = width * P1.B;
            else
                AreaRectangle = length * width;
            return AreaRectangle;
        }
        public double AreaRectangle(Point x, Point y)
        {
            double AreaRectangle = 0;
            Point p = new Point();
            p.A = x.A;
            p.B = y.B;
            Line temp = new Line(x, p);
            length = temp.AreaOfLine(x, p);
            temp = new Line(P2, p);
            width = temp.AreaOfLine(y, p);
            if (x == y)
                AreaRectangle = length * P1.A;
            else
                AreaRectangle = length * width;
            return AreaRectangle;
        }
    }
}
