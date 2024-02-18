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
			//add code here
		}

		else
		{
			await DisplayAlert("Error", result.Error, "Ok");
		}
	}
}

}

