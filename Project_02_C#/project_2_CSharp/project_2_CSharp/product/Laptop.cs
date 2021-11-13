using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.product
{
    class Laptop:Device
    {
        private String keyBoardLed;

        public string KeyBoardLed { get => keyBoardLed; set => keyBoardLed = value; }

        public Laptop(){}

        public Laptop(string brand, string name, string size, string chip, int ram, int capacity, string color, decimal price, string keyboardled) : base(brand,name, size, chip, ram, capacity, color, price)
        {
            KeyBoardLed = keyboardled;
        }

        ~Laptop() {  }

        public decimal ListedPrice()
        {
            return Price + Price * (Decimal)0.15 + 50000;
        }
        
        public override void Info()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Device: " + Name);
            Console.WriteLine("Size: " + Size + " inch");
            Console.WriteLine("Chip: " + Chip);
            Console.WriteLine("Ram: " + Ram +"GB");
            Console.WriteLine("Capacity: " + Capacity + "GB");
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Listed price: " + ListedPrice() + "VND");
            Console.WriteLine("Key board: " + KeyBoardLed);
            Console.WriteLine("-------------------------------------");
        }
    }
}
