using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class Staff
    {
        private string name;
        private string cMND;
        private int dayOfBirth;
        private string position;
        private decimal baseSalary;

        public string Name { get => name; set => name = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public int DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public string Position { get => position; set => position = value; }
        public decimal BaseSalary { get => baseSalary; set => baseSalary = value; }

        public Staff() {}

        public Staff(string name, string cMND, int dayOfBirth, string position, decimal baseSalary)
        {
            Name = name;
            CMND = cMND;
            DayOfBirth = dayOfBirth;
            Position = position;
            BaseSalary = baseSalary;
        }

        public decimal Salary()
        {
            decimal salary = baseSalary;
            return salary;
        }

    }
}
