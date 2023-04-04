using System;

public class Buyer
{
    public List<string> _lastOrders = new List<string>();
    public List<string> _buyerCart = new List<string>();
    public string _name;
    public string _lastName;
    public string _id;
    public string _phoneNumber;
    public string _emailAddress;
    public string _address;

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
    }

    public void SetEmailAddress(string emailAddress)
    {
        _emailAddress = emailAddress;
    }


    public void SetAddress(string address)
    {
        _address = address;
    }


    public void SetId(string id)
    {
        _id = id;
    }


    //Getters   
    public string GetName()
    {
        return _name;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public string GetEmailAddress()
    {
        return _emailAddress;
    }


    public string GetAddress()
    {
        return _address;
    }


    public string GetId()
    {
        return _id;
    }


    public void ShowInfo()
    {
        Console.WriteLine("Personal Info");
        Console.WriteLine();
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Last Name: {_lastName}");
        Console.WriteLine($"Phone Number: {_phoneNumber}");
        Console.WriteLine($"Email Address: {_emailAddress}");
        Console.WriteLine($"Address: {_address}");
    }


}




