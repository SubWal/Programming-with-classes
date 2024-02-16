using System;

class Program
{
    static int Add2(int number)
    {
        return number + 2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");


        // Functions

        // returnType FunctionName(paramType paramName1, paramType paramName2)
        // {
        //     function body
        // }


        // return int


        // void
        void PrintName(string name)
        {
            System.Console.WriteLine(name);
        }

        int answer = Add2(10);
        PrintName($"Bob is {answer}");

        // use static for functions (for now)


        // variable scope
        var i = 12;
        int y;
        {
            y = 10;
            y = i + 3;
            i = y + 4;
        }
        y = 5;

        /// Assignment: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-5.html

        /// Simple Development process

        /// 1. Capture requirements
        /// 2. Requirements to pseudo-code
        /// 3. Pseudo-code to working code
        /// 4. Test

        // Practice these steps with Prep5 Requirements

    }
}