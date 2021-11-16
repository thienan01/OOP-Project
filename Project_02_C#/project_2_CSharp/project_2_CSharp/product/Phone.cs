using project_2_CSharp.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.product
{
    class Phone:Device
    {

        private String sim;
        public string Sim { get => sim; set => sim = value; }

        public Phone(){}

        public Phone(string brand, string name, string os, string size, string chip, int ram, int capacity, string color, decimal price, string sim) : base(brand,name, os, size, chip, ram, capacity, color, price)
        {
            Sim = sim;

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
            Console.WriteLine("OS: " + Os);
            Console.WriteLine("Size: " + Size + " inch");
            Console.WriteLine("Chip: " + Chip);
            Console.WriteLine("Ram: " + Ram + "GB");
            Console.WriteLine("Capacity: " + Capacity + "GB");
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Listed price: " +ListedPrice() +"VND" );
            Console.WriteLine("Sim: " + Sim);
            Console.WriteLine("-------------------------------------");
        }
        public override string installApp(IAndroidCompatible app)
        {
            if (app.check(Os))
            {
                return app.downloading();
            }
            else
            {
                return "App is not compatible with phone";
            }
            
        }
        public override string installApp(IAppleCompatible app)
        {
            if (app.check(Os))
            {
                return app.downloading();
            }
            else
            {
                return "App is not compatible with phone";
            }

        }
    }
}
