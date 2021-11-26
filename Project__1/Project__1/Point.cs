using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
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
            Console.Write(" A-axis: ");
            this.a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B-axis: ");
            this.b = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine(" P(" + a + ";" + b + ")");
        }
    }
}
