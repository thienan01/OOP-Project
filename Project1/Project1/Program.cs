using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0.5, 2);
            Point p2 = new Point();
            p2.Input(1, 2.4);
            Console.WriteLine("The point(x,y) has:");
            p1.Output();
            Console.WriteLine("******************************************************");
            // Shape
            Shape s1 = new Shape(p1, p2);
            s1.Output();
            Console.WriteLine("Length of two point of shape: " + s1.length());
            Console.WriteLine("******************************************************");
            // Line
            Point p3 = new Point(3, 6.2);
            Point p4 = new Point(1.8, 4);
            Line l1 = new Line(p3, p4);
            l1.Output();
            Console.WriteLine("Length of line: " + l1.length());
            Console.WriteLine("******************************************************");
            // Rectangle 
            Rectangle r1 = new Rectangle(3, 12.4);
            r1.Output();
            Console.WriteLine("Area of rectangle: " + r1.AreaRectangle());
            Console.WriteLine("******************************************************");
            // Triangle
            Triangle t1 = new Triangle(6, 13.9);
            t1.Output();
            Console.WriteLine("Area of triangle: " + t1.AreaTriangle());
            Console.WriteLine("******************************************************");
            //Circle
            Circle c1 = new Circle(9);
            c1.Output();
            Console.WriteLine("Area of Circle: " + c1.AreaCircle());
        }
    }
}
