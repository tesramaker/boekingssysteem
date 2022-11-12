namespace Boekingssysteem;

public partial class MainPage : ContentPage
    {
    public MainPage ( )
        {
        InitializeComponent ( );
        Layout ();
        }

    void Layout()
        {

        CheckBox checkbox = FindByName("randomLocation") as CheckBox;
        Entry location = FindByName("location") as Entry;
        var listener = new TapGestureRecognizer();
        listener.Tapped += ( sender, e ) =>
        {
            location.IsEnabled = !checkbox.IsChecked;
        };
        checkbox.GestureRecognizers.Add ( listener );
        Entry numPeople = FindByName("numberOfPeople") as Entry;

        Label Login = FindByName("Login") as Label;
        var GotoLogin = new TapGestureRecognizer();
        GotoLogin.Tapped += async ( sender, e ) =>
        {
            await Navigation.PushAsync ( new LoginPage ( ) );
        };
        Login.GestureRecognizers.Add ( GotoLogin );
        }

    async void OnSearchButtonClicked ( object sender, EventArgs e )
        {
        try
            {
            await Navigation.PushAsync ( new FindVacation ( startDate.Date, endDate.Date, location.Text, Int16.Parse ( numberOfPeople.Text ) ) );
            }
        catch
            {
            await DisplayAlert ( "Kan niet doorgaan", "Vul alle velden in.", "OK" );
            }
        }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        ApiCaller apiCaller = new ApiCaller();
        List<Flight> flights = await apiCaller.GetAllFlights();
        List<Hotel> hotels = await apiCaller.GetHotelsByCity("Praag");

        var x = 3;
    }
}
