using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    { //Ask user to enter grades in a string. Example ("100 90")
        static Dictionary<string, int[]> studentGrades = new Dictionary<string, int[]>();
        static void Main(string[] args)
        {
            //Ask User to enter name or quit

            string name = "";

            while (name.ToLower() != "quit")
            {
                Console.WriteLine("Enter your name or quit if finished entering grades");
                name = Console.ReadLine();//Ask for student grades
                if (name == "quit")
                {
                    break;
                }

                Console.WriteLine("Enter the students grades, separated by a space: ");
                string strGrades = Console.ReadLine();
                string[] grades = strGrades.Split(' ');
                int[] studentgrades = new int[grades.Length];
                for (int i = 0; i < grades.Length; i++)
                {
                    studentgrades[i] = Convert.ToInt32(grades[i]);
                }

                studentGrades.Add(name, studentgrades);
            }
            //user entered quit
            //loop throught the student Grades dictionary
            foreach (var i in studentGrades.Keys)
            {
                int[] grades = studentGrades[i];
                Console.Write(i+": ");
                Console.Write(getvalues(grades));
                Console.WriteLine();

            }


        }
        public static string getvalues(int[]grades)
        {
            int lowestGrade = 100;
            int highestGrade = 0;
            int average = 0;
            string ret;
        for(int x = 0; x < grades.Length; x++ )
            {
                if(highestGrade < grades[x])
                {
                    highestGrade = grades[x];
                }
                if(lowestGrade > grades[x])
                {
                    lowestGrade = grades[x];
                }
                average += grades[x];
            }
            average = average / grades.Length;
            ret = "Average: " + average + " low: " + lowestGrade + " high: " + highestGrade;
            return ret;
        }
    }
}
