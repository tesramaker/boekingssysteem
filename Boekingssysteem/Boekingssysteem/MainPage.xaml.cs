namespace Boekingssysteem;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		CheckBox checkbox = FindByName("randomLocation") as CheckBox;
		Entry location = FindByName("location") as Entry;
		var listener = new TapGestureRecognizer();
        listener.Tapped += ( sender, e ) =>
        {
            location.IsEnabled = !checkbox.IsChecked;
        };
        checkbox.GestureRecognizers.Add ( listener );
        }

	async void OnSearchButtonClicked ( object sender, EventArgs e)
	{
        await Navigation.PushAsync ( new FindVacation(startDate.Date, endDate.Date, location.Text, Int16.Parse(numberOfPeople.Text)) );
    }
}
