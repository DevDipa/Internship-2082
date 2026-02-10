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
            Console.WriteLine("\n");
            Menu();
        }
        else
        {
            Console.WriteLine("Invalid Credentials:( \n Please try again.");
        }
    }

    public static void Menu()
    {
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("                                    MENU");
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("1) Addition");
        Console.WriteLine("2) Subtraction");
        Console.WriteLine("3) Multiplication");
        Console.WriteLine("4) Division");
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("\n");
        Console.Write("Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        //Option(choice);
    }
} 

//another class for sheer arithmetic calculations
public class Calculation
{
    /*public int Option(int option)
    {
        
    }*/
}
