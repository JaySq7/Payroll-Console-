﻿using System;

public class Staff
{

	private float hourlyRate = 0;
	private int hWorked = 0;

	public float TotalPay
	{ get; protected set; }

	public float BasicPay
	{ get; private set; }
	
	public string NameOfStaff
	{ get; private set; }

	public int HoursWorked
	{
		get
		{
			return hWorked;
		}
		set
		{
			if (value > 0)
				hWorked = value;
			else
				hWorked = 0;
		}
	}
	public Staff(string name, float rate)
{
	NameOfStaff = name;
	hourlyRate = rate;
}

public virtual void CalculatePay()
{
	Console.WriteLine("Calculating Pay..");
	BasicPay = hWorked * hourlyRate;
	TotalPay = BasicPay;

}

public override string ToString()
{
	return $"\nName:" + NameOfStaff + "\nTotal Pay" + TotalPay + "\nHours Worked" + hWorked;
}


}
