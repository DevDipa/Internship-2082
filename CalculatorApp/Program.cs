namespace Internship.CalculatorApp;

public class CalculatorApp
{
    public static void Main(string[] args)
    { 
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("                       Welcome to My Calculator App");
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("\n");
        Console.WriteLine("Required Credentials:");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        //basic authentication
        if (username.Equals("Dipaak") && password.Equals("Dipaak@77"))
        {
            Console.WriteLine("Logged in successfully:) \n You may proceed further...");
            Menu();
        }
        else
        {
            Console.WriteLine("Invalid Credentials:( \n Please try again.");
        }
    }

    public static void Menu()
    {
        
    }
} 
