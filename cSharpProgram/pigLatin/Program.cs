using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string input = Console.ReadLine();
            Console.WriteLine(ToPigLatin(input));
            Console.Read();

        }
        public static string ToPigLatin(string word)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            char[] character = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

            int firstVowelPosition = word.IndexOfAny(vowels);
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            //If a word starts and ends in a vowel 
            if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
            {
                return (word + "yay");
            }
            else if (vowels.Contains(firstLetter) && (character.Contains(lastLetter)))
            {
                return (word + "ay");
            }
            else if (firstVowelPosition == -1)  // no vowel in the word
            {
                return (word + "ay");
            }
            else if (firstVowelPosition > -1 && character.Contains(firstLetter))
            {
                word = word.Substring(firstVowelPosition) +
                    word.Substring(0, firstVowelPosition) + "ay";

                return word;


            } return word;
        }
    }
}