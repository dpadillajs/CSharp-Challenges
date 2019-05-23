//  Write a program and ask the user to enter their 
//  name.Use an array to reverse the name and then
//  store the result in a new string. Display the 
//  reversed name on the console.

using System;
using System.Collections.Generic;

namespace CSharpArrayListChallenges
{
    class Challenge_2
    {
        static void Main(string[] args)
        {
            // Obtain Values
            Console.Write("What is your name: ");
            var name = Console.ReadLine();

            // Convert String to Array
            var nameArray = name.ToCharArray();

            // Reverse Array
            Array.Reverse(nameArray);

            // Print Name Reversed
            Console.WriteLine(nameArray);

        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.