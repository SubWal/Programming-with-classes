using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //primitive types
        int i;
        string s;
        char c;
        float f;
        double d;
        byte b;

        // Lists - new keyword
        List<int> myInts = new List<int>();
        var moreInt = new List<int>();

        moreInt.Add(34);
        moreInt.Add(10);


        //disable ImplicitUsings


        // Add items


        // Iterate over items
        foreach (var n in moreInt)
        {
            System.Console.WriteLine($"n = {n}");
        }


        /// Assignment: Number List https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html

        // do-while loop until they enter 0

        //Prompt for number

        //convert response to int

        //add number to list

        //check if they entered 0 to exit loop

        // Keep going....
    }
}