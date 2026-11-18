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
                    Boolean fisk = true;
                    while (fisk)
                    {
                        Random rnd = new Random();
                        int tilfeldig = rnd.Next(fiskeArter.Count);
                        string valgtFisk = fiskeArter[tilfeldig];
        
                        Console.WriteLine("### For å fiske Skriv: fisk ###");
                        string? input = Console.ReadLine().ToLower();
                    
                        int Num = rnd.Next(1, 3);
                        if (input == "fisk" && Num%2 == 0)
                        {
            
            
                            Console.WriteLine("#############################\n" +
                                              $"Du fikk en {valgtFisk}!\n" +
                                              "#############################");
                        }
                        else
                        {
                            Console.WriteLine("Du fikk ingenting!");
                        }
                    }
                    break;
                }
                case 2:
                {
                    break;
                }
                case 3:
                {
                    kjorer = false;
                    break;
                }
            }
        }
        
    }  
    public static void printMenu()
    {
        Console.WriteLine("1. fisk \n" +
                          "2. Se i sekken \n" +
                          "3. Avslutt");
    }
}