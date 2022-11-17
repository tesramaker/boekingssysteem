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

        this.hotels = await this.apiCaller.GetAllHotels();

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

    async void OnSearchButtonClicked( object sender, EventArgs e )
    {
        try
        {
            await Navigation.PushAsync ( new FindVacation ( startDate.Date, endDate.Date, picker.SelectedItem.ToString ( ), Int16.Parse ( numberOfPeople.Text ) ) );
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
        _ = await apiCaller.GetHotelsByCity ( "Praag" );

        var x = 3;
    }

    async void OnTesterButtonClicked ( object sender, EventArgs e)
    {
        ApiCaller apiCaller = new ApiCaller();
        VacationApiModel vacation = new VacationApiModel(1, 1, 1, 1, DateTime.Now, DateTime.Now, 00.00, 1);
        try
        {
            await apiCaller.GetHotelsByCity("New York");
        }
        catch(Exception)
        {
            throw;
        }
    }

    async void OnTesterButtonClicked2(object sender, EventArgs e)
    {
        ApiCaller apiCaller = new ApiCaller();
        //VacationApiModel vacation = new VacationApiModel(1, 1, 1, 1, DateTime.Now, DateTime.Now, 00.00, 1);
        try
        {
            //await apiCaller.GetHotelsByCity("New York");
            Flight flight = await apiCaller.GetFlightById(8);
            
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void location_SelectedIndexChanged(object sender, EventArgs e)
    {
        string currentlySelected = this.picker.SelectedItem.ToString();
        int selectedIndex = this.picker.SelectedIndex;
        this.selectedCity = this.picker.SelectedItem.ToString();
    }
}
