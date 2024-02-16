using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // while loop
        int count = 0;
        while (count < 5)
        {
            System.Console.WriteLine($"count = {count}");
            // count = count + 1;
            // count += 1;
            // count++;
            ++count;
        }


        // do-while loop
        int moreCount = 0;
        do
        {
            System.Console.WriteLine($"moreCount = {moreCount++}");
        } while (moreCount < 5);

        // for loop
        for (var i = 10; i > 5; --i)
        {
            System.Console.WriteLine($"i = {i}");
        }

        // System.Console.WriteLine($"i = {i}"); //won't work


        /// Assignment: Guess My Number https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html

        // Ask for random number
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 11);

        int guess;
        do
        {
            // Ask for user guess
            System.Console.Write("Guess a number (between 1-10): ");
            guess = int.Parse(Console.ReadLine());

            if (guess < 1 || guess > 10)
            {
                break;
            }

            // Check if guess is higher
            if (guess > random)
            {
                System.Console.WriteLine("Too High");
            }

            else if (guess < random)
            { // Check if guess is lower
                System.Console.WriteLine("Too Low");
            }

            else
            { // Check if guess is match 
                System.Console.WriteLine("Correct");
            }
        } while (random != guess);

        // Keep going....
    }
}