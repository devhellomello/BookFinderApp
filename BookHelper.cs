using System.Net.Http.Json;
using System;

namespace BookFinder
{
    public class BookHelper
    {
        private const string _errorMessage = "Book not found, please try again.";
        private const string _baseUrl = "https://www.googleapis.com/books/v1/";
        private static HttpClient _client = new HttpClient()
        {
            BaseAddress = new Uri(_baseUrl)
        };
        public async Task<BookResult> GetBooks(string title)
        {
            //check to make sure title is not empty
            if(string.IsNullOrEmpty(title))
                return new BookResult("Naughty, naughty! No empty lines.");

            //call to the web API using API key from Google Books
            try
            {
                var books = await _client.GetFromJsonAsync<Books>("key=AIzaSyDImyo_B1VKeJJR8Y0lGT03suji5sQnFno={title}");
                if(string.Equals(books.Response, "false", StringComparison.CurrentCultureIgnoreCase))
                {
                    return new BookResult(_errorMessage);
                }

                return new BookResult(books);
            }

            catch (Exception)
            {
                return new BookResult(_errorMessage);
            }
        }

    }

}