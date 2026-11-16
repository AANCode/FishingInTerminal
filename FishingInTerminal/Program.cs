using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Skriv: fisk");
        string? input = Console.ReadLine().ToLower();

        Random rnd = new Random();
        int Num = rnd.Next(1, 3);
        if (input == "fisk" && Num%2 == 0)
        {
            Console.WriteLine("Du har fisk!");
        }
        else
        {
            Console.WriteLine("Du fikk ingenting!");
        }
    }    
}