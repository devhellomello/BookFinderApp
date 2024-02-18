using MauiApp1;

namespace BookFinder
{
    public class BookResult
    {
        public Books Books { get; }
        public string Error { get; }
        
        // uses method to check if the return is empty
        public bool Successful { get => string.IsNullOrEmpty(Error); } 

        public BookResult(Books books)
        {
            Books = books;
        }

        public BookResult(string error)
        {
            Error = error;
        }

    }

}