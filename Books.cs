using System;
namespace BookFinder;

public class Books 
{	
	public string Title { get; set; }
	public IList<string> Authors { get; set; }
	public string Publisher { get; set; }
	public string PublishedDate { get; set; }
	public string Description { get; set; }
}
public class ImageLinks 
{
 public string Thumbnail { get; set; }
}




