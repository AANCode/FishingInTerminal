using System;
using System.Collections;

class Program
{
    static void Main(String[] args)
    {
        List<String> fiskeArter = new List<String>()
        {
            "Salmon",
            "Bass",
            "Tuna"
        };
        
        int tilfeldigFisk = Random.Shared.Next(fiskeArter.Count);
        string valgtFisk = fiskeArter[tilfeldigFisk];
        
        Console.WriteLine("For å starte å fiske Skriv: fisk");
        string? input = Console.ReadLine().ToLower();

        Random rnd = new Random();
        int Num = rnd.Next(1, 3);
        if (input == "fisk" && Num%2 == 0)
        {
            Console.WriteLine($"Du fikk en {valgtFisk} fisk!");
        }
        else
        {
            Console.WriteLine("Du fikk ingenting!");
        }
    }    
}