using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask User to enter name or quit
            Console.WriteLine("Enter your name or quit if finished entering grades");
            string name = Console.ReadLine();

            //Ask user to enter grades in a string. Example ("100 90")
            Dictionary<string, string> studentGrades = new Dictionary<string, string>();
            while (name.ToLower() != "quit")
            {
                //Ask for student grades
                Console.WriteLine("Enter the students grades, separated by a space: ");
                string strGrades =
                Console.ReadLine();
                studentsGrades.Add(name, strGrades);
            }

            //Ask user for name again
            Console.WriteLine("Enter students name, or quit to finish");
            name = Console.ReadLine();
        }

        //user entered quit
        //loop throught the student Grades dictionary
        foreach (var i in studentGrades.Keys)
        {
            string g = studentGrades[i];
        //output students name
        Console.WriteLine($"Name: {i}");
        Console.WriteLine($"Grades: {studentGrades[i]);

            
                //Add students name and grades to dictionary
            Dictionary<string, string[]> categories = new Dictionary<string, string[]>();
            categories.Add("name", new string[] { });
            categories.Add("grades", new string[] { });
            
            //Repeats the process of dictionary until user enters quit
            
            //loops through and prints students name and lowest, highest, and average gradej


        }
    }
}
