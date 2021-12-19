package personnel;

public class Person
{
	private String name;
	private String cMND;
	private int yearOfBirth;

	public final String getName()
	{
		return name;
	}
	public final void setName(String value)
	{
		name = value;
	}
	public final String getCMND()
	{
		return cMND;
	}
	public final void setCMND(String value)
	{
		cMND = value;
	}
	public final int getYearOfBirth()
	{
		return yearOfBirth;
	}
	public final void setYearOfBirth(int value)
	{
		yearOfBirth = value;
	}

	public Person()
	{
	}

	public Person(String name, String cMND, int yearOfBirth)
	{
		setName(name);
		setCMND(cMND);
		setYearOfBirth(yearOfBirth);
	}
	public void Info()
	{
		System.out.println("Infomation: ");
	}
}
