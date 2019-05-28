using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition();
        }
        public static void Hello()
        {
            Console.WriteLine("Hello What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
            Console.Read();
        }
        public static void Addition()
        {
            Console.WriteLine("Please enter the first number:");
            int num1 = int.Parse(s: Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is " + (num1 + num2));
            Console.Read();
        }
        public static void catDog()
        {
            string catDog;
            Console.WriteLine("Do you prefer dogs or cats?");
            catDog = Console.ReadLine();
            catDog = catDog.ToLower();
            if (catDog == "cats")
            {
                Console.WriteLine("Meow");
            }
            if (catDog == "dogs")
            {
                Console.WriteLine("Bark");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadLine();
        }
        public static void oddEvent()
       {
        int num;
        Console.WriteLine("Enter a number");
        num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else if (num % 2 != 0)
            {
                Console.WriteLine("Number is odd");
            }
            else
            {
                Console.WriteLine("Entry is invalid");
            }
            }
        public static void inches()
{   int heightInFeet;
    Console.WriteLine("Enter your height in feet");
    heightInFeet=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(heightInFeet * 12);
}

        public static void echo()
        {
    string word;
    Console.WriteLine("Enter a word");
    word= Console.ReadLine();
    Console.WriteLine(word.ToUpper());
    Console.WriteLine(word.ToLower());
    Console.WriteLine(word.ToLower());
}
    public static void killGrams()
        {
            int weightInpounds;
            Console.WriteLine("Enter a number");
            weightInpounds=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(weightInpounds * 0.45359237);

        }
     public static void date()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is" + today);
        }

    public static void age()
        {
            int age;
            Console.WriteLine("Enter your birth year");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Today.Year - age);
            Console.ReadLine();
        }

     public static void guess()
        {
            Console.WriteLine("Enter your guess");
            string guess = Console.ReadLine();
            if (guess == "csharp")
            {
                Console.WriteLine("Correct!");
            }
            else { Console.WriteLine("Wrong"); }
            Console.ReadLine();
        }

            }

        }
    
