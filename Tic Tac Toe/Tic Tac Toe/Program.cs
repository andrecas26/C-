using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        public static String[][] board = new string[][]
        {
           new string[] {" "," "," " },
           new string[] {" "," "," " },
           new string[] {" "," "," " }
        };
        static void Main(string[] args)//resetBoard and startGame
        {
            printBoard();
            Console.ReadLine();
        }
        //Print Board using for loop
        static void printBoard()
        {
        for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("-------");
                for (int i = 0; i < 3; i++)
                 {
                 Console.Write("|"+board[j][i]);
                 
                }Console.WriteLine("|");
           }
        
         
    
            Console.WriteLine("-------");

    }
        /*placeMark(int rowPos. int ColPos)
        {
            int RowIdx = rowPos - 1;
            int ColIdx = ColPos = 1;

            board[RowIdx.ColIdx] currentPlayer;
            printBoard();
            //switch player, 
        }*/
        

  }      
}     
    

