using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");


        //Primitive types
        int i;
        long l;
        float f;
        double d;
        char c;
        string s;
        byte b;
        bool b2;


        //Variables
        int myCount = 4;
        string aName = "bob";


        //var
        var anotherCount = 4;

        //Printing Variables
        Console.Write("What's your age?");


        //ReadLine
        var ageString = Console.ReadLine();
        System.Console.WriteLine($"My age is {ageString}.");
        System.Console.WriteLine("My age is " + ageString + ".");


        //Converting Variables
        int age = int.Parse(ageString);


        //Conditionals
        if (age < 18)
        {
            System.Console.WriteLine("You're a minor");
            System.Console.WriteLine("Another string to print");
        }
        else
        {
            System.Console.WriteLine("You're old");
        }

        //Operators
    }
}