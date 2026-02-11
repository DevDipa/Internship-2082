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

public string? Name{
get{return _name;}
set{_name = value;}
}
}

public class ClassnObj
{
    public static void Main(string[] args)
    {
        Console.Write("Laptop's Name: ");
        string lName = Console.ReadLine();
        
        //instance of the Laptop class
        Laptop l = new Laptop();
        
        l.Name = lName;
        Console.WriteLine($"Your entered laptop name is {l.Name}");
    }
}



