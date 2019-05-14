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
        }
    }
    /*int playerChoice =;
    int computerChoice=;
    int 0 ="rock"
    int 1 = "paper"
    int 2 = "scissors"*/
        //Get player pick
        Console.WriteLine("Do you choose Rock, paper, or scissors");
        string PlayerChoice =Console.ReadLine();
        // Computer Random pick    
        Random generator = new Random();
    int randomNumber = generator.Next(0, 3);

    //compare computer pick of rock to user
    if(computerChoice ==0)
        if(playerChoice ==1)
    {
        Console.WriteLine("Computer chose rock, You win");
    }
    else if(playerChoice ==2)
    {
        Console.WriteLine("Computer chose rock, Computer wins");
    }
    else if( playerChoice ==0)
    {
        Console.WriteLine("It is a tie");
    }
    else
    {
        Console.WriteLine("Invalid Entry");
    //compare computer pick of paper to user
    if(computerChoice ==1)
        if(playerChoice == 0)
    {
        Console.WriteLine("Paper beats rock, computer wins");
    }
    else if(playerChoice == 2)
    {
        Console.WriteLine("Scissors beats paper, You win");
    else if(playerChoice ==1)
    {
        Console.WriteLine("It is a tie");
    else
    {
        Console.WriteLine("Invalid Entry");
    //compare computer pick of scissors to user
    if(computerChoice ==2)
        if(playerChoice ==0)
    {
        Console.WriteLine("Rock beats Sciccors, You win");
    }
    else if(playerChoice ==1)
    {
        Console.WriteLine("Scissors beats paper, Computer wins");
    }
    else if(playerChoice ==2)
    {
        Console.WriteLine("It is a tie");
    }
    else
    {
        Console.WriteLine("Invalid Entry");
    }

        Console.ReadLine();
}
