using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class Salesman:Person
    {
        private int numOfDeviceSold;
        private int numOfDayOff;


        public int NumOfDeviceSold { get => numOfDeviceSold; set => numOfDeviceSold = value; }
        public int NumOfDayOff { get => numOfDayOff; set => numOfDayOff = value; }

        public Salesman() {}

        public Salesman(string name, string cMND, int yearOfBirth, string position, decimal baseSalary, int numOfDeviceSold, int numOfDayOff) : base(name, cMND, yearOfBirth,baseSalary,position)
        {
            NumOfDeviceSold = numOfDeviceSold;
            NumOfDayOff = numOfDayOff;
        }

        public override void insert()
        {
            base.insert();
            Console.Write("Enter name: "); Name = Console.ReadLine();
            Console.Write("Enter CMND: "); CMND = Console.ReadLine();
            Console.Write("Enter year of birth: "); YearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Enter Position: "); Position = Console.ReadLine();
            Console.Write("Enter base salary: "); BaseSalary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter number of device sold: "); NumOfDeviceSold = int.Parse(Console.ReadLine());
            Console.Write("Enter number of days off: "); NumOfDayOff = int.Parse(Console.ReadLine());
        }
        ~Salesman() { }

        public  override decimal Salary()
        {
            return BaseSalary + 100000 * NumOfDeviceSold - NumOfDayOff * (BaseSalary / 30);
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("CMND: " + CMND);
            Console.WriteLine("Year of birth: " + YearOfBirth);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Salary: " + Salary().ToString("0.##") + " VND");
            Console.WriteLine("Number of devices sold: " + NumOfDeviceSold);
            Console.WriteLine("Number of days off: " + NumOfDayOff);
            Console.WriteLine("-------------------------------------");
        }
    }
}
