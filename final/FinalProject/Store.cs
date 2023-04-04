using System;


public class Store
{

    public string _name;
    public string _id;
    public string _phoneNumber;
    public string _emailAddress;
    public string _address;

    public List<string> _availableItems = new List<string>();




    public void CheckInventory()
    {
    }


    public void AddItems(string dataBase)
    {
        Console.WriteLine("What item you would like to add: ");
        string newItem = Console.ReadLine();
        Console.WriteLine("How many items of this product do you have available?: ");
        string quantity = Console.ReadLine();
        string itemInfo = newItem + "," + quantity;
        _availableItems.Add(itemInfo);

        using (StreamWriter textfile = new StreamWriter(dataBase, true))
        {
            textfile.WriteLine(itemInfo);
            textfile.Flush();
        }
    }
    public void ShowItems(string dataBase)
    {

        string[] lines = File.ReadAllLines(dataBase);
        foreach (string line in lines)
        {
            int counter = 1;
            Console.WriteLine($"{line} {counter}");
            counter++;


        }

    }





    //Setters

    public void SetName(string name)
    {
        _name = name;
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

}