namespace Boekingssysteem;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	async void OnSearchButtonClicked ( object sender, EventArgs e)
	{
		//A check is still needed to see if all fields are filled in
        await Navigation.PushAsync ( new FindVacation(startDate.Date, endDate.Date, location.Text, Int16.Parse(numberOfPeople.Text)) );
    }
}
