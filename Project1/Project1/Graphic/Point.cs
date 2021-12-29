using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Graphic
{
    class Point
    {
        private int a;
        private int b;

        public int A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        public int B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public Point() { }
        public Point(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        ~Point() { }

        public void Input()
        {
            Console.Write("\tA-axis: ");
            this.a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tB-axis: ");
            this.b = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("\tP(" + a + ";" + b + ")");
        }
    }
}
