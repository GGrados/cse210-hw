using System;

public class DataManger
{


    public string _buyersDataBase = "buyersDB.txt";
    public string _storeProductsDataBase = "storeDB.txt";





    public List<string> FindCredentials(string email, string password, string dataBase)
    {
        string[] credentials = File.ReadAllLines(_buyersDataBase);  // cada linea estara divida por una coma

        foreach (string emailAndPassword in credentials)
        {
            string[] credentialParts = emailAndPassword.Split(",");

            if (credentialParts[0] == email & credentialParts[1] == password)
            {
                return credentials.ToList(); //email, password, 
            }

            else { continue; }
        }
        return new List<string>();
    }


    public string FindProduct(string desiredProduct)
    {

        string textToReturn;
        string[] products = File.ReadAllLines(_storeProductsDataBase);  // cada linea estara divida por una coma

        foreach (string product in products)
        {
            string[] productInfo = product.Split(",");

            if (productInfo[0] == desiredProduct)
            {
                return textToReturn = ($"We found your product ({desiredProduct}. There are {productInfo[1]} items available.");
            }
            else
            {
                return textToReturn = "Product not available";
            }

        }
        return "Product not available";
    }




    public void CreateNewBuyer()
    {
        Console.WriteLine("Let's create your buyer account");
        Console.WriteLine("Email: ");
        string newEmail = Console.ReadLine();
        Console.WriteLine("Password: ");
        string newPassword = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Name ");
        string newName = Console.ReadLine();
        Console.WriteLine("Last Name: ");
        string newLastName = Console.ReadLine();
        Console.WriteLine("Phone Number: ");
        string newPhoneNumber = Console.ReadLine();
        Console.WriteLine("Address: ");
        string newAddress = Console.ReadLine();
        Console.WriteLine("Saving your account... Wait");
        Thread.Sleep(3000);
        string newCredentials = newEmail + "," + newPassword + "," + newName + "," + newLastName + "," + newPhoneNumber + "," + newAddress;


        using (StreamWriter textfile = new StreamWriter(_buyersDataBase, true))
        {
            textfile.WriteLine(newCredentials);
            textfile.Flush();
        }



    }


}
