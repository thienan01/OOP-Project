using project_2_CSharp.personnel;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.Customer
{
    class Customer:Person
    {
        private string email;
        private string address;

        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }

        public Customer(){ }

        public Customer(string name, string cMND, int yearOfBirth, string email, string address) : base(name, cMND, yearOfBirth)
        {
            Email = email;
            Address = address;
        }

    }
}
