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

        public string Name { get => name; set => name = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }

        public Person() {}

        public Person(string name, string cMND, int yearOfBirth)
        {
            Name = name;
            CMND = cMND;
            YearOfBirth = yearOfBirth;
        }
        public virtual void Info()
        {
            Console.WriteLine("Infomation: ");
        }
    }
}
