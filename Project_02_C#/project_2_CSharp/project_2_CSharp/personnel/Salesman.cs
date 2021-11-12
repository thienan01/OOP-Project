using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.personnel
{
    class Salesman:Staff
    {
        private int numOfDeviceSold;
        private int numOfDayOff;

        public int NumOfDeviceSold { get => numOfDeviceSold; set => numOfDeviceSold = value; }
        public int NumOfDayOff { get => numOfDayOff; set => numOfDayOff = value; }

        public Salesman() {}

        public Salesman(string name, string cMND, int dayOfBirth, string position, decimal baseSalary, int numOfDeviceSold, int numOfDayOff) : base(name, cMND, dayOfBirth, position, baseSalary)
        {
            NumOfDeviceSold = numOfDeviceSold;
            NumOfDayOff = NumOfDayOff;
        }

        ~Salesman() { }

        public new decimal Salary()
        {
            return BaseSalary + 100000 * NumOfDeviceSold - NumOfDayOff * (BaseSalary / 30);
        }
    }
}
