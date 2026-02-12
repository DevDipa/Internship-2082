public class Laptop
{
    /*private string? _name { get; set; }  //? is used after data_type to mark the reference type as NULLABLE

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }*/

//BETTER
private string? _name;

//public static string? Name{ protected get; protected set; } --can't set access modifiers to both accessors at a time

public static string? Name{ get; protected set; } /*this is equivalent to the below:
                                                    get{return _name;}
                                                    set{_name = value;}
                                                    }*/ 
}

public class ClassnObj : Laptop
{
    public static void Main(string[] args)
    {
        Console.Write("Laptop's Name: ");
        string lName = Console.ReadLine();
        
        /*
          --when get and set are PUBLIC by default--
          instance of the Laptop class
          Laptop l = new Laptop();
		  l.Name = lName;
          Console.WriteLine($"Your entered laptop name is {l.Name}"); */

        Name = lName;
        Console.WriteLine($"Your entered laptop name is {Name}");
    }
}



