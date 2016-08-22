// Name: Eric Miramontes
// uID: u0801584

using System;

namespace LowerCase
{
    /// <summary>
    /// This class lists the words in a line in lower-case.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Reads lines of text from the standard input stream.  Converts 
        /// each word to lower-case and then outputs them line by line.  
        /// Extra white spaces are ignored.
        /// </summary>
        static void Main(string[] args)
        {
            String line;
            while ((line = Console.ReadLine()) != null)
            {
                var lineArray = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in lineArray)
                {
                    Console.WriteLine(word.ToLower());
                }
            }
        }
    }
}