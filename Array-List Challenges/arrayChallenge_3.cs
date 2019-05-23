//  Write a program and ask the user to enter 5 numbers. If 
//  a number has been previously entered, display an error 
//  message and ask the user to re-try. Once the user 
//  successfully enters 5 unique numbers, sort them and 
//  display the result on the console.

using System;
using System.Collections.Generic;

namespace CSharpArrayListChallenges
{
    class Challenge_3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            var list = new List<int>();
            list.Add(Convert.ToInt32(Console.ReadLine()));

            while (true)
            {
                Console.Write("Another one: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (list.IndexOf(number) == -1)
                {
                    list.Add(number);
                }
                else
                {
                    Console.WriteLine("That number has already been inputted. Please try again.");
                }

                if (list.Count == 5)
                {
                    break;
                }
            }

            list.Sort();
            Console.WriteLine("Here's your list of unique numbers in order: ");

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.
