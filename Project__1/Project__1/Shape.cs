using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
{
    abstract class Shape
    {
        private Point p1 = new Point();
        private Point p2 = new Point();
        private string color;
        private string type;
        private int type2;

        public Point P1
        {
            get { return this.p1; }
            set { this.p1 = value; }
        }
        public Point P2
        {
            get { return this.p2; }
            set { this.p2 = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int Type2
        {
            get { return this.type2; }
            set { this.type2 = value; }
        }

        public Shape() { }
        public Shape(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        ~Shape() { }

        public virtual void Input()
        {
            Console.WriteLine(" 1st Point:");
            p1.Input();
            Console.WriteLine(" 2nd Point:");
            p2.Input();
            Console.Write(" Color: ");
            Color = Console.ReadLine();

        }
        public virtual void Output()
        {
            Console.WriteLine();
            Console.WriteLine(" Result: ");
            Console.WriteLine("_________");
            Console.WriteLine(" Point1(" + p1.A + ";" + p1.B + ")");
            Console.WriteLine(" Point2(" + p2.A + ";" + p2.B + ")");
            Console.WriteLine(" Area: " + Area());
            Console.WriteLine(" Color: " + color);
        }
        public abstract double Area();

        public void Change(Shape temp)
        {
            Console.Write(" Enter color: ");
            temp.Color = Console.ReadLine();
            Console.WriteLine(" Color Changed!");

        }
        public void newPos(Point point1, Point point2)
        {
            Console.WriteLine(" Vector:");
            Console.Write(" A= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B= ");
            int b = Convert.ToInt32(Console.ReadLine());

            point1.A += a;
            point1.B += b;

            point2.A += a;
            point2.B += b;

            point1.Output();
            point2.Output();
        }
    }
}
