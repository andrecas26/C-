using System;
using System.Collections.Generic;
using System.Text;

namespace BookInventoryClass
{
    class Book
    {
        // notice the private set on the id
        public int Id { get; private set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public Book(String Title, String Author)//constructor
        {
            this.Title = Title;
            this.Author = Author;
        }
    }
}
