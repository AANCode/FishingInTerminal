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
                    String reader = "";
                    while (reader != "ut")
                    {
                        Console.WriteLine("For å fiske skriv -> fisk \n" +
                                      "For å gå tilbake skriv -> ut: ");
                        reader = Console.ReadLine();
                        if (reader.ToLower() == "fisk" )
                        {
                            Random rnd = new Random();
                            int tilfeldig = rnd.Next(fiskeArter.Count);
                            string valgtFisk = fiskeArter[tilfeldig];
                    
                            int Num = rnd.Next(1, 3);
                            if (Num%2 == 0)
                            {
                                Console.WriteLine($"*Du fikk en {valgtFisk}!*");
                            }
                            else
                            {
                                Console.WriteLine("*Du fikk ingenting!*");
                            }
                        }
                        else if (reader.ToLower() == "ut")
                        {
                            reader = "ut";
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