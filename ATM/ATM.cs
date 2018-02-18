﻿using System;

class CreateAccount
{
    string firstName, lastName, dateOfBirth, phoneNO, fathersName, mothersName;
    double initialBalance; int pinNo = 100, accountNo = 1234, age; DateTime yearOfBirth;

    protected static List<CreateAccount> data = new List<CreateAccount>();

    protected string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception();
            else firstName = value;
        }
    }
    protected string LastName
    {
        get { return this.lastName; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception();
            else lastName = value;
        }
    }
    protected string DateOfBirth
    {
        get { return this.dateOfBirth; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception();
            else dateOfBirth = value;
        }
    }
    protected string PhoneNo
    {
        get { return this.phoneNO; }
        set
        {
            if ((string.IsNullOrEmpty(value)) || value.Length != 10)
                throw new Exception();
            else
                phoneNO = value;
        }
    }
    protected string FathersName
    {
        get { return this.fathersName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception();
            else
                fathersName = value;
        }
    }
    protected string MothersName
    {
        get { return this.mothersName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception();
            else
                mothersName = value;
        }
    }
    protected double InititailBalance
    {
        get { return this.initialBalance; }
        set
        {
            if (double.IsNaN(value))
                throw new Exception();

            else
                initialBalance = value;
        }
    }
    protected int PinNo
    {
        get { return this.pinNo; }
    }
    protected int AccountNo
    {
        get { return this.accountNo; }
    }
    public void GenerateAccount()
    {
        // code for asking user for their details.
        data.Add(this);
    }
}


class ATM : CreateAccount
{
    public void Deposit()
    {
        Console.WriteLine("Enter your account number");
        int accountNo = int.Parse(Console.ReadLine());

        if (accountNo == AccountNo)
        {
            Console.WriteLine("Enter your amount you wish to deposit");
            int amount = int.Parse(Console.ReadLine());
            InititailBalance += amount;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Create Account");
            Console.WriteLine("2.ATM");
            Console.Write("Please enter your selections: ");
            int select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1:
                    CreateAccount account = new CreateAccount();
                    account.GenerateAccount();
                    break;

                case 2:
                    ATM atm = new ATM();
                    atm.Deposit();
                    break;

            }
        }
    }
}

public class Class1
{
	public Class1()
	{
	}
}
