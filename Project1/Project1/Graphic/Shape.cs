using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Graphic
{
    abstract class Shape
    {
        private Point p1 = new Point();
        private Point p2 = new Point();
        private string color;
        private string type;
        private int typenum;

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
        public string TypeOfShape
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int TypeNumOfShape
        {
            get { return this.typenum; }
            set { this.typenum = value; }
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
            Console.WriteLine("\t1st Point:");
            p1.Input();
            Console.WriteLine("\t2nd Point:");
            p2.Input();
            Console.Write("\tColor: ");
            Color = Console.ReadLine();

        }
        public virtual void Output()
        {
            Console.WriteLine();
            Console.WriteLine("\tResult: ");
            Console.WriteLine("\t_________");
            Console.WriteLine("\tPoint1(" + p1.A + ";" + p1.B + ")");
            Console.WriteLine("\tPoint2(" + p2.A + ";" + p2.B + ")");
            Console.WriteLine("\tArea: " + AreaOfLine());
            Console.WriteLine("\tColor: " + color);
        }
        public abstract double AreaOfLine();

        public void Change(Shape temp)
        {
            Console.Write("\tEnter color: ");
            temp.Color = Console.ReadLine();
            Console.WriteLine("\tColor Changed!");

        }
        public void newPos(Point point1, Point point2)
        {
            Console.WriteLine("\tVector:");
            Console.Write("\tA= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tB= ");
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
