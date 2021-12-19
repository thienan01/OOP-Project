package product;

import app.IAndroidCompatible;
import app.IAppleCompatible;

public abstract class Device {
	private String brand;
	private String name;
	private String size;
	private String chip;
	private int ram;
	protected int capacity;
	private String color;
	private double price;
	private String os;
	public final String getBrand()
	{
		return brand;
	}
	public final void setBrand(String value)
	{
		brand = value;
	}
	public final String getSize()
	{
		return size;
	}
	public final void setSize(String value)
	{
		size = value;
	}
	public final String getChip()
	{
		return chip;
	}
	public final void setChip(String value)
	{
		chip = value;
	}
	public final int getRam()
	{
		return ram;
	}
	public final void setRam(int value)
	{
		ram = value;
	}
	public final int getCapacity()
	{
		return capacity;
	}
	public final void setCapacity(int value)
	{
		capacity = value;
	}
	public final String getColor()
	{
		return color;
	}
	public final void setColor(String value)
	{
		color = value;
	}
	public final double getPrice()
	{
		return price;
	}
	public final void setPrice(double value)
	{
		price = value;
	}
	public final String getName()
	{
		return name;
	}
	public final void setName(String value)
	{
		name = value;
	}
	public final String getOs()
	{
		return os;
	}
	public final void setOs(String value)
	{
		os = value;
	}

	public Device()
	{
	}
	protected Device(String brand, String name, String os, String size, String chip, int ram, int capacity, String color, double price)
	{
		setBrand(brand);
		setSize(size);
		setChip(chip);
		setRam(ram);
		setCapacity(capacity);
		setColor(color);
		setPrice(price);
		setName(name);
		setOs(os);
	}
	protected Device(String brand, String name, String size, String chip, int ram, int capacity, String color, double price)
	{
		setBrand(brand);
		setSize(size);
		setChip(chip);
		setRam(ram);
		setCapacity(capacity);
		setColor(color);
		setPrice(price);
		setName(name);
	}
	public abstract void Info();

	public static boolean opLessThan(Device phone1, Device phone2)
	{
		int point = 0;
		if (phone1.getRam() < phone2.getRam())
		{
			point++;
		}
		if (phone1.getCapacity() < phone2.getCapacity())
		{
			point++;
		}
		if (phone1.getPrice() > phone2.getPrice())
		{
			point++;
		}
		if (point >= 2)
		{
			return true;
		}
		return false;
	}
	public static boolean opGreaterThan(Device phone1, Device phone2)
	{
		int point = 0;
		if (phone1.getRam() > phone2.getRam())
		{
			point++;
		}
		if (phone1.getCapacity() > phone2.getCapacity())
		{
			point++;
		}
		if (phone1.getPrice() < phone2.getPrice())
		{
			point++;
		}
		if (point >= 2)
		{
			return true;
		}
		return false;
	}
	public String installApp(IAndroidCompatible app)
	{
		return "";
	}
	public String installApp(IAppleCompatible app)
	{
		return "";
	}

}
