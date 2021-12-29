using System;
using System.Collections.Generic;
using System.Text;
using Project1.Graphic;

namespace Project1.Group
{
    class Combine
    {
        private List<Shape> list;
        private Point p1Max = new Point();
        private Point p2Max = new Point();

        public Point P1Max
        {
            get { return this.p1Max; }
            set { this.p1Max = value; }
        }
        public Point P2Max
        {
            get { return this.p2Max; }
            set { this.p2Max = value; }
        }
        public List<Shape> List
        {
            get { return this.list; }
            set { this.list = value; }
        }

        public Combine()
        {
            list = new List<Shape>();
        }

        ~Combine() { }

        public void newPos()
        {
            P1Max.A = Math.Min(list.ToArray()[0].P1.A, list.ToArray()[0].P2.A);
            for (int i = 1; i < list.Count; i++)
            {
                P1Max.A = Math.Min(P1Max.A, list.ToArray()[i].P1.A);
                P1Max.A = Math.Min(P1Max.A, list.ToArray()[i].P2.A);
            }

            P1Max.B = Math.Max(list.ToArray()[0].P1.B, list.ToArray()[0].P2.B);
            for (int i = 1; i < list.Count; i++)
            {
                P1Max.B = Math.Max(P1Max.B, list.ToArray()[i].P1.B);
                P1Max.B = Math.Max(P1Max.B, list.ToArray()[i].P2.B);
            }

            P2Max.A = Math.Max(list.ToArray()[0].P1.A, list.ToArray()[0].P2.A);
            for (int i = 1; i < list.Count; i++)
            {
                P2Max.A = Math.Max(P2Max.A, list.ToArray()[i].P1.A);
                P2Max.A = Math.Max(P2Max.A, list.ToArray()[i].P2.A);
            }

            P2Max.B = Math.Min(list.ToArray()[0].P1.B, list.ToArray()[0].P2.B);
            for (int i = 1; i < list.Count; i++)
            {
                P2Max.B = Math.Min(P2Max.B, list.ToArray()[i].P1.B);
                P2Max.B = Math.Min(P2Max.B, list.ToArray()[i].P2.B);
            }
        }
        public void Output()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\tNo data in your group!");
                return;
            }
            Console.WriteLine("\t---------------------------------------------");
            foreach (Shape shape in list)
            {
                Console.WriteLine("\tType of shape: " + shape.TypeOfShape);
                Console.WriteLine("\tPoint(" + shape.P1.A + "," + shape.P1.B + ")");
                Console.WriteLine("\tPoint(" + shape.P2.A + "," + shape.P2.B + ")");
                Console.WriteLine("\tArea: " + shape.AreaOfLine());
                Console.WriteLine("\tColor: " + shape.Color);
                Console.WriteLine();
            }
            newPos();
            Console.WriteLine($"\tNew position: ({P1Max.A}, {P1Max.B}); ({P2Max.A}, {P2Max.B})");
        }
        public void Group(List<Shape> listShape)
        {
            int countShape = 0;
            foreach (Shape shape in listShape)
            {
                list.Add(listShape.ToArray()[countShape++]);
            }
        }
        public void Ungroup()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\tFail");
                return;
            }
            list.Clear();
            Console.WriteLine("\tDone");
        }
    }
}
