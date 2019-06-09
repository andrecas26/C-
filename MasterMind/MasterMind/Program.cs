using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        public static void Main(string[] args)
        {

            game();


        }
        public static void game()
        {
            int guessLimit = 0;
            //Get computer to generate colors
            int[] guessColor = new int[] { 1, 2, 3 };
            Random ran = new Random();
            int mynum = guessColor[ran.Next(0, guessColor.Length)];
            int mynum2 = guessColor[ran.Next(0, guessColor.Length)];
            int[] myNums = new int[] { mynum, mynum2 };
            //Ask user to enter their guess

            while (guessLimit < 6)
            {
                Console.WriteLine("Guess the two colors using 1= green, 2= red, 3= blue");
                string userGuess = Console.ReadLine();
                string[] userEntry = userGuess.Split(' ');
                int[] userEntryInt = new int[2];
                userEntryInt[0] = Int32.Parse(userEntry[0]);
                userEntryInt[1] = Int32.Parse(userEntry[1]);
                bool corretGuess = myNums.SequenceEqual(userEntryInt);
                var colorCorrect = 0;
                var positonCorrect = 0;
                //checks to see if correct color guessed
                if (userEntryInt.Contains(mynum))
                {
                    colorCorrect++;
                }
                if (userEntryInt.Contains(mynum2))
                {
                    colorCorrect++;
                }
                if (userEntryInt[0] == mynum)
                {
                    positonCorrect++;
                }
                if (userEntryInt[1] == mynum2)
                {
                    positonCorrect++;
                }

                if (corretGuess)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("Your hint is" + colorCorrect + "-" + positonCorrect);
                }
            }
        }
    }
}