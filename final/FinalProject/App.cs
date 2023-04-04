

public class App
{

    DataManger dataManager = new DataManger();

    Buyer _currentBuyerLogged;
    Store store = new Store();


    public void MainMenu()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("1) Login as customer");
        Console.WriteLine("2) Login as Market");
        Console.WriteLine();
        Console.WriteLine("3) Create account");
    }


    public void VerifyCredentialsAndRedirect(string userChoice)
    {

        if (userChoice == "1")
        {
            Console.WriteLine("WELCOME BUYER!!!");
            bool credentialsExist = LogInBuyer("buyersDB.txt", _currentBuyerLogged);
            if (credentialsExist)
            {
                BuyerMainMenu();
                string buyerOption = Console.ReadLine();

                if (buyerOption == "1") //shopping
                {
                    StartShopping();
                }

                else if (buyerOption == "2") // view last orders
                {
                    Console.Clear();
                    foreach (string order in _currentBuyerLogged._lastOrders)
                    {
                        int counter = 1;
                        Console.WriteLine($"{counter} {order}");
                        counter++;
                    }
                }

                else if (buyerOption == "3") // personal info
                {
                    _currentBuyerLogged.ShowInfo();
                    Console.WriteLine("Enter to exit");
                    Console.ReadLine();
                    BuyerMainMenu();

                }


            }
            else { MainMenu(); }
        }

        else if (userChoice == "2")
        {


            Console.WriteLine("WELCOME MARKET!!!");

            StoreMainMenu();
            string storeChoice = Console.ReadLine();
            if (storeChoice == "1") // Enlist Available articles
            {
                store.ShowItems("storeDB.txt");
                Console.WriteLine("Enter to exit");
                Console.ReadLine();

            }

            else if (storeChoice == "2") // Add articles
            {
                bool keepAddingItems = true;
                while (keepAddingItems)
                {
                    store.AddItems("storeDB.txt");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to keep adding items...? y/n");
                    string askIfContinue = Console.ReadLine();
                    if (askIfContinue == "y")
                    {
                        continue;
                    }
                    else
                    {
                        keepAddingItems = false;
                        BuyerMainMenu();
                    }
                }
            }


            else { MainMenu(); }
        }






        else if (userChoice == "3") // Create Account
        {
            Console.WriteLine("TIME TO CREATE AN ACCOUNT!!!");

            dataManager.CreateNewBuyer();

            Console.WriteLine("User Created... Wait");
            Thread.Sleep(3000);
            MainMenu();
        }
    }


    public void BuyerMainMenu()
    {
        Console.Clear();
        Console.WriteLine("What do you want to do?: ");
        Console.WriteLine("1) Start Shopping: ");
        Console.WriteLine("2) View Last Orders: ");
        Console.WriteLine("3) Personal Info: ");
    }


    //Buyer Methods


    public bool LogInBuyer(string dataBase, Buyer buyer)
    {
        int tries = 0;
        while (tries < 3)
        {

            Console.WriteLine();
            Console.WriteLine("Email: ");
            string UserEmail = Console.ReadLine();
            Console.WriteLine("Password: ");
            string UserPassword = Console.ReadLine();


            List<string> listCredentials = dataManager.FindCredentials(UserEmail, UserPassword, "buyersDB.txt");
            if (listCredentials.Count != 0)
            {
                Console.WriteLine("Credentials found...");

                //[Name, lastname, phonenumber, emailAddress, Address, id]
                buyer.SetName(listCredentials[2]);
                buyer.SetLastName(listCredentials[3]);
                buyer.SetPhoneNumber(listCredentials[4]);//
                buyer.SetAddress(listCredentials[5]);
                buyer.SetId(listCredentials[6]);
                Console.WriteLine("Redirecting to your home page...");
                Thread.Sleep(5000);
                return true;
            }

            else
            {
                Console.WriteLine("Credentials not found");
                Thread.Sleep(5000);
                tries++;
                return false;
            }
        }

        MainMenu();
        return false;



    }

    public void StartShopping()
    {

        bool shopping = true;
        while (shopping)
        {
            Console.WriteLine();
            Console.WriteLine("What do you want to buy...");
            string userProduct = Console.ReadLine();


            string dataBaseResponse = dataManager.FindProduct(userProduct);

            if (dataBaseResponse != "Product not available")
            {
                Console.WriteLine(dataBaseResponse);
                Console.WriteLine("You would like to add this item to your cart: yes/no ");
                string addproduct = Console.ReadLine();
                if (addproduct == "yes")
                {
                    _currentBuyerLogged._buyerCart.Add(userProduct);
                }

                else
                {
                    continue;
                }

            }

            Console.WriteLine("Continue Shopping? y/n: ");
            string continueShopping = Console.ReadLine();
            if (continueShopping == "n")
            {
                BuyerMainMenu();
            }
            else
            {
                continue;
            }
        }

    }

    //Store Methods
    public void StoreMainMenu()
    {
        Console.Clear();
        Console.WriteLine("What do you want to do?: ");
        Console.WriteLine("1) Enlist Availble Articles");
        Console.WriteLine("2) Add Articles");
    }
    //
    //
    //public bool LogInStore(string dataBase, Store store)
    //{
    //    int tries = 0;
    //    while (tries < 3)
    //    {
    //
    //        Console.WriteLine();
    //        Console.WriteLine("Store Id: ");
    //        string UserEmail = Console.ReadLine();
    //        Console.WriteLine("Password: ");
    //        string UserPassword = Console.ReadLine();
    //
    //        List<string> listCredentials = dataManager.FindCredentials(UserEmail, UserPassword, "buyersDB.txt");
    //        if (listCredentials.Count != 0)
    //        {
    //            Console.WriteLine("Credentials found...");
    //
    //            //[Name, lastname, phonenumber, emailAddress, Address, id]
    //            store.SetName(listCredentials[0]);
    //            store.SetPhoneNumber(listCredentials[1]);
    //            store.SetEmailAddress(listCredentials[2]);
    //            store.SetAddress(listCredentials[3]);
    //            store.SetId(listCredentials[4]);
    //            Console.WriteLine("Redirecting to your home page...");
    //            Thread.Sleep(5000);
    //            return true;
    //        }
    //
    //        else
    //        {
    //            Console.WriteLine("Credentials not found");
    //            Thread.Sleep(5000);
    //            tries++;
    //            return false;
    //        }
    //    }
    //
    //    MainMenu();
    //    return false;
    //}

}
