using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class Manager:Person
    {
        private int overTime;
        private string position;
        private decimal baseSalary;


        public int OverTime { get => overTime; set => overTime = value; }
        public string Position { get => position; set => position = value; }
        public decimal BaseSalary { get => baseSalary; set => baseSalary = value; }

        public Manager(){}

        public Manager(string name, string cMND, int yearOfBirth, string position, decimal baseSalary,int overtime) : base(name, cMND, yearOfBirth)
        {
            OverTime = overtime;
            Position = position;
            BaseSalary = baseSalary;
        }

        ~Manager() { }

        public  decimal  Salary()
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
