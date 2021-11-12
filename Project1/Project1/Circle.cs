using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Circle : Shape
    {
        private double radius;

        public double r
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public Circle (double r)
        {
            this.radius = r;
        }
        public new void Input(double r)
        {
            this.radius = r;
        }
        public new void Output()
        {
            Console.WriteLine("Radius of Circle: " + this.radius);
        }
        public double AreaCircle()
        {
            return this.radius * this.radius * 3.14;
        }
    }
}
