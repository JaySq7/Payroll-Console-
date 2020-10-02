using System;

public class Staff
{

	private float hourlyRate = 0;
	private int hWorked = 0;

	public float TotalPay
	{ Get; protected Set; }

	public float BasicPay
	{ Get; private Set; }
	
	public string NameOfStaff
	{ Get; private Set; }

	public double HoursWorked
{
	Get
	{
		return hWorked;
	}
	set
	{
		if (value > 0)
			hWorked = value;
		else
			hworked = 0;
	}
	public Staff(String Name, float Rate)
{
	NameOfStaff = Name;
	hourlyRate = Rate;
}

public virtual void CalculatePay()
{
	Console.WriteLine("Calculating Pay..");
	BasicPay = hWorked * hourlyRate;
	TotalPay = BasicPay;

}

public override string ToString()
{
	retrun "\nName:" + NameOfStaff + "\nTotal Pay" + TotalPay + "\nHours Worked" + hWorked;
}


}
