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


        //Variables
        int myCount = 34;
        int anotherInt = 3;
        string myName = "Brother Lynn";


        //var
        var myLastName = "Lynn";
        var myOtherCount = 3;


        //Printing Variables
        Console.WriteLine("A Name: " + myName);
        Console.WriteLine($"A Name: {myName}");


        //ReadLine
        System.Console.WriteLine("What's your age?");
        var ageString = Console.ReadLine();


        //Converting Variables
        var age = int.Parse(ageString);


        //Conditionals
        if (age < 18)
        {
            System.Console.WriteLine("Your a minor");
            System.Console.WriteLine("Another thing");
        }
        else
        {
            System.Console.WriteLine("Your old");
        }


        //Operators
    }
}