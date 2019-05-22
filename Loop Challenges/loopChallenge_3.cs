//  Write a program and ask the user to enter 
//  a number.Compute the factorial of the number 
//  and print it on the console. For example, if 
//  the user enters 5, the program should calculate 
//  5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

using System;

namespace CSharpLoopChallenges
{
    public class Challenge_3
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a number from 1 to 10. Your number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = number;

            for (var i = number - 1; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of {0} is {1}!", number, factorial);
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.