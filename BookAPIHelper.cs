using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BookFinder
{
    public class GoogleBooksApiResponse
    {
        public List<GoogleBookItem> Items { get; set; }
    }

    public class GoogleBookItem
    {           
        public VolumeInfo VolumeInfo { get; set; }
    }
        public class VolumeInfo
        {   
            public string Title { get; set; }
            public List<string> Authors { get; set; }
            public string Publisher { get; set; }
            public string PublishedDate { get; set; }
            public string Description { get; set; }
            public string Thumbnail { get; set; }
        }       

    public class BookApiHelper
    {
        private const string ApiKey = "AIzaSyDImyo_B1VKeJJR8Y0lGT03suji5sQnFno";
        private const string BaseUrl = "https://www.googleapis.com/books/v1/volumes";
        private static readonly HttpClient Client = new HttpClient();

        public async Task<List<Book>> GetBookTitle(string title)
        {
           var books = new List<Book>();
           
           // if the title is empty an empty list is returned
            if (string.IsNullOrEmpty(title))
            {
                return books;
            }

            try
            {
                var urlString = $"{BaseUrl}?q=intitle:{title}&key={ApiKey}";
                var response = await Client.GetFromJsonAsync<GoogleBooksApiResponse>(urlString);
               
                if (response == null || response.Items == null || response.Items.Count == 0)
                {
                    return books;
                }

                foreach (var item in response.Items )
                {
                    books.Add(new Book
                    {
                        Title = item.VolumeInfo.Title,
                        Authors = item.VolumeInfo.Authors,
                        Publisher = item.VolumeInfo.Publisher,
                        PublishedDate = item.VolumeInfo.PublishedDate,
                        Description = item.VolumeInfo.Description,
                        Thumbnail = item.VolumeInfo?.Thumbnail
                    });
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: {ex. Message}");
            }

        return books;
        }

    }
    
}

