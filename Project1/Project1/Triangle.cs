using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Triangle : Shape
    {
        private double bottom_edge;
        private double height;

        public double bottom
        {
            get { return this.bottom_edge; }
            set { this.bottom_edge = value; }
        }
        public double h
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public Triangle(double b, double h)
        {
            this.bottom_edge = b;
            this.height = h;
        }
        ~Triangle() { }
        public new void Input(double b, double h)
        {
            this.bottom_edge = b;
            this.height = h;

        }
        public new void Output()
        {
            Console.WriteLine("Bottom edge of triangle: " + this.bottom_edge);
            Console.WriteLine("Height of triangle: " + this.height);
        }
        public double AreaTriangle()
        {
            return this.bottom_edge * this.height / 2;
        }
    }
}
