//using System;
//using System.Collections.Generic;
namespace BookFinder
{
	public class Book //this class creates a data model for the information the API returns
	{		
		public string Title { get; set; }
		public IList<string> Authors { get; set; } = new List<string>(); //in case there are multiple authors
		public string Publisher { get; set; }
		public string PublishedDate { get; set; }
		public string Description { get; set; }
		public string Thumbnail { get; set; }
		}

}

// all of the public strings are results from the API call I tested using Bruno which is like Insomnia, 
// I then converted the JSON to C# using an online converter and I chose the properties I wanted to include in my search results.
// and included them here where I define my Book class and properties as well as the ImageLinks class
// as indicated by the JSON conversion.




