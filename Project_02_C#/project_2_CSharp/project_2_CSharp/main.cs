using project_2_CSharp.App;
using project_2_CSharp.personnel;
using project_2_CSharp.product;
using project_2_CSharp.Store;
using System;
using System.Collections.Generic;

namespace project_2_CSharp
{
    class main
    {
        static void Main(string[] args)
        {
            //Create phone data
            Device phone1 = new Phone("Samsung", "Samsung S21", "Android", "6.3", "Exenos 8880", 6, 128, "Black", 25990000, "Doul sim");
            Device phone2 = new Phone("Samsung", "Samsung Note 20", "Android", "6.7", "Exenos 8880", 8, 64, "White", 27990000, "Doul sim");
            Device phone3 = new Phone("Apple", "Iphone 13 XS MAX", "IOS", "6.5", "Apple A15", 6, 512, "Black", 35990000, "Dou sim");
            Device phone4 = new Phone("Apple", "Iphone 12 Pro MAX", "IOS", "6.3", "Apple A13", 6, 512, "Pink", 23990000, "Single sim");
            List<Device> phoneList = new List<Device>() { phone1, phone2, phone3, phone4 };
            //Create laptop data
            Device laptop1 = new Laptop("Asus", "Zenbook 14", "14", "Intel i7", 8, 512, "Blue", 22990000, "Led");
            Device laptop2 = new Laptop("Apple", "MacBook Pro M1 2020", "13.3", "Apple M11", 16, 512, "Grey", 42990000, "Led");
            Device laptop3 = new Laptop("Dell", "Dell Gaming G3", "15.6", "Intel i7", 16, 512, "Black", 29990000, "Led");
            Device laptop4 = new Laptop("Asus", "Asus ROG G3", "15.6", "Intel i7", 16, 512, "Black", 20990000, "No led");
            List<Device> laptopList = new List<Device>() { laptop1, laptop2, laptop3 };
            List<Device> allDevice = new List<Device>() { phone1, phone2, phone3, phone4, laptop1, laptop2, laptop3, laptop4 };

            //Create salesman data
            Person salesman1 = new Salesman("Le Van A", "243534567", 1999, "Sale", 8000000, 10, 0);
            Person salesman2 = new Salesman("Le Van B", "678234456", 1997, "Sale", 8000000, 20, 3);
            Person salesman3 = new Salesman("Le Van C", "313546678", 2000, "Sale", 8000000, 4, 1);
            Person salesman4 = new Salesman("Le Van D", "987678479", 1990, "Sale", 8000000, 8, 2);
            List<Person> salesmanList = new List<Person> { salesman1, salesman2, salesman3, salesman4 };

            //Create manager data
            Person manager1 = new Manager("Nguyen Thi E", "234567426", 1990, "Manager", 12000000, 24);
            Person manager2 = new Manager("Nguyen Thi F", "274468142", 1989, "Manager", 12000000, 12);
            List<Person> managerList = new List<Person> { manager1, manager2 };

            //Create CEO data
            Person ceo1 = new CEO("Tran Van Q", "153475253", 1970, "CEO", 40000000, "Marketing", 2);
            Person ceo2 = new CEO("Tran Van X", "634543364", 1972, "CEO", 40000000, "Sale", 4);
            List<Person> ceoList = new List<Person> { ceo1, ceo2 };
            List<Person> allStaff = new List<Person>() { salesman1, salesman2, salesman3, salesman4, manager1, manager2, ceo1, ceo2 };
            //Create App data
            FacebookApp facebook = new FacebookApp();
            YoutubeApp youtube = new YoutubeApp();

        home:
            Console.Clear();
            Console.WriteLine("    ----------");
            Console.WriteLine("   | " + PhoneStore.storeName + " |");
            Console.WriteLine("    ----------");
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("1. Device management\n" +
                "2. Staff management\n");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        goto devideManagement;

                    case 2:
                        goto staffmanagement;

                }
            }
        devideManagement:
            Console.Clear();
            while (true)
            {
                Console.WriteLine("1. View phone list\n" +
                "2. View laptop list\n" +
                "3. Search by name\n" +
                "4. Sort device by price\n" +
                "5. Compare to phones\n" +
                "6. Install application for phone\n" +
                "7. Insert a phone\n" +
                "8. Insert a laptop\n" +
                "99.Clear screen\n" +
                "0. Go to home");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        PhoneStore.viewDeviceList(phoneList);
                        break;
                    case 2:
                        PhoneStore.viewDeviceList(laptopList);
                        break;
                    case 3:
                        Console.Write("Enter device's name: "); string name = Console.ReadLine();
                        PhoneStore.findDevideByName(phoneList, name);
                        PhoneStore.findDevideByName(laptopList, name);
                        break;
                    case 4:
                        Console.WriteLine("After sort:");
                        PhoneStore.sortByPrice(allDevice);
                        break;
                    case 5:
                        goto comparePhone;
                    case 6:
                        goto installApp;
                    case 7:
                        PhoneStore.insertDevice(ref phoneList, "Phone");
                        break;
                    case 8:
                        PhoneStore.insertDevice(ref laptopList, "Laptop");
                        break;
                    case 0:
                        goto home;
                    case 99:
                        Console.Clear();
                        break;

                }
            }
        staffmanagement:
            Console.Clear();
            while (true)
            {
                Console.WriteLine("1. View salesman list\n" +
                "2. View manager list\n" +
                "3. View CEO list\n" +
                "4. Find the salesman has highest salary\n" +
                "5. Find staff by position and name\n" +
                "6. Insert staff\n" +
                "0. Go to home");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        PhoneStore.viewStaffList(salesmanList);
                        break;
                    case 2:
                        PhoneStore.viewStaffList(managerList);
                        break;
                    case 3:
                        PhoneStore.viewStaffList(ceoList);
                        break;
                    case 4:
                        PhoneStore.findSalesmanHighestSalary(salesmanList);
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Enter position off staff: "); string pos = Console.ReadLine();
                        Console.Write("Enter name off staff: "); string name2 = Console.ReadLine();
                        PhoneStore.findStaffByPosAndName(allStaff, pos, name2);
                        break;
                    case 6:
                        goto insertStaff;
                    case 0:
                        goto home;

                }
            }
        comparePhone:
            Console.Clear();
            while (true)
            {
                Console.WriteLine("\nComparison criteria: Base on Ram, Capacity, Price. \nWhich phone has 2/3 better characteristics will be better\n");
                Console.WriteLine("1. " + phone1.Name + ", Ram: " + phone1.Ram + ", Capacity: " + phone1.Capacity + ", Price: " + phone1.Price);
                Console.WriteLine("2. " + phone2.Name + ", Ram: " + phone2.Ram + ", Capacity: " + phone2.Capacity + ", Price: " + phone2.Price);
                Console.WriteLine("3. " + phone3.Name + ", Ram: " + phone3.Ram + ", Capacity: " + phone3.Capacity + ", Price: " + phone3.Price);
                Console.WriteLine("4. " + phone4.Name + ", Ram: " + phone4.Ram + ", Capacity: " + phone4.Capacity + ", Price: " + phone4.Price);
                Console.WriteLine("0. Back to home");
                Device firstPhone = null;
                Device secondPhone = null;
                Console.Write("Choose the first phone: "); int i = int.Parse(Console.ReadLine());
                if (i == 0) goto home;
                if (i == 1) firstPhone = phone1;
                if (i == 2) firstPhone = phone2;
                if (i == 3) firstPhone = phone3;
                if (i == 4) firstPhone = phone4;

                Console.Write("Choose the second phone: "); int j = int.Parse(Console.ReadLine());
                if (j == 1) secondPhone = phone1;
                if (j == 2) secondPhone = phone2;
                if (j == 3) secondPhone = phone3;
                if (j == 4) secondPhone = phone4;
                PhoneStore.comparePhone(firstPhone, secondPhone);
            }
        installApp:
            Console.Clear();
            while (true)
            {
                Console.WriteLine("** Choose the phone which you want to install app **");
                foreach (var item in phoneList)
                {
                    Console.WriteLine(item.Name + "; " + item.Os);
                }
                Console.WriteLine("0. Back");
                int phoneNum = int.Parse(Console.ReadLine());
                if (phoneNum == 0) goto devideManagement;
                Console.Clear();
                Console.WriteLine("** Choose app **");
                Console.WriteLine("1. " + facebook);
                Console.WriteLine("2. " + youtube);
                int appNum = int.Parse(Console.ReadLine());
                switch (phoneNum)
                {
                    case 1:
                        switch (appNum)
                        {
                            case 1:
                                Console.WriteLine(phone1.installApp(facebook));
                                break;
                            case 2:
                                Console.WriteLine(phone1.installApp(youtube));
                                break;
                        }
                        break;
                    case 2:
                        switch (appNum)
                        {
                            case 1:
                                Console.WriteLine(phone2.installApp(facebook));
                                break;
                            case 2:
                                Console.WriteLine(phone2.installApp(youtube));
                                break;
                        }
                        break;
                    case 3:
                        switch (appNum)
                        {
                            case 1:
                                Console.WriteLine(phone3.installApp(facebook));
                                break;
                            case 2:
                                Console.WriteLine(phone3.installApp(youtube));
                                break;
                        }
                        break;
                    case 4:
                        switch (appNum)
                        {
                            case 1:
                                Console.WriteLine(phone4.installApp(facebook));
                                break;
                            case 2:
                                Console.WriteLine(phone4.installApp(youtube));
                                break;
                        }
                        break;
                }
            }
        insertStaff:
            Console.Clear();
            Console.WriteLine("1. Insert Saleman\n" +
                "2. Insert Manager\n" +
                "3. Insert Ceo\n" +
                "0. Back to home\n");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PhoneStore.insertStaff(ref salesmanList, "SaleMan");
                    break;
                case 2:
                    PhoneStore.insertStaff(ref managerList, "Manager");
                    break;
                case 3:
                    PhoneStore.insertStaff(ref ceoList, "Ceo");
                    break;
            }
            goto staffmanagement;
        }

    }
}
