using System;
namespace LendingLibrary.Classes
{
    public class Book
    {
        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }

        public string Author { get; }
        public string Title { get; }
    }
}
