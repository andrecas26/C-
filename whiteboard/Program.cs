using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteboard
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find the longest string");

            //promt user to enter a long sentence
            Console.WriteLine("Enter a sentence and I will find the longest word in it:");
                //Store a users sentence
                string userSentence = Console.ReadLine().Trim();

            //1. split the sentence into indivdual words
            string[] userWords = userSentence.Split('');

            //2. remove punctuation
            char[] punctuation = new char[] { ',', '!', '"', }; 
            //2.2 Let us loop through the words to array and remove punctuatinon from each word
        }
    }
}
