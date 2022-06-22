namespace Boekingssysteem;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	async void OnSearchButtonClicked ( object sender, EventArgs e)
	{
        await Navigation.PushAsync ( new FindVacation ( ) );
    }
}
