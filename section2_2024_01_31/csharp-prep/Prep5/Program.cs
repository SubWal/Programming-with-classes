using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");


        // Functions

        // returnType FunctionName(paramType paramName1, paramType paramName2)
        // {
        //     function body
        // }
        int Add2(int number)
        {
            return number + 2;
        }


        int more = Add2(10);


        // return int


        // void

        void PrintName(string name)
        {
            if (name.Length == 0)
            {
                return;
            }
            System.Console.WriteLine($"Name is {name}");
            return;
        }

        PrintName("Bob");



        // use static for functions (for now)


        // variable scope

        var y = 0;
        {
            var w = 10;
            w = y + 4;
            y = w + 5;
        }
        // y = w + 4; //doesn't work


        /// Assignment: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-5.html

        /// Simple Development process

        /// 1. Capture requirements
        /// 2. Requirements to pseudo-code
        /// 3. Pseudo-code to working code
        /// 4. Test

        // Practice these steps with Prep5 Requirements

    }
}