using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class CEO:Person
    {
        private string department;
        private int numOfContract;

        public string Department { get => department; set => department = value; }
        public int NumOfContract { get => numOfContract; set => numOfContract = value; }

        public CEO() {}

        public CEO(string name, string cMND, int yearOfBirth, string position, decimal baseSalary, string department, int numOfContract) : base(name, cMND, yearOfBirth,baseSalary, position)
        {
            Department = department;
            NumOfContract = numOfContract;
        }

        ~CEO() { }
        public override decimal Salary()
        {
            return BaseSalary + (NumOfContract* 10000000);
        }
        public override void insert()
        {
            base.insert();
            Console.Write("Enter name: "); Name = Console.ReadLine();
            Console.Write("Enter CMND: "); CMND = Console.ReadLine();
            Console.Write("Enter year of birth: "); YearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Enter Position: "); Position = Console.ReadLine();
            Console.Write("Enter base salary: "); BaseSalary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter department: "); Department = Console.ReadLine();
            Console.Write("Enter number of contract: "); NumOfContract = int.Parse(Console.ReadLine());
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
