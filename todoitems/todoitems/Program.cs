using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoitems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to add an item Yes/No?");
            string answer = Console.ReadLine();
            //while loop
            while (answer == yes)
            {
                Console.WriteLine("Describe the to to item");
                string itemDescription = Console.ReadLine();
                Console.WriteLine("Enter the due date");
                string dueDate = Console.ReadLine();
                Console.WriteLine("Enter the priority: Low, Medium, or High");
                string priority = Console.ReadLine();
                if(answer == No)
                {
                    break;
                }
                Console.WriteLine(itemDescription, dueDate, priority);
            }


        }

    }
    class toDoItem
    {
        public string description { get; set; }
        public string dueDate { get; set; }
        public string priority { get; set; }

        public toDoItem(string description, string dueDate, string priority)
        {

        }
    }
}
