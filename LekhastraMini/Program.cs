class Product
{
    //hiding internal details: ENCAPSULATION
    private int _id;
    private string _name;

    private float _price;
    
    //setting properties for each private field
    public static int Id { get; protected set; }
    
    public static string Name { get; protected set; }
    
    public static float Price { get; protected set; }
    
    //setting method for display
    public static void Display()
    {
        Console.WriteLine($"ID: {Id} | Name: {Name} | Price: {Price}");
        Console.WriteLine("**************************************************************************************");
    }
}

class LekhastraMini : Product //INHERITANCE
{
    public static void Main(string[] args)
    {
        //using loop
        Console.Write("How many products are there? - ");
        int num = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        do
        {
            Console.Write("Product ID: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Product Name: ");
            Name = Console.ReadLine();

            Console.Write("Product Price: ");
            Price = Convert.ToSingle(Console.ReadLine());
            
            //displaying
            Console.WriteLine("*********************************PRODUCT DETAILS**************************************");
            Display();
            Console.WriteLine();
            i++;
        } while (i <= num);
        
    }
}
