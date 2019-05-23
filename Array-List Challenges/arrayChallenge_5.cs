//  Write a program and ask the user to supply a list of comma 
//  separated numbers(e.g 5, 1, 9, 2, 10). If the list is empty 
//  or includes less than 5 numbers, display "Invalid List" and 
//  ask the user to re-try; otherwise, display the 3 smallest 
//  numbers in the list.

using System;
using System.Collections.Generic;

namespace CSharpArrayListChallenges
{
    class Challenge_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a set of numbers seperated by commas:\n");

            while (true)
            {
                var answer = Console.ReadLine();

                if (answer.Split(',').Length >= 5)
                {
                    var numberArray = answer.Split(',');
                    Array.Sort(numberArray);

                    Console.WriteLine("Lowest values in array:");
                    foreach (var number in numberArray)
                    {
                        if (Array.IndexOf(numberArray, number) < 3)
                            Console.WriteLine(number);
                    }

                    break;
                }

                else
                {
                    Console.WriteLine("Invalid List. Please try again.\n");
                }
            }
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.
