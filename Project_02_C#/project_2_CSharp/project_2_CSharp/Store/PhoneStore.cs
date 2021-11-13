using project_2_CSharp.personnel;
using project_2_CSharp.product;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.Store
{
    static class PhoneStore
    {
        public static string storeName = "AT store";
        public static void viewDeviceList(List<Device> dList)
        {
            foreach (var item in dList)
            {
                item.Info();
            }
        }
        public static void viewStaffList(List<Person> sList)
        {
            foreach (var item in sList)
            {
                item.Info();
            }
        }
        public static void findDevideByName(List<Device> dList, string name)
        {
            foreach (var item in dList)
            {
                if (item.Name.Contains(name))
                {
                    item.Info();
                }
            }
        }
        public static void sortByPrice(List<Device> dList)
        {
            dList.Sort(
                (p1, p2) =>
                {
                    if (p1.Price == p2.Price) return 0;
                    if (p1.Price < p2.Price) return -1;
                    return 1;
                }
                );
            foreach (var item in dList)
            {
                item.Info();
            }
        }
      
        public static void comparePhone(Device phone1, Device phone2)
        {
            if (phone1>phone2)
            {
                Console.WriteLine(phone1.Name + " is better than " + phone2.Name);
            }
            else if (phone1 < phone2)
            {
                Console.WriteLine(phone2.Name + " is better than " + phone1.Name);
            }
            else
            {
                Console.WriteLine(phone2.Name + " is the same " + phone1.Name);
            }
        }
    }
}
