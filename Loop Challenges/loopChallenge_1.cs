//  Write a program to count how many numbers 
//  between 1 and 100 are divisible by 3 with no
//  remainder. Display the count on the console.

using System;

namespace CSharpLoopChallenges
{
    public class Challenge_1
    {
        static void Main(string[] args)
        {
            byte count = 0;

            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.