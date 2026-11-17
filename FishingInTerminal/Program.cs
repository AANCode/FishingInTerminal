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
        
        
        Boolean kjorer = true;
        while (kjorer)
        {
            printMenu();
            Console.Write("Hva skal du gjøre?: ");
            int valg = int.Parse(Console.ReadLine());
            switch (valg)
            {
                case 1:
                {
                    break;
                }    
            }
        }
        
        int tilfeldigFisk = Random.Shared.Next(fiskeArter.Count);
        string valgtFisk = fiskeArter[tilfeldigFisk];
        
        Console.WriteLine("### For å fiske Skriv: fisk ###");
        string? input = Console.ReadLine().ToLower();

        Random rnd = new Random();
        int Num = rnd.Next(1, 3);
        if (input == "fisk" && Num%2 == 0)
        {
            
            
            Console.WriteLine("#############################\n" +
                              $"Du fikk en {valgtFisk} fisk!\n" +
                              "#############################");
        }
        else
        {
            Console.WriteLine("Du fikk ingenting!");
        }
        
    }  
    public static void printMenu()
    {
        Console.WriteLine("1. fisk \n" +
                          "2. Se i sekken");
    }
}