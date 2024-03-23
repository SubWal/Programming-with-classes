using System;

class Program
{
     static public Journal journal;

    static void Main(string[] args)
    {
        // journal = new Journal();
        Console.WriteLine("Hello Develop02 World!");
        Run();
    }

    static public string GetPrompt()
    {
        return "";
    }

    static public void Run()
    {
        journal = new Journal();
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            var selection = ShowMenu();
            
            // if (selection == 1 )
            // {
            //     Console.WriteLine("what does?");
            //     var bestThing = Console.ReadLine();
            //     Console.WriteLine("What wold you?");
            //     var weekendPlan = Console.ReadLine();
            //     Console.WriteLine("Bhate?");
            //     var habit = Console.ReadLine();

            //     journal.AddEntry(bestThing, weekendPlan, habit);
            // }

            if (selection == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                //Prompt user with a random prompt
                var prompt = "This was a random prompt";
                var thing = "";
                var emotion = "";
                var today = "";
                //Read in user input
                
                var placeholderResponse = "This was what the user typed in";
                

                var entry = new Entry(placeholderResponse, prompt, thing, emotion, today);
                journal.AddEntry(entry);
                
            }

            else if (selection == 2)
            {
               Console.Clear();
               
               journal.DisplayEntries();
            }

            else if (selection == 4)
            {
                Console.Clear();
                var lines = journal.Export();
                WriteFile(lines);
            }
            
            else if (selection == 3)
            {
                var lines = ReadFile();
                
                journal = new Journal(lines);
                
                

            }
            else if (selection == 5)
            {
                keepGoing = false;
            }

            Console.WriteLine("Invalid Selction");
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries \n 3. Load \n 4. Save \n 5. Quit");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
 
     static string[] ReadFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        var _text =  System.IO.File.ReadAllText(filename);
        string[] _entries = _text.Split("|");
        return _entries;
    }
    static public void SaveToFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.ReadAllLines(filename);
    }

    static public void LoadFromFile()
    {

    }

    static void WriteFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }
}