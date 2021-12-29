using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Graphic
{
    class Triangle : Shape
    {
        public Triangle() { }
        public Triangle(Point p1, Point p2) : base(p1, p2) { }
        public override void Input()
        {
            base.Input();
            TypeOfShape = "Triangle";
            TypeNumOfShape = 3;
        }
        public override void Output()
        {
            base.Output();
        }
        public override double AreaOfLine()
        {
            double AreaTriangle;
            Rectangle temp = new Rectangle(P1, P2);
            AreaTriangle = temp.AreaRectangle(P1, P2) / (double)2;
            return AreaTriangle;
        }
        public double AreaTriangle(Point p1, Point p2)
        {
            double AreaTriangle;
            Rectangle temp = new Rectangle(p1, p1);
            AreaTriangle = temp.AreaRectangle(p1, p2) / (double)2;
            return AreaTriangle;
        }
    }
}
