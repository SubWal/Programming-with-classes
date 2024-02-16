using System;

class Program
{
    static public Journal journal;

    static void Main(string[] args)
    {
        journal = new Journal();
        Console.WriteLine("Hello Develop02 World!");
        Run();
    }

    static public string GetPrompt()
    {
        return "";
    }

    static public void Run()
    {
        bool keepGoing = true;

        while (keepGoing)
        {
            var selection = ShowMenu();

            if (selection == 1)
            {
                //Prompt user with a random prompt
                var prompt = "This was a random prompt";
                //Read in user input
                var placeholderResponse = "This was what the user typed in";

                var entry = new Entry(placeholderResponse, prompt);
                journal.AddEntry(entry);
            }
            else if (selection == 2)
            {
                //display entries
            }
            else if (selection == 5)
            {
                keepGoing = false;
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    static public void SaveToFile()
    {

    }

    static public void LoadFromFile()
    {

    }
}