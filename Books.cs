namespace MauiApp1;

public class Books : ContentPage
{
	public Books()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}

public class VolumeInfo {
 public string title { get; set; }
 public IList<string> authors { get; set; }
 public string publisher { get; set; }
 public string publishedDate { get; set; }
 public string description { get; set; }

}
public class ImageLinks {
 public string smallThumbnail { get; set; }

}




