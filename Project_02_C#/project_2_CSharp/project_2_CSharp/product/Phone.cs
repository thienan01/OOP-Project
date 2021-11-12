using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.product
{
    class Phone:Device
    {
        private String name;
        private String sim;
        
        public string Sim { get => sim; set => sim = value; }
        public string Name { get => name; set => name = value; }

        public Phone(){}

        public Phone(string brand, string name, string size, string chip, int ram, int capacity, string color, decimal price, string sim) : base(brand, size, chip, ram, capacity, color, price)
        {
            Sim = sim;
            Name = name;
        }

        ~Phone() { }

        public decimal ListedPrice()
        {
            return Price + Price * (decimal)0.1 + 200000; 
        }

        public override void Info()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Device: " + Name);
            Console.WriteLine("Size: " + Size + " inch");
            Console.WriteLine("Chip: " + Chip);
            Console.WriteLine("Ram: " + Ram + "GB");
            Console.WriteLine("Capacity: " + Capacity + "GB");
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Listed price: " +ListedPrice() +"VND" );
            Console.WriteLine("Sim: " + Sim);
            Console.WriteLine("_________________________________");
        }
    }
}
