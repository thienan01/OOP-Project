using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Rectangle : Shape
    {
        private double width;
        private double length;

        public double w
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double l
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public Rectangle(double w, double l)
        {
            this.width = w;
            this.length = l;
        }
        ~Rectangle() { }
        public new void Input(double w, double l)
        {
            if (w > l)
            {
                this.width = l;
                this.length = w;
            }
            else
            {
                this.width = w;
                this.length = l;
            }
        }
        public new void Output()
        {
            Console.WriteLine("Width of rectangle: " + this.width);
            Console.WriteLine("Height of ractangle: " + this.length);
        }
        public double AreaRectangle()
        {
            return this.width * this.length;
        }
    }
}
