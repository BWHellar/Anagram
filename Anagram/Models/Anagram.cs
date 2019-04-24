using System;

namespace Anagram
{
    class Program
    {
        // The usefulness of args is to have the console remember all the commands given to it.
        static void Main(string[] args)
        {
            // Here we are asking the user to input both the words they want to compare.
            Console.WriteLine("Enter first word");
            string firstword = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string secondword = Console.ReadLine();
            // We want to take the words and put them to a character array which is the equiv 
            // of splitting an array. Typing "Tom" will come out "t o m". 
            char[] char1 = firstword.ToLower().ToCharArray();
            char[] char2 = secondword.ToLower().ToCharArray();
            // We want to sort the individual characters from both our words so we can compare 
            // them later down the line.
            Array.Sort(char1);
            Array.Sort(char2);
            //  We will push the letters together into a new string in order to compare them.
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);
            //  Now we want to compare the two new strings against eachother to see if the letters match.
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine ("Yes " + firstword + " is a anagram of " + secondword);
            }
            else
            {
                Console.WriteLine ("No " + firstword + " is NOT an anagram of " + secondword);
            }
        }
    }
}