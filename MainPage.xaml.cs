using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;

namespace BookFinder
{
public partial class MainPage : ContentPage
{
	private BookHelper _bookHelper;

    public MainPage()
	{
		InitializeComponent();
		_bookHelper = new BookHelper();
	}
    private async void ClickOnSearch(object sender, EventArgs e)
	{
		var result = await _bookHelper.GetBooks(booksEntry.Text);
		if(result.Successful)
		{
			var books = result.Books;
			if(string.IsNullOrEmpty(books.Thumbnail))
			{
				booksImage.Source = new UriImageSource() { Uri = new Uri(books.Thumbnail) };
			}

			else
			{
				booksImage.Source = new FileImageSource() { File = "blankbook.png" };
			}

			bookTitleLabel.Text = books.Title;
			bookAuthorLabel.Text = books.Authors;
			bookPublisher.Text = books.Publisher;
			bookPublishedDate.Text = books.PublishedDate;
			bookDescription.Text = books.Description;
			
					
		}

		else
		{
			await DisplayAlert("Error", result.Error, "Ok");
			booksEntry.Text = string.Empty;
		}
	}
}

}

