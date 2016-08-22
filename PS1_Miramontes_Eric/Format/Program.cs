// Name: Eric Miramontes
// uID: u0801584

using System;
using System.Collections.Generic;
using System.Linq;

namespace Format
{
    /// <summary>
    /// This program formats a stream according to the parameter the user inputs.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Reads lines of text from the standard input stream.  Outputs lines
        /// where the number of words is equal to the integer parameter.  If no
        /// parameter is passed, it will default to 1.
        /// </summary>
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("Pass one integer to format a string with");
                System.Environment.Exit(1);
            }

            // Make sure the parameter is a positive integer
            int parameter;
            if (int.TryParse(args[0], out parameter))
            {
                if (parameter < 1)
                {
                    parameter = 1;
                }
            }
            else
            {
                parameter = 1;
            }

            String line;
            var wordList = new List<string>();
            var formattedWordList = new List<string>();
            while ((line = Console.ReadLine()) != null)
            {
                // Add next line of words into wordList
                wordList = wordList.Concat(line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries)).ToList();

                // Put same number as parameter of words into formattedWordList
                while (wordList.Count >= parameter)
                {
                    formattedWordList = new List<string>();
                    for (int i = 0; i < parameter; i++)
                    {
                        formattedWordList.Add(wordList.ElementAt(0));
                        wordList.RemoveAt(0);
                    }

                    Console.WriteLine(String.Join(" ", formattedWordList));
                }
            }

            // Print remaining words
            Console.WriteLine(String.Join(" ", wordList));
        }
    }
}