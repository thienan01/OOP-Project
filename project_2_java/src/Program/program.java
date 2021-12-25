package Program;

import java.io.IOException;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

import app.FacebookApp;
import app.YoutubeApp;
import personnel.CEO;
import personnel.Manager;
import personnel.Person;
import personnel.Salesman;
import product.Device;
import product.Laptop;
import product.Phone;
import store.PhoneStore;


public class program {
		
	public static void clrscr(){
		   //Clears Screen in java
		   try {
		       if (System.getProperty("os.name").contains("Windows"))
		           new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
		       else
		           Runtime.getRuntime().exec("clear");
		   } catch (IOException | InterruptedException ex) {}
		}
	
	static Device phone1 = new Phone("Samsung", "Samsung S21", "Android", "6.3", "Exenos 8880", 6, 128, "Black", 2599, "Doul sim");
	static Device phone2 = new Phone("Samsung", "Samsung Note 20", "Android", "6.7", "Exenos 8880", 8, 64, "White", 2799, "Doul sim");
	static Device phone3 = new Phone("Apple", "Iphone 13 XS MAX", "IOS", "6.5", "Apple A15", 6, 512, "Black", 3599, "Dou sim");
	static Device phone4 = new Phone("Apple", "Iphone 12 Pro MAX", "IOS", "6.3", "Apple A13", 6, 512, "Pink", 2399, "Single sim");
	static ArrayList<Device> phoneList = new ArrayList<Device>(Arrays.asList(phone1, phone2, phone3, phone4));
	static Device laptop1 = new Laptop("Asus", "Zenbook 14", "14", "Intel i7", null, 8, 512, "Blue", 2299, "Led");
	static Device laptop2 = new Laptop("Apple", "MacBook Pro M1 2020", "13.3", "Apple M11", null, 16, 512, "Grey", 4299, "Led");
	static Device laptop3 = new Laptop("Dell", "Dell Gaming G3", "15.6", "Intel i7", null, 16, 512, "Black", 2999, "Led");
	static Device laptop4 = new Laptop("Asus", "Asus ROG G3", "15.6", "Intel i7", null, 16, 512, "Black", 2099, "No led");
	static ArrayList<Device> laptopList = new ArrayList<Device>(Arrays.asList(laptop1, laptop2, laptop3));
	static ArrayList<Device> allDevice = new ArrayList<Device>(Arrays.asList(phone1, phone2, phone3, phone4, laptop1, laptop2, laptop3, laptop4));
	static Person salesman1 = new Salesman("Le Van A", "243534567", 1999, "Sale", 8000, 10, 0);
	static Person salesman2 = new Salesman("Le Van B", "678234456", 1997, "Sale", 8000, 20, 3);
	static Person salesman3 = new Salesman("Le Van C", "313546678", 2000, "Sale", 8000, 4, 1);
	static Person salesman4 = new Salesman("Le Van D", "987678479", 1990, "Sale", 8000, 8, 2);
	static ArrayList<Person> salesmanList = new ArrayList<Person>(Arrays.asList(salesman1, salesman2, salesman3, salesman4));

	//Create manager data
	static Person manager1 = new Manager("Nguyen Thi E", "234567426", 1990, "Manager", 12000000, 24);
	static Person manager2 = new Manager("Nguyen Thi F", "274468142", 1989, "Manager", 12000000, 12);
	static ArrayList<Person> managerList = new ArrayList<Person>(Arrays.asList(manager1, manager2));

	//Create CEO data
	static Person ceo1 = new CEO("Tran Van Q", "153475253", 1970, "CEO", 40000000, "Marketing", 2);
	static Person ceo2 = new CEO("Tran Van X", "634543364", 1972, "CEO", 40000000, "Sale", 4);
	static ArrayList<Person> ceoList = new ArrayList<Person>(Arrays.asList(ceo1, ceo2));

	//Create App data
	static FacebookApp facebook = new FacebookApp();
	static YoutubeApp youtube = new YoutubeApp();

	public final static void home()
	{
		System.out.println("    ----------");
		System.out.println("   | " + PhoneStore.storeName + " |");
		System.out.println("    ----------");
		
			System.out.println("1. Device management\n" + "2. Staff management\n");
			int k = Integer.parseInt(new Scanner(System.in).nextLine());
			switch (k)
			{
				case 1:
					devideManagement();

				case 2:
					staffmanagement();
			}

		
	}
	
