package personnel;

public class CEO extends Person
{
	private String department;
	private int numOfContract;
	private String position;
	private double baseSalary;

	public final String getDepartment()
	{
		return department;
	}
	public final void setDepartment(String value)
	{
		department = value;
	}
	public final int getNumOfContract()
	{
		return numOfContract;
	}
	public final void setNumOfContract(int value)
	{
		numOfContract = value;
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

	public CEO()
	{
	}

	public CEO(String name, String cMND, int yearOfBirth, String position, double baseSalary, String department, int numOfContract)
	{
		super(name, cMND, yearOfBirth);
		setDepartment(department);
		setNumOfContract(numOfContract);
		setPosition(position);
		setBaseSalary(baseSalary);
	}

	protected void finalize() throws Throwable
	{
	}
	public final double Salary()
	{
		return getBaseSalary() + ((getNumOfContract() * 10000000));
	}

	@Override
	public void Info()
	{
		super.Info();
		System.out.println("Name: " + getName());
		System.out.println("CMND: " + getCMND());
		System.out.println("Year of birth: " + getYearOfBirth());
		System.out.println("Position: " + getPosition());
		System.out.println("Department: " + getDepartment());
		System.out.println("Salary: " + Salary() + " VND");
		System.out.println("Number of contracts: " + getNumOfContract());
		System.out.println("-------------------------------------");
	}
}
