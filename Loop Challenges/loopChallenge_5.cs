//  Write a program and ask the user to enter a 
//  series of numbers separated by commas. Find the 
//  maximum of the numbers and display it on the 
//  console. For example, if the user enters “5, 3, 
//  8, 1, 4", the program should display 8.

using System;

namespace CSharpLoopChallenges
{
    public class Challenge_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of single digit numbers seperated by a comma: ");

            var userInput = Console.ReadLine();
            var numbers = userInput.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var number in numbers)
            {
                if (max < Convert.ToInt32(number))
                {
                    max = Convert.ToInt32(number);
                }
            }

            Console.WriteLine("The highest number in your collection is {0}!", max);
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.