using System;
using System.Collections.Generic;
using System.Text;
using Project1.Graphic;
using Project1.Group;


namespace Project1.Table
{
    class Menu : Shape
    {
        private List<Shape> ListShape;
        private Combine CombineShape;
        public Menu() //constructor
        {
            this.ListShape = new List<Shape>();
            this.CombineShape = new Combine();
        }

        ~Menu() { }
        public override void Input()
        {
            int option;
            do
            {
                Console.WriteLine("\t=====================");
                Console.WriteLine("\t| Paint Application |");
                Console.WriteLine("\t=====================");
                Console.WriteLine("\t|     MAIN MENU     |");
                Console.WriteLine("________________________________________");
                Console.WriteLine("\n ");
                Console.WriteLine("\t=====================");
                Console.WriteLine("\t|1.   Line:         |");
                Console.WriteLine("\t|2.   Rectangle:    |");
                Console.WriteLine("\t|3.   Triangle:     |");
                Console.WriteLine("\t|4.   Circle:       |");
                Console.WriteLine("\t|5.   Group:        |");
                Console.WriteLine("\t|6.   Ungroup:      |");
                Console.WriteLine("\t|7.   Move:         |");
                Console.WriteLine("\t|8.   Color :       |");
                Console.WriteLine("\t|9.   Exit :        |");
                Console.WriteLine("________________________________________");

                Console.WriteLine("\n ");
                Console.Write("\tPLEASE ENTER YOUR OPTIONS: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n ");
                Console.WriteLine("________________________________________");

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\t LINE:");
                        Line line = new Line();
                        line.Input();
                        line.Output();
                        ListShape.Add(line);
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\t RECTANGLE:");
                        Shape rectangle = new Rectangle();
                        rectangle.Input();
                        rectangle.Output();
                        ListShape.Add(rectangle);
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("\t TRIANGLE:");
                        Shape triangle = new Triangle();
                        triangle.Input();
                        triangle.Output();
                        ListShape.Add(triangle);
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\t CIRCLE:");
                        Shape circle = new Circle();
                        circle.Input();
                        circle.Output();
                        ListShape.Add(circle);
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\t GROUP:\n");
                        CombineShape.Group(this.ListShape);
                        Console.WriteLine("\tGroup Done \n");
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\t UNGROUP:\n");
                        CombineShape.Ungroup();
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("\t MOVE POSITION:\n");
                        Console.WriteLine("\t | 1.SHAPE:         | ");
                        Console.WriteLine("\t | 2.GROUP:         | ");
                        Console.Write("\tPLEASE ENTER YOUR OPTIONS: ");
                        int numShape = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("________________________________________");
                        if (numShape < 1 || numShape > 2)
                        {
                            Console.WriteLine("\tPlease Re-Enter: ");
                            break;
                        }
                        int temp = 0;
                        if (numShape == 1)
                        {
                            Console.WriteLine("\t | 1.LINE:           | ");
                            Console.WriteLine("\t | 2.RECTANGLE:      | ");
                            Console.WriteLine("\t | 3.TRIANGLE:       | ");
                            Console.WriteLine("\t | 4.CIRCLE:         | ");
                            Console.Write("\tPLEASE ENTER YOUR OPTIONS: ");
                            numShape = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("________________________________________");
                            if (numShape < 1 || numShape > 4)
                            {
                                Console.WriteLine("\tPlease Re-Enter: ");
                                break;
                            }
                            for (int i = 0; i < ListShape.Count; i++)
                            {
                                if (ListShape.ToArray()[i].TypeNumOfShape == numShape)
                                {
                                    ListShape.ToArray()[i].newPos(ListShape.ToArray()[i].P1, ListShape.ToArray()[i].P2);
                                    temp++;
                                }
                            }
                            if (temp == 0)
                            {
                                Console.WriteLine("\tNo Data");
                                Console.WriteLine("________________________________________");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\tDone");
                                Console.WriteLine("________________________________________");
                                break;
                            }
                        }
                        else
                        {
                            temp = 0;
                            for (int i = 0; i < CombineShape.List.Count; i++)
                                temp++;
                            if (temp == 0)
                            {
                                Console.WriteLine("\tNo Data");
                            }
                            else
                            {
                                CombineShape.newPos();
                                Console.WriteLine("\tDone");
                            }
                        }
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("\t NEW COLOR:");
                        Console.WriteLine("\t | 1.SHAPE:         | ");
                        Console.WriteLine("\t | 2.GROUP:         | ");
                        Console.Write("\tPLEASE ENTER YOUR OPTIONS: ");
                        int k = Convert.ToInt32(Console.ReadLine());

                        Change(k);
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("\n ");
                        Console.ReadKey();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("\tPlease re-enter: ");
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
                Console.WriteLine("\t | 1.LINE:           | ");
                Console.WriteLine("\t | 2.RECTANGLE:      | ");
                Console.WriteLine("\t | 3.TRIANGLE:       | ");
                Console.WriteLine("\t | 4.CIRCLE:         | ");
                Console.Write("\tPLEASE ENTER YOUR OPTIONS: ");
                int numShape = Convert.ToInt32(Console.ReadLine());
                if (numShape < 1 || numShape > 4)
                {
                    Console.WriteLine("\tFail");
                    Console.WriteLine("________________________________________");
                    Console.WriteLine("\n");

                    return;
                }
                for (int i = 0; i < ListShape.Count; i++)
                {
                    if (ListShape.ToArray()[i].TypeNumOfShape == numShape)
                    {
                        Console.Write("\tNew color: ");
                        ListShape.ToArray()[i].Color = Console.ReadLine();
                        temp++;
                    }
                }
                if (temp == 0) Console.WriteLine("\tNo data!");
                Console.WriteLine("________________________________________");
                Console.WriteLine("\n");

            }
            else
            {
                temp = 0;
                Console.Write("\tNew color: ");
                string col = Console.ReadLine();
                for (int i = 0; i < CombineShape.List.Count; i++)
                {
                    CombineShape.List.ToArray()[i].Color = col;
                    temp++;
                }
                if (temp == 0)
                    Console.WriteLine("\tNo data!");
                Console.WriteLine("________________________________________");
                Console.WriteLine("\n");

                return;
            }
        }
        public override double AreaOfLine()
        {
            double NewArea = 0;
            for (int i = 0; i < CombineShape.List.Count; i++)
            {
                NewArea += CombineShape.List.ToArray()[i].AreaOfLine();
            }
            return NewArea;
        }
    }
}
