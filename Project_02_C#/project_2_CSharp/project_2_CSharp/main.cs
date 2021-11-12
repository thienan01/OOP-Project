using project_2_CSharp.product;
using System;
using System.Collections.Generic;

namespace project_2_CSharp
{
    class main
    {
        static void Main(string[] args)
        {
            //Create phone data
            Phone S21 = new Phone("Samsung","Samsung S21","6.3","Exenos 8880", 6, 128,"Black",25990000,"doul sim");
            Phone Note20 = new Phone("Samsung", "Samsung Note 20", "6.7", "Exenos 8880", 8, 128, "White", 27990000, "doul sim");
            Phone Iphone13 = new Phone("Apple", "Iphone 13 XS MAX", "6.5", "Apple A15", 6, 512, "Black", 35990000, "dou sim");

            //Create laptop data
            Laptop Zenbook14 = new Laptop("Asus", "Zenbook 14", "14", "Intel i7", 8, 512, "Blue", 22990000, "Led");
            Laptop MacbookPro = new Laptop("Apple", "MacBook Pro M1 2020", "13.3", "Apple M11", 16, 512, "Grey", 42990000, "Led");
            Laptop DellG3 = new Laptop("Dell", "Dell Gaming G3", "15.6", "Intel i7", 16, 512, "Black", 29990000, "Led");

            List<Phone> phoneList = new List<Phone>() {S21,Note20,Iphone13};

            List<Laptop> laptopList = new List<Laptop>() { Zenbook14, MacbookPro, DellG3 };

            foreach (var item in laptopList)
            {
                item.Info();

            }



        }
    }
}
