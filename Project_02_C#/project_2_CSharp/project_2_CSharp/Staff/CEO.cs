using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class CEO:Person
    {
        private string department;
        private int numOfContract;
        private string position;
        private decimal baseSalary;

        public string Department { get => department; set => department = value; }
        public int NumOfContract { get => numOfContract; set => numOfContract = value; }
        public string Position { get => position; set => position = value; }
        public decimal BaseSalary { get => baseSalary; set => baseSalary = value; }

        public CEO() {}

        public CEO(string name, string cMND, int yearOfBirth, string position, decimal baseSalary, string department, int numOfContract) : base(name, cMND, yearOfBirth)
        {
            Department = department;
            NumOfContract = numOfContract;
            Position = position;
            BaseSalary = baseSalary;
        }

        ~CEO() { }
        public  decimal Salary()
        {
            return BaseSalary + (NumOfContract* 10000000);
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("CMND: " + CMND);
            Console.WriteLine("Year of birth: " + YearOfBirth);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Salary: " + Salary() + " VND");
            Console.WriteLine("Number of contracts: " + NumOfContract);
            Console.WriteLine("-------------------------------------");
        }
    }
}
