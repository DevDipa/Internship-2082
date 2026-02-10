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
            Console.WriteLine("Invalid credentials:( \n Please try again.");
        }
    }

    public static void Menu()
    { 
		Console.Write("First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("\n");

        Console.WriteLine("**********************************************************************");
        Console.WriteLine("                                    MENU");
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("1) Addition");
        Console.WriteLine("2) Subtraction");
        Console.WriteLine("3) Multiplication");
        Console.WriteLine("4) Division");
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("\n");
        
        //user inputs
        Console.Write("Choice(1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        
        //switch for addressing all the options
        switch (choice)
        {
            case 1: Console.WriteLine($"Result for {num1} + {num2} is {Computation.Add(num1, num2)}.");
                break;
            
            case 2: Console.WriteLine($"Result for {num1} - {num2} is {Computation.Subtract(num1, num2)}.");
                break;
            
            case 3: Console.WriteLine($"Result for {num1} * {num2} is {Computation.Multiply(num1, num2)}.");
                break;
            
            case 4: Console.WriteLine($"Result for {num1} / {num2} is {Computation.Divide(num1, num2)}.");
                break;
            
            default: Console.WriteLine("Invalid choice:( Redirecting to the menu...");
                Console.WriteLine("\n");
                Menu();
                break;
        }
    }
} 

