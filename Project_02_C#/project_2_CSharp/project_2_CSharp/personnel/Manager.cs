using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class Manager:Staff
    {
        private int overTime;

        public int OverTime { get => overTime; set => overTime = value; }

        public Manager(){}

        public Manager(string name, string cMND, int dayOfBirth, string position, decimal baseSalary,int overtime) : base(name, cMND, dayOfBirth, position, baseSalary)
        {
            OverTime = overtime;
        }

        ~Manager() { }

        public new decimal  Salary()
        {
            return BaseSalary + (OverTime * 200000);
        }
    }
}
