using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Skriv: fisk");
        string? input = Console.ReadLine().ToLower();

        if (input == "fisk")
        {
            Console.WriteLine("Du har fisk!");
        }
    }    
}