using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        /*
         * Constructor special method inside of our class, 
         * that going to get called when we create an object of this class.
         */
        public Book()
        {

        }

        public Book(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Creating Book.");

            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
