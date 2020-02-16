using System;
using System.Collections.Generic;

namespace Lab1
{
    static class Program
    {
        static int correct = 0;
        static string answer;
        static List<string> posResponses;
        static List<string> negResponses;

        static void Main()
        {
            posResponses = new List<string>() { "yes", "ye", "yea", "y", "yeah", "true", "positive" };
            negResponses = new List<string>() { "no", "nope", "n", "nah", "false", "negative" };

            Console.WriteLine("Is C# a programming language?");
            answer = Console.ReadLine();
            if (posResponses.Contains(answer.ToLower()))
                correct++;

            Console.WriteLine("Is it the year 2021 ?");
            answer = Console.ReadLine();
            if (negResponses.Contains(answer.ToLower()))
                correct++;

            Console.WriteLine("Does a dog have 16 toes?");
            answer = Console.ReadLine();
            if (posResponses.Contains(answer.ToLower()))
                correct++;

            Console.WriteLine("Is Italy part of the European Union?");
            answer = Console.ReadLine();
            if (posResponses.Contains(answer.ToLower()))
                correct++;

            Console.WriteLine("Do nuts grow on trees?");
            answer = Console.ReadLine();
            if (posResponses.Contains(answer.ToLower()))
                correct++;

            Console.WriteLine("\nThis concludes the quiz, you scored " + correct + " out of 5");
        }
    }
}
