using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Pig Latin
 * =========
 * Pig Latin is an argot ("secret" language) in which words in English are altered to conceal the words from others
 * not familiar with the rules.
 * 
 * You convert a word to pig latin by transferring the initial consonant or consonant cluster of the word to the end 
 * of the word with -ay appended to the end. If the word starts with a vowel (including y), append -yay to the end. 
 * For example, "pig" would become igpay (taking the 'p' and 'ay' to create a suffix) 
 * 
 */ 
namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word you want to translate: ");
            string input = Console.ReadLine();

            string suffix = string.Empty;
            char[] inputArray = input.ToCharArray();
            char[] vowelArray = {'a','e','i','o','u','y'};
            string output = string.Empty;

            // Determine if the starting letter is a vowel or a consonant
            if (vowelArray.Contains(inputArray[0]))
                suffix = "yay";
            else
                suffix = "ay";

            // Depending on the suffix, take the cluster of consonants and put them at the end
            if(suffix == "ay") // look for consonants
            {
                while (!vowelArray.Contains(inputArray[0]))
                {
                    char temp = inputArray[0];
                    Array.Resize(ref inputArray, inputArray.Length + 1);
                    inputArray[inputArray.Length - 1] = temp;
                    inputArray = inputArray.Skip(1).ToArray();
                }
            }

            // Prepare output
            output = new string(inputArray) + suffix;
            Console.WriteLine("Converted to Pig Latin means: " + output);
            Console.Read();
        }
    }
}
