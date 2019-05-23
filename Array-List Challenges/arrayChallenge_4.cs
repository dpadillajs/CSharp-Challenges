//  Write a program and ask the user to continuously enter 
//  a number or type "Quit" to exit.The list of numbers may 
//  include duplicates. Display the unique numbers that the 
//  user has entered.

using System;
using System.Collections.Generic;

namespace CSharpArrayListChallenges
{
    class Challenge_4
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or type 'Quit' to exit.\nAnswer: ");
                var answer = Console.ReadLine();

                if (answer.ToLower() == "quit")
                    break;

                var number = Convert.ToInt32(answer);

                if (listOfNumbers.IndexOf(number) == -1)
                    listOfNumbers.Add(number);

                foreach (var listItem in listOfNumbers)
                    Console.WriteLine(listItem);
            }
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.