// Name: Eric Miramontes
// uID: u0801584

using System;
using System.Linq;

namespace Palindrome
{
    /// <summary>
    /// This class checks if a string is a palindrome.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Reads lines of text from the standard input stream.  Any line that
        /// that is a palindrome is outputted to the Console window.  All 
        /// characters are considered part of the text (punctuation, whitespace,
        /// and uppercase and lowercase letters).
        /// </summary>
        static void Main(string[] args)
        {
            String line;
            while ((line = Console.ReadLine()) != null)
            {
                var palindrome = new string(line.ToCharArray().Reverse().ToArray());
                if (line.Equals(palindrome))
                {
                    Console.WriteLine(palindrome);
                }
            }
        }
    }
}
