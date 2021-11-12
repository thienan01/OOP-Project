using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Point
    {
        protected double x;
        protected double y;

        public double valueX
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double valueY
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public Point()
        {
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        ~Point() { }
        public void Input(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Output()
        {
            Console.WriteLine("x=" + this.x);
            Console.WriteLine("y=" + this.y);
        }
    }
}
