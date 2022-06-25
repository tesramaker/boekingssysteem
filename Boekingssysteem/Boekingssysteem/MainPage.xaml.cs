namespace Boekingssysteem;

public partial class MainPage : ContentPage
    {
    public MainPage ( )
        {
        InitializeComponent ( );
        Layout ( );
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
        }

    async void OnSearchButtonClicked ( object sender, EventArgs e )
        {
        //A check is still needed to see if all fields are filled in
        try
            {
            await Navigation.PushAsync ( new FindVacation ( startDate.Date, endDate.Date, location.Text, Int16.Parse ( numberOfPeople.Text ) ) );
            }
        catch
            {
            await DisplayAlert ( "Kan niet doorgaan", "Vul alle velden in.", "OK" );
            }
        }

    }
