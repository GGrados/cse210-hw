using System;

class Program
{
    static void Main(string[] args)
    {
        App app = new App();

        app.MainMenu();
        string userChoice = Console.ReadLine();
        app.VerifyCredentialsAndRedirect(userChoice);


    }


}