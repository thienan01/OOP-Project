package customer;

import personnel.Person;

public class Customer extends Person
{
	private String email;
	private String address;

	public final String getEmail()
	{
		return email;
	}
	public final void setEmail(String value)
	{
		email = value;
	}
	public final String getAddress()
	{
		return address;
	}
	public final void setAddress(String value)
	{
		address = value;
	}

	public Customer()
	{
	}

	public Customer(String name, String cMND, int yearOfBirth, String email, String address)
	{
		super(name, cMND, yearOfBirth);
		setEmail(email);
		setAddress(address);
	}

}
