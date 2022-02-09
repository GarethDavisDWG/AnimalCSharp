namespace AnimalExampleCSharp;

public class program
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Bat myBat = new Bat();
        Console.WriteLine(myBat.ToString());
        Console.WriteLine(myBat.Poo());
        myBat.Flight();
        Console.WriteLine(myBat.Age);
    }

}
