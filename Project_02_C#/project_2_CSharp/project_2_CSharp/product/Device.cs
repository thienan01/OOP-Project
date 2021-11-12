using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp
{
     abstract class Device
    {
        private String brand;
        private String size;
        private String chip;
        private int ram;
        private int capacity;
        private String color;
        private decimal price;

        public string Brand { get => brand; set => brand = value; }
        public string Size { get => size; set => size = value; }
        public string Chip { get => chip; set => chip = value; }
        public int Ram { get => ram; set => ram = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Color { get => color; set => color = value; }
        public decimal Price { get => price; set => price = value; }

        public Device() { }

        public Device(string brand, string size, string chip, int ram, int capacity, string color, decimal price)
        {
            Brand = brand;
            Size = size;
            Chip = chip;
            Ram = ram;
            Capacity = capacity;
            Color = color;
            Price = price;
        }

        public abstract void Info();
    }
}
