using project_2_CSharp.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp
{
    abstract class Device
    {
        private String brand;
        private string name;
        private String size;
        private String chip;
        private int ram;
        private int capacity;
        private String color;
        private decimal price;
        private string os;
        public string Brand { get => brand; set => brand = value; }
        public string Size { get => size; set => size = value; }
        public string Chip { get => chip; set => chip = value; }
        public int Ram { get => ram; set => ram = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Color { get => color; set => color = value; }
        public decimal Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public string Os { get => os; set => os = value; }

        public Device() { }

        protected Device(string brand, string name, string os, string size, string chip, int ram, int capacity, string color, decimal price)
        {
            Brand = brand;
            Size = size;
            Chip = chip;
            Ram = ram;
            Capacity = capacity;
            Color = color;
            Price = price;
            Name = name;
            Os = os;
        }
        protected Device(string brand, string name, string size, string chip, int ram, int capacity, string color, decimal price)
        {
            Brand = brand;
            Size = size;
            Chip = chip;
            Ram = ram;
            Capacity = capacity;
            Color = color;
            Price = price;
            Name = name;
        }
        public abstract void insert();
        ~Device()
        {
            System.Diagnostics.Trace.WriteLine("Deletted device!!!");
        }
        public abstract void Info();

        public static bool operator <(Device phone1, Device phone2)
        {
            int point = 0;
            if (phone1.Ram < phone2.Ram)
                point++;
            if (phone1.Capacity< phone2.Capacity)
                point++;
            if (phone1.Price > phone2.Price)
                point++;
            if (point >= 2)
                return true;  
            return false;
        }
        public static bool operator >(Device phone1, Device phone2)
        {
            int point = 0;
            if (phone1.Ram > phone2.Ram)
                point++;
            if (phone1.Capacity > phone2.Capacity)
                point++;
            if (phone1.Price < phone2.Price)
                point++;
            if (point >= 2)
                return true;
            return false;
        }
        public virtual string installApp(IAndroidCompatible app) { return ""; }
        public virtual string installApp(IAppleCompatible app) { return ""; }
    }
    }
