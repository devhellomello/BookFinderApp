using System;
namespace BookFinder
{
    public class BookResult
    {
        public Books Books { get; }
        public string Error { get; }
        
        // uses method to check if the return is empty
        public bool Successful { get => string.IsNullOrEmpty(Error); } 

        public BookResult(Books? books)
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            Books = books;
#pragma warning restore CS8601 // Possible null reference assignment.
        }

        public BookResult(string? error)
        {
            Error = error;
        }

    }

}