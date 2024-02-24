//using Microsoft.Maui.Controls;
//using Microsoft.Maui.Controls.Xaml;
//using System;

namespace BookFinder
{
public partial class MainPage : ContentPage
{
	private BookApiHelper  _bookApiHelper = new BookApiHelper();

    public MainPage()
	{
		InitializeComponent();
	}
    private async void SearchBtnClicked (object sender, EventArgs e)
	{
		ClearResults();

		try
		{
			var result = await _bookApiHelper.GetBookTitle(bookEntry.Text);
            if (result == null || result.Count <= 0)
                {
                    await DisplayAlert("Error", "Sorry, No book(s) found.", "Ok");
                }
                else
                {
                    DisplayFirstBook(result[0]);
                }

            }
		catch (Exception)
		{
			await DisplayAlert("Error", "Sorry, No book(s) found.", "Ok");
		}
		finally
		{	
			bookEntry.Text = string.Empty;
		}
}
 private void ClearResults()
 {
				bookImage.Source = null;
				bookTitleLabel.Text = string.Empty;
				bookAuthorLabel.Text = string.Empty;
				bookPublisherLabel.Text = string.Empty;
				bookPublishedDateLabel.Text = string.Empty;
				bookDescriptionLabel.Text = string.Empty;
				searchStack.IsVisible = true;
				resultsStack.IsVisible = false;
 }
 private void DisplayFirstBook (Book book)
 {
				bookImage.Source = book.Thumbnail ?? "blankbook.png";
				bookTitleLabel.Text = book.Title;
				bookAuthorLabel.Text = string.Join(" , ",  book.Authors);
				bookPublisherLabel.Text = book.Publisher;
				bookPublishedDateLabel.Text = book.PublishedDate;
				bookDescriptionLabel.Text = book.Description;
				searchStack.IsVisible = false;
				resultsStack.IsVisible = true;
 }

private void BookClearBtn_Clicked(object sender, EventArgs e)
{
	ClearResults();
}
}

}
