//  Write a program and continuously ask the 
//  user to enter a number or "ok" to exit. 
//  Calculate the sum of all the previously 
//  entered numbers and display it on the console.

using System;

namespace CSharpLoopChallenges
{
    public class Challenge_2
    {
        static void Main(string[] args)
        {
            int totalSum = 0;

            while (true)
            {
                Console.Write("Enter a number or type OK to exit program.\n");
                var userInput = Console.ReadLine();

                if (userInput != "OK")
                {
                    totalSum += Convert.ToInt32(userInput);
                    Console.WriteLine("The current total is: " + totalSum);
                    continue;
                }

                break;
            }
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.