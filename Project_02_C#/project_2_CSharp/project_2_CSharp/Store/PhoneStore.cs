using project_2_CSharp.personnel;
using project_2_CSharp.product;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public static void findDevideByName(List<Device> dList, string name)
        {
            var queryResult =
                from device in dList
                where (device.Name.Contains(name))
                select device;
            foreach (var item in queryResult)
            {
                item.Info();
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
                Console.WriteLine("---------------------------------");
                Console.WriteLine(phone1.Name + " is better than " + phone2.Name);
                Console.WriteLine("---------------------------------");
            }
            else if (phone1 < phone2)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(phone2.Name + " is better than " + phone1.Name);
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(phone2.Name + " is the same " + phone1.Name);
                Console.WriteLine("---------------------------------");
            }
        }
        public static void viewStaffList(List<Person> sList)
        {
            foreach (var item in sList)
            {
                item.Info();
            }
        }
        public static void findSalesmanHighestSalary(List<Person> sList)
        {
            Person a = null;
            foreach (var item in sList)
            {
                foreach (var item2 in sList)
                {
                    if (item.Salary() < item2.Salary())
                    {
                        a = item2;
                    }
                }
                
            }
            Console.WriteLine("***** The salesman has highest salary *****");
            a.Info();
        }
        public static void findStaffByPosAndName(List<Person> staffList, string pos, string name)
        {
            foreach (var item in staffList)
            {
                if (item.Position.Equals(pos))
                {
                    if (item.Name.Equals(name))
                    {
                        item.Info();
                    }
                }
            }
        }
        public static void insertDevice(ref List<Device> devices, string type)
        {
            if (type.Equals("Laptop"))
            {
                Device newLaptop = new Laptop();
                newLaptop.insert();
                devices.Add(newLaptop);
                Console.WriteLine("******* Insert successful *********");
            }
            if (type.Equals("Phone"))
            {
                Device newPhone = new Phone();
                newPhone.insert();
                devices.Add(newPhone);
                Console.WriteLine("******* Insert successful *********");
            }
        }
        public static void insertStaff(ref List<Person> staff, string positon)
        {
            if (positon.Equals("SaleMan"))
            {
                Person saleman = new Salesman();
                saleman.insert();
                staff.Add(saleman);
                Console.WriteLine("******* Insert successful *********");
            }
            if (positon.Equals("Manager"))
            {
                Person manager = new Manager();
                manager.insert();
                staff.Add(manager);
                Console.WriteLine("******* Insert successful *********");
            }
            if (positon.Equals("Ceo"))
            {
                Person ceo = new CEO();
                ceo.insert();
                staff.Add(ceo);
                Console.WriteLine("******* Insert successful *********");
            }
        }
    }
}
