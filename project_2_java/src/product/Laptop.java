package product;


import app.IAndroidCompatible;
import app.IAppleCompatible;

public class Laptop extends Device
{

	private String sim;
	public final String getSim()
	{
		return sim;
	}
	public final void setSim(String value)
	{
		sim = value;
	}

	public Laptop()
	{
	}

	public Laptop(String brand, String name, String os, String size, String chip, int ram, int capacity, String color, double price, String sim)
	{
		super(brand,name, os, size, chip, ram, capacity, color, price);
		setSim(sim);

	}

	protected void finalize() throws Throwable
	{
	}

	public final double ListedPrice()
	{
		return getPrice() + (getPrice() * (0.1) + (200000));
	}

	@Override
	public void Info()
	{
		System.out.println("Brand: " + getBrand());
		System.out.println("Device: " + getName());
		System.out.println("OS: " + getOs());
		System.out.println("Size: " + getSize() + " inch");
		System.out.println("Chip: " + getChip());
		System.out.println("Ram: " + getRam() + "GB");
		System.out.println("Capacity: " + getCapacity() + "GB");
		System.out.println("Color: " + getColor());
		System.out.println("Listed price: " + ListedPrice() + "VND");
		System.out.println("Sim: " + getSim());
		System.out.println("-------------------------------------");
	}
	@Override
	public String installApp(IAndroidCompatible app)
	{
		if (app.check(getOs()))
		{
			return app.downloading();
		}
		else
		{
			return "App is not compatible with phone";
		}

	}
	@Override
	public String installApp(IAppleCompatible app)
	{
		if (app.check(getOs()))
		{
			return app.downloading();
		}
		else
		{
			return "App is not compatible with phone";
		}

	}
}
