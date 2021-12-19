package personnel;


public class Salesman extends Person
{
	private int numOfDeviceSold;
	private int numOfDayOff;
	private String position;
	private double baseSalary;

	public final int getNumOfDeviceSold()
	{
		return numOfDeviceSold;
	}
	public final void setNumOfDeviceSold(int value)
	{
		numOfDeviceSold = value;
	}
	public final int getNumOfDayOff()
	{
		return numOfDayOff;
	}
	public final void setNumOfDayOff(int value)
	{
		numOfDayOff = value;
	}
	public final String getPosition()
	{
		return position;
	}
	public final void setPosition(String value)
	{
		position = value;
	}
	public final double getBaseSalary()
	{
		return baseSalary;
	}
	public final void setBaseSalary(double value)
	{
		baseSalary = value;
	}

	public Salesman()
	{
	}

	public Salesman(String name, String cMND, int yearOfBirth, String position, double baseSalary, int numOfDeviceSold, int numOfDayOff)
	{
		super(name, cMND, yearOfBirth);
		setNumOfDeviceSold(numOfDeviceSold);
		setNumOfDayOff(numOfDayOff);
		setPosition(position);
		setBaseSalary(baseSalary);
	}

	protected void finalize() throws Throwable
	{
	}

	public final double Salary()
	{
		return getBaseSalary() + (100000 * getNumOfDeviceSold() - getNumOfDayOff() * getBaseSalary() / 30);
	}

	@Override
	public void Info()
	{
		super.Info();
		System.out.println("Name: " + getName());
		System.out.println("CMND: " + getCMND());
		System.out.println("Year of birth: " + getYearOfBirth());
		System.out.println("Position: " + getPosition());
		System.out.println("Salary: " + Salary() + " VND");
		System.out.println("Number of devices sold: " + getNumOfDeviceSold());
		System.out.println("Number of days off: " + getNumOfDayOff());
		System.out.println("-------------------------------------");
	}
}
