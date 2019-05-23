//  When you post a message on Facebook, depending on the 
//  number of people who like your post, Facebook displays 
//  different information.

//  If no one likes your post, it doesn't display anything.
//  If only one person likes your post, it 
//  displays: [Friend's Name] likes your post.
//  If two people like your post, it displays: [Friend 1] 
//  and [Friend 2] like your post.
//  If more than two people like your post, it 
//  displays: [Friend 1], [Friend 2] and [Number of 
//  Other People] others like your post.
//  Write a program and continuously ask the user to enter 
//  different names, until the user presses Enter (without 
//  supplying a name). Depending on the number of names provided, 
//  display a message based on the above pattern.

using System;
using System.Collections.Generic;

namespace CSharpArrayListChallenges
{
    class Challenge_1
    {
        static void Main(string[] args)
        {
            var friends = new List<string>();

            while (true)
            {
                Console.Write("Please enter a name: ");
                var answer = Console.ReadLine();

                if (answer != "")
                {
                    friends.Add(answer);
                    continue;
                }

                break;
            }

            switch (friends.Count)
            {
                case 0:
                    Console.WriteLine("No friends have liked your post.");
                    break;

                case 1:
                    Console.WriteLine("{0} liked your post.", friends[0]);
                    break;

                case 2:
                    Console.WriteLine("{0} and {1} liked your post.", friends[0], friends[1]);
                    break;

                default:
                    Console.WriteLine("{0}, {1}, and {2} other(s) liked your post.", friends[0], friends[1], friends.Count - 2);
                    break;
            }
        }
    }
}

// Challenges can be ran through Visual Studio Community (2013+)
// for evaluation. Input validation was not required for the goal.
