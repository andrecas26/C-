using System;

namespace BookInventoryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an instance of the context
            BookContext context = new BookContext();

            // makes sure that the table exists, 
            //and creates it if it does not already exist
            context.Database.EnsureCreated();

            // ask the user for a Title to add
            Console.WriteLine("Enter Title and Author");
            String TitleAuthor = Console.ReadLine();

            // split the input into parts, and make sure 
            // we have 2 parts only
            String[] parts = TitleAuthor.Split();
            if (parts.Length == 2)
            {
                // create a new book object, notce that we do not 
                // select an id, we let the framework handle that
                Book newBook = new Book(parts[0], parts[1]);

                // add the newly created book instance to the context
                // notice how similar this is to adding a item to a list,
                context.Books.Add(newBook);

                // ask the context to save any changes to the database 
                context.SaveChanges();
                Console.WriteLine("Added the Book.");
            }
            else
            {
                Console.WriteLine("Invalid Book, did not add Book");
            }

            Console.WriteLine("The Current List of students are: ");
            // use a for each loop to loop through the students in the context
            // notice how similar this is to looping through a list
            foreach (Books in context.Books)
            {
                Console.WriteLine("{0} - {1} {2}",
                     Id, FirstName, LastName);
            }
        }
    }
}
