//  Write a program that picks a random number 
//  between 1 and 10. Give the user 4 chances to
//  guess the number. If the user guesses the number, 
//  display “You won"; otherwise, display “You lost".

using System;

namespace CSharpLoopChallenges
{
    public class Challenge_4
    {
        static void Main(string[] args)
        {
            byte randomNum = (byte)new Random().Next(1, 10);
            Console.Write("You have 4 chances to guess the correct number from 1 to 10.\nAnswer: ");

            for (var i = 0; i < 4; i++)
            {
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess != randomNum)
                {
                    if (i != 3)
                    {
                        Console.Write("Please try again. You have {0} more guesses.\nAnswer: ", 3 - i);
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry! The answer was {0}.", randomNum);
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Congratulations! The answer was {0}.", randomNum);
                    break;
                }
            }
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.