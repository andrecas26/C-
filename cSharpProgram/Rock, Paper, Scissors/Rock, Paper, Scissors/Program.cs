using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors
{
    class Program
    {
        static void Main(string[] args)
        {


            int computerChoice;
            //Get player pick
            Console.WriteLine("Choose 0 for Rock, 1 for paper, or 2 for scissors");
            int playerChoice = int.Parse(Console.ReadLine());
            // Computer Random pick    
            Random generator = new Random();
            int randomNumber = generator.Next(0, 3);
            computerChoice = randomNumber;
            //compare computer pick of rock to user
            if (computerChoice == 0)
            {
                if (playerChoice == 1)
                {
                    Console.WriteLine("Computer chose rock, You win");
                }
                else if (playerChoice == 2)
                {
                    Console.WriteLine("Computer chose rock, Computer wins");
                }
                else if (playerChoice == 0)
                {
                    Console.WriteLine("It is a tie");
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }
            //compare computer pick of paper to user
            else if (computerChoice == 1)
            {
                if (playerChoice == 0)
                {
                    Console.WriteLine("Paper beats rock, computer wins");
                }
                else if (playerChoice == 2)
                {
                    Console.WriteLine("Scissors beats paper, You win");
                }
                else if (playerChoice == 1)
                {
                    Console.WriteLine("It is a tie");
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }

            //compare computer pick of scissors to user
            else if (computerChoice == 2)
            {
                if (playerChoice == 0)
                {
                    Console.WriteLine("Rock beats Sciccors, You win");
                }
                else if (playerChoice == 1)
                {
                    Console.WriteLine("Scissors beats paper, Computer wins");
                }
                else if (playerChoice == 2)
                {
                    Console.WriteLine("It is a tie");
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }


          Console.ReadLine();  }
                }
            }
            
        
    

   
