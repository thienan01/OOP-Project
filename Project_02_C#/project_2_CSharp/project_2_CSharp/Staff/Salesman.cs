using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class Salesman:Person
    {
        private int numOfDeviceSold;
        private int numOfDayOff;
        private string position;
        private decimal baseSalary;

        public int NumOfDeviceSold { get => numOfDeviceSold; set => numOfDeviceSold = value; }
        public int NumOfDayOff { get => numOfDayOff; set => numOfDayOff = value; }
        public string Position { get => position; set => position = value; }
        public decimal BaseSalary { get => baseSalary; set => baseSalary = value; }

        public Salesman() {}

        public Salesman(string name, string cMND, int yearOfBirth, string position, decimal baseSalary, int numOfDeviceSold, int numOfDayOff) : base(name, cMND, yearOfBirth)
        {
            NumOfDeviceSold = numOfDeviceSold;
            NumOfDayOff = numOfDayOff;
            Position = position;
            BaseSalary = baseSalary;
        }

        ~Salesman() { }

        public  decimal Salary()
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
