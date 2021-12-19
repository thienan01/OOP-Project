using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class Manager:Person
    {
        private int overTime;
        public int OverTime { get => overTime; set => overTime = value; }

        public Manager(){}

        public Manager(string name, string cMND, int yearOfBirth, string position, decimal baseSalary,int overtime) : base(name, cMND, yearOfBirth,baseSalary,position)
        {
            OverTime = overtime;
        }

        public override void insert()
        {
            base.insert();
            Console.Write("Enter name: "); Name = Console.ReadLine();
            Console.Write("Enter CMND: "); CMND = Console.ReadLine();
            Console.Write("Enter year of birth: "); YearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Enter Position: "); Position = Console.ReadLine();
            Console.Write("Enter base salary: "); BaseSalary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter number of hour OT: "); OverTime = int.Parse(Console.ReadLine());
        }
        ~Manager() { }

        public override decimal  Salary()
        {
            return BaseSalary + (OverTime * 200000);
        }
            
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("CMND: " + CMND);
            Console.WriteLine("Year of birth: " + YearOfBirth);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Salary: " + Salary() + " VND");
            Console.WriteLine("Over time: " + OverTime + " Hour");
            Console.WriteLine("-------------------------------------");
        }
    }
}
