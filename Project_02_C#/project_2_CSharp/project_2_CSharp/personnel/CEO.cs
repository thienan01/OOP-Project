using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class CEO:Staff
    {
        private string department;
        private int numOfContract;

        public string Department { get => department; set => department = value; }
        public int NumOfContract { get => numOfContract; set => numOfContract = value; }

        public CEO() {}

        public CEO(string name, string cMND, int dayOfBirth, string position, decimal baseSalary, string department, int numOfContract) : base(name, cMND, dayOfBirth, position, baseSalary)
        {
            Department = department;
            NumOfContract = numOfContract;
        }

        ~CEO() { }
        public new decimal Salary()
        {
            return BaseSalary + (NumOfContract* 10000000);
        }
    }
}
