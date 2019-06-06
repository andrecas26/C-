# Towers of Hanoi

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towers_of_Hanoi
{
    class Program
    {
		//used dictionary to make stacks and numbers
		//used int and string for board
        static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>()
            {
                { "A", new Stack<int>()  },
                { "B", new Stack<int>() { } },
                { "C", new Stack<int>() { } }
            };

		
        //Create Board using empty B and C
        public static void Main()
        {   //setting up board
            for (int i = 1; i < 5; i++)
            {
                board["A"].Push(i);
            }
            //while the game is not over
            while (!GameOver())
            {

                PrintStacks();
				//used .ToUpper to capitalize entry if lower case
                Console.WriteLine("Enter Starting Stack");
                string start = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter Finish Stack:");
                string finish = Console.ReadLine().ToUpper();

                if (isLegalMove(start, finish))
                {
                    moveBlock(start, finish);
                }
                else
                {
                    Console.WriteLine("Illegal move, try again");
                }

            }
        }
        public static bool GameOver()//Game over if all four stacks are on B or C and used or  in bool 
        {
            if (board["C"].Count == 4 || board["B"].Count == 4)
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
            Stack<int> startStack = board[start];
            Stack<int> finishStack = board[finish];

            int movingBlock = startStack.Peek();//[startStack.Count - 1];

            finishStack.Push(movingBlock);
            startStack.Pop();
        }

        public static bool isLegalMove(string start, string finish)// checks if move is legal
        {
            if (board[finish].Count == 0)
            {
                return true;
            }

            Stack<int> startStack = board[start];
            Stack<int> finishStack = board[finish];

            int movingBlock = startStack.Peek();
            int finishStackLastBlock = finishStack.Peek();

            if (movingBlock < finishStackLastBlock) // checks if moving block int is less than finishstack
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


            foreach (var tower in board.Keys)
            {
                var currentStack = board[tower];
                Console.WriteLine(tower + ": " + string.Join(", ", currentStack));
            }
        }
    }
}

