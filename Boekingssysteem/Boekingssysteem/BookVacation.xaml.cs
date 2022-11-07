namespace Boekingssysteem;

public partial class BookVacation : ContentPage
{
    double total;
    Hotel hotel;
    Flight flight;
    int numberOfPersons;
    int extraBagage;
    internal BookVacation( Hotel hotel, int numberOfPersons, Flight flight)
    {
        this.hotel = hotel;
        this.flight = flight;
        this.numberOfPersons = numberOfPersons;
        InitializeComponent ( );

        Label Back = FindByName("Back") as Label;
        var BackClick = new TapGestureRecognizer ( );
        BackClick.Tapped += async ( sender, e ) =>
        {
            await Navigation.PopAsync ( );
        };
        Back.GestureRecognizers.Add ( BackClick );
        addContentToPage ( hotel, numberOfPersons, flight );
        }

    internal void addContentToPage(Hotel hotel, int numberOfPersons, Flight flight)
    {
        Hotel.Text = hotel.name;
        Location.Text = hotel.city;
        PriceHotel.Text = (hotel.room.pricePerNightPerPerson * numberOfPersons).ToString();

        Flight.Text = flight.plane.airline;
        ToFlight.Text = flight.departureDate.ToString();
        FroFlight.Text = flight.arrivalDate.ToString();
        FlightPrice.Text = (flight.price * numberOfPersons).ToString();

        total = (hotel.room.pricePerNightPerPerson * numberOfPersons) + (flight.price * numberOfPersons);
        Total.Text = total.ToString();
    }

    async void annChanged(object sender, EventArgs e)
    {
        CheckBox checkBox = (CheckBox)sender;
        if (checkBox.IsChecked)
        {
            AnnPrice.Text = "20";
            total += 20;
            Total.Text = total.ToString();
        }
        else
        {
            AnnPrice.Text = "0";
            total -= 20;
            Total.Text = total.ToString();
        }     
    }

    async void bagageChanged(object sender, EventArgs e)
    {
        CheckBox checkBox = (CheckBox)sender;
        if (checkBox.IsChecked)
        {
            bagagePrice.Text = "30";
            total += 30;
            Total.Text = total.ToString();
            this.extraBagage = 10;
        }
        else
        {
            bagagePrice.Text = "0";
            total -= 30;
            Total.Text = total.ToString();
            this.extraBagage = 00;
        }
    }

    public void addVacation()
    {
        Vacation vacation = new Vacation(0, this.hotel, this.flight, this.flight, this.numberOfPersons, this.flight.departureDate, this.flight.arrivalDate, this.extraBagage);
        //Wesley, this Vacation must be send to the api to create in the database
    }

    async void OnBookVacationButtonClicked ( object sender, EventArgs e )
    {
        addVacation ( );
        await Navigation.PushAsync ( new GetTicket ( ) );
    }
}