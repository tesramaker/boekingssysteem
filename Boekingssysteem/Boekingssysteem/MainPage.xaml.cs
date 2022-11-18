using Boekingssysteem.ApiModels;
using System.Data.Common;

namespace Boekingssysteem;

public partial class MainPage : ContentPage
{
    private CheckBox checkbox;
    private Picker picker;
    private ApiCaller apiCaller;
    private string selectedCity;
    private List<Hotel> hotels;
    private List<String> hotelStrings;
    private Manager manager = new Manager();


    public MainPage ( )
    {
        InitializeComponent ();

        this.checkbox = FindByName("randomLocation") as CheckBox;
        this.picker = FindByName("location") as Picker;
        this.apiCaller = new ApiCaller();
        this.selectedCity = "";
        this.hotelStrings = new List<String>();

        Layout ();
    }

    async void Layout ()
    {

        TapGestureRecognizer listener = new TapGestureRecognizer();

        listener.Tapped += ( sender, e ) =>
        {
            picker.IsEnabled = !checkbox.IsChecked;
        };

        this.hotels = await this.manager.GetAllHotels();

        foreach (Hotel hotel in hotels)
        {
            if ( !hotelStrings.Contains(hotel.city))
            hotelStrings.Add ( hotel.city );
        }

        picker.ItemsSource = hotelStrings;
        picker.SelectedIndex = 0;

        checkbox.GestureRecognizers.Add ( listener );
        Entry numPeople = FindByName("numberOfPeople") as Entry;

        Label Login = FindByName("Login") as Label;
        TapGestureRecognizer GotoLogin = new TapGestureRecognizer();
        GotoLogin.Tapped += async ( sender, e ) =>
        {
            await Navigation.PushAsync( new LoginPage ( ) );
        };
        Login.GestureRecognizers.Add( GotoLogin );
    }

    async void OnSearchButtonClicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync ( new FindVacation ( startDate.Date, endDate.Date, getRandomLocationOrNot(), Int16.Parse ( numberOfPeople.Text ) ) );
        }
        catch
        {
            await DisplayAlert ( "Kan niet doorgaan", "Vul alle velden in.", "OK" );
        }
    }

    string getRandomLocationOrNot()
    {
        String locationToGo = "";
        if (randomLocation.IsChecked)//Check if randomcheckbox is set and then select random value from picker
        {
            String[] arrayFromPicker = picker.GetItemsAsArray();
            Random random = new Random();
            int randomIndex = random.Next(0, arrayFromPicker.Length);
            locationToGo = arrayFromPicker[randomIndex];
        }
        else
        {
            locationToGo = picker.SelectedItem.ToString();
        }
        return locationToGo;
    }

    private void location_SelectedIndexChanged(object sender, EventArgs e)
    {
        string currentlySelected = this.picker.SelectedItem.ToString();
        int selectedIndex = this.picker.SelectedIndex;
        this.selectedCity = this.picker.SelectedItem.ToString();
    }
}
