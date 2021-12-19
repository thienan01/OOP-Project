using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
{
    class Menu : Shape
    {
        private List<Shape> listShape;
        private Group mergeShape;
        public Menu()
        {
            this.listShape = new List<Shape>();
            this.mergeShape = new Group();
        }

        ~Menu() { }
        public override void Input()
        {
            int option;
            do
            {
                Console.WriteLine("------------ Paint Application -------------");
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("----------------MAIN MENU-------------------");
                Console.WriteLine("\n ");
                Console.WriteLine("1.   Line: ");
                Console.WriteLine("2.   Rectangle: ");
                Console.WriteLine("3.   Triangle: ");
                Console.WriteLine("4.   Circle: ");
                Console.WriteLine("5.   Group: ");
                Console.WriteLine("6.   Ungroup: ");
                Console.WriteLine("7.   Move: ");
                Console.WriteLine("8.   Color : ");
                Console.WriteLine("9.   Exit : ");
                Console.WriteLine("\n ");
                Console.Write("    PLEASE ENTER OPTIONS: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n ");
                Console.WriteLine("_______________________________________________________");

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\t LINE:");
                        Line l1 = new Line();
                        l1.Input();
                        l1.Output();
                        listShape.Add(l1);
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\t RECTANGLE:");
                        Shape r1 = new Rectangle();
                        r1.Input();
                        r1.Output();
                        listShape.Add(r1);
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("\t TRIANGLE:");
                        Shape t1 = new Triangle();
                        t1.Input();
                        t1.Output();
                        listShape.Add(t1);
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\t CIRCLE:");
                        Shape c1 = new Circle();
                        c1.Input();
                        c1.Output();
                        listShape.Add(c1);
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\t GROUP:");
                        mergeShape.group(this.listShape);
                        Console.WriteLine("Group Done \n");
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\t UNGROUP:");
                        mergeShape.ungroup();
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("\t MOVE POSITION:");
                        Console.Write(" 1-Shape or 2-Group: ");
                        int numShape = Convert.ToInt32(Console.ReadLine());
                        if (numShape < 1 || numShape > 2)
                        {
                            Console.WriteLine(" Please Re-Enter: ");
                            break;
                        }
                        int temp = 0;
                        if (numShape == 1)
                        {
                            Console.WriteLine(" Shape 1 \t Shape 2 \t Shape 3 \t Shape 4");
                            numShape = Convert.ToInt32(Console.ReadLine());
                            if (numShape < 1 || numShape > 4)
                            {
                                Console.WriteLine(" Please Re-Enter: ");
                                break;
                            }
                            for (int i = 0; i < listShape.Count; i++)
                            {
                                if (listShape.ToArray()[i].Type2 == numShape)
                                {
                                    listShape.ToArray()[i].newPos(listShape.ToArray()[i].P1, listShape.ToArray()[i].P2);
                                    temp++;
                                }
                            }
                            if (temp == 0)
                            {
                                Console.WriteLine(" No Data");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" Done");
                                break;
                            }
                        }
                        else
                        {
                            temp = 0;
                            for (int i = 0; i < mergeShape.List.Count; i++)
                                temp++;
                            if (temp == 0)
                            {
                                Console.WriteLine(" No Data");
                            }
                            else
                            {
                                mergeShape.newPos();
                                Console.WriteLine(" Done");
                            }
                        }
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("\t NEW COLOR:");
                        Console.Write(" Change color?(1-Shape or 2-Group):");
                        int k = Convert.ToInt32(Console.ReadLine());

                        Change(k);
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Please re-enter: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (option != 9);
        }
        public void Change(int x)
        {
            int temp = 0;
            if (x == 1)
            {
                Console.Write(" Select a shape you need to change color(1 to 4): ");
                int numShape = Convert.ToInt32(Console.ReadLine());
                if (numShape < 1 || numShape > 4)
                {
                    Console.WriteLine(" Fail");
                    return;
                }
                for (int i = 0; i < listShape.Count; i++)
                {
                    if (listShape.ToArray()[i].Type2 == numShape)
                    {
                        Console.Write(" New color: ");
                        listShape.ToArray()[i].Color = Console.ReadLine();
                        temp++;
                    }
                }
                if (temp == 0) Console.WriteLine(" No data!");
            }
            else
            {
                temp = 0;
                Console.Write(" New color: ");
                string col = Console.ReadLine();
                for (int i = 0; i < mergeShape.List.Count; i++)
                {
                    mergeShape.List.ToArray()[i].Color = col;
                    temp++;
                }
                if (temp == 0)
                    Console.WriteLine(" No data!");
                return;
            }
        }
        public override double Area()
        {
            double result = 0;
            for (int i = 0; i < mergeShape.List.Count; i++)
            {
                result += mergeShape.List.ToArray()[i].Area();
            }
            return result;
        }
    }
}