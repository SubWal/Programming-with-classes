using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // while loop
        int count = 5;

        while (count < 10)
            Console.WriteLine($"Count = {count++}");

        while (count < 15)
        {
            Console.WriteLine($"Count = {count}");
            count++;
        }

        // do-while loop
        int anotherCount = 0;
        do
        {
            System.Console.WriteLine($"AnotherCount = {++anotherCount}");
        } while (anotherCount < 10);

        // for loop
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine($"i = {i}");
        }

        // System.Console.WriteLine($"i = {i}");


        /// Assignment: Guess My Number https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html

        // Ask for random number
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);
        int guess = -1;
        bool isCorrect = false;

        while (!isCorrect)
        {
            // Ask for user guess
            System.Console.WriteLine("Guess a random number:");
            guess = int.Parse(Console.ReadLine());


            // Check if guess is higher
            if (guess > randomNumber)
            {
                System.Console.WriteLine("Too high");
            }

            // Check if guess is lower
            else if (guess < randomNumber)
            {
                System.Console.WriteLine("Too low");
            }

            // Check if guess is match 
            else
            {
                System.Console.WriteLine("Correct");
                isCorrect = true;
            }
        }

        // Keep going....
    }
}