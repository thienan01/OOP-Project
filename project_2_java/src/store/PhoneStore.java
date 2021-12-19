package store;

import java.util.ArrayList;
import java.util.Collections;

import personnel.Person;
import product.Device;

public final class PhoneStore
{
	public static String storeName = "AT store";
	public static void viewDeviceList(ArrayList<Device> dList)
	{
		for (var item : dList)
		{
			item.Info();
		}
	}
	public static void viewStaffList(ArrayList<Person> sList)
	{
		for (var item : sList)
		{
			item.Info();
		}
	}
	public static void findDevideByName(ArrayList<Device> dList, String name)
	{
		for (var item : dList)
		{
			if (item.getName().contains(name))
			{
				item.Info();
			}
		}
	}
	public static void sortByPrice(ArrayList<Device> dList)
	{
				Collections.sort(dList, (p1, p2) ->
				{
						if (p1.getPrice() == p2.getPrice())
						{
							return 0;
						}
						if (p1.getPrice() < p2.getPrice())
						{
							return -1;
						}
						return 1;
				});
				for (var item : dList)
				{
					item.Info();
				}
	}

	public static void comparePhone(Device phone1, Device phone2)
	{
		if (Device.opGreaterThan(phone1, phone2))
		{
			System.out.println("---------------------------------");
			System.out.println(phone1.getName() + " is better than " + phone2.getName());
			System.out.println("---------------------------------");
		}
		else if (Device.opLessThan(phone1, phone2))
		{
			System.out.println("---------------------------------");
			System.out.println(phone2.getName() + " is better than " + phone1.getName());
			System.out.println("---------------------------------");
		}
		else
		{
			System.out.println("---------------------------------");
			System.out.println(phone2.getName() + " is the same " + phone1.getName());
			System.out.println("---------------------------------");
		}
	}
}
