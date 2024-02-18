namespace BookFinder;

public partial class MainPage : ContentPage
{
	

    public MainPage()
	{
		InitializeComponent();
		_bookHelper = new BookHelper();
	}
	private BookHelper _bookHelper;

    private void InitializeComponent()
    {
        throw new NotImplementedException();
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

