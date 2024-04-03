using System;




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        EternalQuestProgram program = new EternalQuestProgram();

        while (true)
        {
            DisplayHeader();

            DisplayOptions();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(program);
                    break;

                case "2":
                    RecordEvent(program);
                    break;

                case "3":
                    program.DisplayGoals();
                    break;

                case "4":
                    program.DisplayScore();
                    break;

                case "5":
                    SaveGoals(program);
                    break;

                case "6":
                    LoadGoals(program);
                    break;

                case "7":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayHeader()
    {
        Console.WriteLine("********** ETERNAL QUEST **********");
        Console.WriteLine();
    }

    static void DisplayOptions()
    {
        Console.WriteLine("MENU OPTIONS:");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Display Goals");
        Console.WriteLine("4. Display Score");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Exit");
        Console.Write("Enter your choice (1-7): ");
    }

    static void CreateGoal(EternalQuestProgram program)
    {
        Console.WriteLine();
        Console.WriteLine("***** CREATE GOAL *****");
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Checklist");
        Console.WriteLine("3. Eternal");

        Console.Write("Enter your choice (1-3): ");
        string goalTypeChoice = Console.ReadLine();

        switch (goalTypeChoice)
        {
            case "1":
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter goal points: ");
                int points = int.Parse(Console.ReadLine());
                program.CreateGoal("Simple", name, points);
                break;

            case "2":
                Console.Write("Enter goal name: ");
                string checklistName = Console.ReadLine();
                Console.Write("Enter goal points: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                program.CreateGoal("Checklist", checklistName, checklistPoints, targetCount);
                break;

            case "3":
                Console.Write("Enter goal name: ");
                string eternalName = Console.ReadLine();
                Console.Write("Enter goal points: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                program.CreateGoal("Eternal", eternalName, eternalPoints);
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                break;
        }
    }

    static void RecordEvent(EternalQuestProgram program)
    {
        Console.WriteLine();
        Console.WriteLine("***** RECORD EVENT *****");
        Console.Write("Enter goal index to record event: ");
        int goalIndex = int.Parse(Console.ReadLine());
        program.RecordEvent(goalIndex);
    }

    static void SaveGoals(EternalQuestProgram program)
    {
        Console.WriteLine();
        Console.WriteLine("***** SAVE GOALS *****");
        Console.Write("Enter filename to save goals: ");
        string saveFilename = Console.ReadLine();
        program.SaveGoals(saveFilename);
    }

    static void LoadGoals(EternalQuestProgram program)
    {
        Console.WriteLine();
        Console.WriteLine("***** LOAD GOALS *****");
        Console.Write("Enter filename to load goals: ");
        string loadFilename = Console.ReadLine();
        program.LoadGoals(loadFilename);
    }
}
