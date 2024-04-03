
using System.Collections;
using System.Diagnostics;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness App");
            string menu = @"
            Menu:
                1. Breathing activity
                2. Reflection activity
                3. Listing Activity
                4. Quit
            Choose from the menu: ";
            Console.Write(menu);
            string option = Console.ReadLine();
            while (option != "4")
                {
                    switch (option)
                    {
                        case "1":
                            BreathingActivity breathing = new BreathingActivity();
                            breathing.Run();
                            break;
                        
                        case "2":
                            ReflectionActivity reflection = new ReflectionActivity();
                            reflection.Run();
                            break;
                        
                        case "3":
                            ListingActivity listing = new ListingActivity();
                            listing.Run();
                            break;
                        
                        default:
                            Activity defaultAct = new Activity();
                            Console.WriteLine("Invalid input. Enter a number ranging from 1 to 4");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;

                            
                    }   

                Console.Write(menu);
                option = Console.ReadLine();

                }
            Console.Write("See you... ");
    }
}