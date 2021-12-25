using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class Person
    {
        private string name;
        private string cMND;
        private int yearOfBirth;
        private decimal baseSalary;
        private string position;

        public string Name { get => name; set => name = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }
        public decimal BaseSalary { get => baseSalary; set => baseSalary = value; }
        public string Position { get => position; set => position = value; }

        public Person() {}

        public Person(string name, string cMND, int yearOfBirth,decimal baseSalary, string position)
        {
            Name = name;
            CMND = cMND;
            YearOfBirth = yearOfBirth;
            BaseSalary = baseSalary;
            Position = position;
        }
        public virtual void insert() {
            Console.WriteLine("Inserting...");
        }
        public virtual decimal Salary()
        {
            return 0;
        }
        public virtual void Info()
        {
            Console.WriteLine("Infomation: ");
        }
    }
}
