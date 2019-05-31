using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towers_of_Hanoi
{
    class Program
    {
        static void Main(string[] args);


        // Create Board using empty B and C stack
        static Program()
        {
            stacks = new Dictionary<string, Stack<int>> stacks;
            {
                { "A", new Stack<int>() { 4, 3, 2, 1 } };
                { "B", new Stack<int>() { } },
            { "C", new Stack<int>() { } }
            };

        }

        public static void Main()
        {//while the game is not over
            while (!GameOver())
            {
                Console.Clear();

                PrintStacks();

                Console.WriteLine("Enter Starting Stack");
                string start = Console.ReadLine();

                Console.WriteLine("Enter Finish Stack:");
                string finish = Console.ReadLine();

                if (isLegal(start, finish))
                {
                    movePiece(start, finish);
                }
                else
                {
                    Console.WriteLine("Illegal move, try again");
                }

            }

            PrintStacks();
            Console.WriteLine("You Won!!!");
        }

        public static bool GameOver()//Game over if all four stacks are on C 
        {
            if (stacks["C"].Count == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void moveBlock(string start, string finish)// need to use pop to get top disc
        {
            Stack<int> startStack = stacks[start];
            Stack<int> finishStack = stacks[finish];

            int movingBlock = startStack[startStack.Count - 1];

            finishStack.Add(movingBlock);
            startStack.Remove(movingBlock);
        }

        public static bool isLegalMove(string start, string finish)// checks if move is legal
        {
            if (stacks[finish].Count == 0)
            {
                return true;
            }

            Stack<int> startStack = stacks[start];
            Stack<int> finishStack = finishStack = stacks[finish];

            int movingBlock = startStack[startStack.Count - 1];
            int finishStackLastBlock = finishStack[finishStack.Count - 1];

            if (movingBlock < finishStackLastBlock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void PrintStacks()
        {
            string[] letters = new string[] { "A", "B", "C" };
            for (var i = 0; i < letters.Length; i++)
            {
                Stack<string> blocks = new Stack<string>();
                for (var j = 0; j < stacks[letters[i]].Count; j++)
                {
                    blocks.Add(stacks[letters[i]][j].ToString());
                }
                Console.WriteLine(letters[i] + ": " + String.Join("|", blocks));

            }
        }
    }
}