	private static void staffmanagement() {
		// TODO Auto-generated method stub
		System.out.println("1. View salesman list\n" + "2. View manager list\n" + "3. View CEO list\n" + "0. Go to home");
		int k = Integer.parseInt(new Scanner(System.in).nextLine());
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
			case 0:
				home();

		}
		
	}

	private static void devideManagement() {
		// TODO Auto-generated method stub
		System.out.println("1. View phone list\n" + "2. View laptop list\n" + "3. Search by name\n" + "4. Sort device by price\n" + "5. Compare to phones\n" + "6. Install application for phone\n" + "99.Clear screen\n" + "0. Go to home");
		int k = Integer.parseInt(new Scanner(System.in).nextLine());
		switch (k)
		{
			case 1:
				PhoneStore.viewDeviceList(phoneList);
				break;
			case 2:
				PhoneStore.viewDeviceList(laptopList);
				break;
			case 3:
				System.out.print("Enter device's name: ");
				String name = new Scanner(System.in).nextLine();
				PhoneStore.findDevideByName(phoneList, name);
				PhoneStore.findDevideByName(laptopList, name);
				break;
			case 4:
				System.out.println("After sort:");
				PhoneStore.sortByPrice(allDevice);
				break;
			case 5:
				comparePhone();
			case 6:
				installApp();
			case 0:
				home();
		}
		
	}
	private static void installApp() {
		// TODO Auto-generated method stub
		System.out.println("** Choose the phone which you want to install app **");
		for (var item : phoneList)
		{
			System.out.println(item.getName() + "; " + item.getOs());
		}
		System.out.println("0. Back");
		int phoneNum = Integer.parseInt(new Scanner(System.in).nextLine());
		if (phoneNum == 0)
		{
			devideManagement();
		}
		System.out.println("** Choose app **");
		System.out.println("1. " + facebook);
		System.out.println("2. " + youtube);
		int appNum = Integer.parseInt(new Scanner(System.in).nextLine());
		switch (phoneNum)
		{
			case 1:
				switch (appNum)
				{
					case 1:
						System.out.println(phone1.installApp(facebook));
						break;
					case 2:
						System.out.println(phone1.installApp(youtube));
						break;
				}
				break;
			case 2:
				switch (appNum)
				{
					case 1:
						System.out.println(phone2.installApp(facebook));
						break;
					case 2:
						System.out.println(phone2.installApp(youtube));
						break;
				}
				break;
			case 3:
				switch (appNum)
				{
					case 1:
						System.out.println(phone3.installApp(facebook));
						break;
					case 2:
						System.out.println(phone3.installApp(youtube));
						break;
				}
				break;
			case 4:
				switch (appNum)
				{
					case 1:
						System.out.println(phone4.installApp(facebook));
						break;
					case 2:
						System.out.println(phone4.installApp(youtube));
						break;
				}
				break;
		}
		
	}

	private static void comparePhone() {
		// TODO Auto-generated method stub
		System.out.println("\nComparison criteria: Base on Ram, Capacity, Price. \nWhich phone has 2/3 better characteristics will be better\n");
		System.out.println("1. " + phone1.getName() + ", Ram: " + phone1.getRam() + ", Capacity: " + phone1.getCapacity() + ", Price: " + phone1.getPrice());
		System.out.println("2. " + phone2.getName() + ", Ram: " + phone2.getRam() + ", Capacity: " + phone2.getCapacity() + ", Price: " + phone2.getPrice());
		System.out.println("3. " + phone3.getName() + ", Ram: " + phone3.getRam() + ", Capacity: " + phone3.getCapacity() + ", Price: " + phone3.getPrice());
		System.out.println("4. " + phone4.getName() + ", Ram: " + phone4.getRam() + ", Capacity: " + phone4.getCapacity() + ", Price: " + phone4.getPrice());
		System.out.println("0. Back to home");
		Device firstPhone = null;
		Device secondPhone = null;
		System.out.print("Choose the first phone: ");
		int i = Integer.parseInt(new Scanner(System.in).nextLine());
		if (i == 0)
		{
			home();
		}
		if (i == 1)
		{
			firstPhone = phone1;
		}
		if (i == 2)
		{
			firstPhone = phone2;
		}
		if (i == 3)
		{
			firstPhone = phone3;
		}
		if (i == 4)
		{
			firstPhone = phone4;
		}

		System.out.print("Choose the second phone: ");
		int j = Integer.parseInt(new Scanner(System.in).nextLine());
		if (j == 1)
		{
			secondPhone = phone1;
		}
		if (j == 2)
		{
			secondPhone = phone2;
		}
		if (j == 3)
		{
			secondPhone = phone3;
		}
		if (j == 4)
		{
			secondPhone = phone4;
		}
		PhoneStore.comparePhone(firstPhone, secondPhone);
		
	}
	public static void main(String[] args) {
		home();
	}

}
	


