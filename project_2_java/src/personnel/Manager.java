package personnel;


public class Manager extends Person
{
	private int overTime;
	private String position;
	private double baseSalary;


	public final int getOverTime()
	{
		return overTime;
	}
	public final void setOverTime(int value)
	{
		overTime = value;
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

	public Manager()
	{
	}

	public Manager(String name, String cMND, int yearOfBirth, String position, double baseSalary, int overtime)
	{
		super(name, cMND, yearOfBirth);
		setOverTime(overtime);
		setPosition(position);
		setBaseSalary(baseSalary);
	}

	protected void finalize() throws Throwable
	{
	}

	public final double Salary()
	{
		return getBaseSalary() + ((getOverTime() * 200000));
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
		System.out.println("Over time: " + getOverTime() + " Hour");
		System.out.println("-------------------------------------");
	}
}
