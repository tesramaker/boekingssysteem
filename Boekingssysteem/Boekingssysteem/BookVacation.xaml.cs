using Boekingssysteem.ApiModels;

namespace Boekingssysteem;

public partial class BookVacation : ContentPage
{
    double total;
    Hotel hotel;
    Flight flight;
    int numberOfPersons;
    int extraBagage;
    private ApiCaller apiCaller = new ApiCaller();

    internal BookVacation( Hotel hotel, int numberOfPersons, Flight flight, Flight flightBack)
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
        addContentToPage ( hotel, numberOfPersons, flight, flightBack );
        }

    internal void addContentToPage(Hotel hotel, int numberOfPersons, Flight flight, Flight flightBack)
    {
        Hotel.Text = hotel.name;
        Location.Text = hotel.city;
        PriceHotel.Text = (hotel.rooms[0].pricePerNightPerPerson * numberOfPersons).ToString();

        AirlineToFlight.Text = flight.plane.airline;
        DeparturetimeToFlight.Text = flight.departureDate.ToString();
        LandingtimeToFlight.Text = flight.arrivalDate.ToString();
        PriceToflight.Text = (flight.price * numberOfPersons).ToString();

        AirlineBackFlight.Text = flightBack.plane.airline;
        DeparturetimeBackFlight.Text = flightBack.departureDate.ToString();
        LandingtimeBackFlight.Text = flightBack.arrivalDate.ToString();
        PriceBackflight.Text = (flightBack.price * numberOfPersons).ToString();

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

    public async void addVacation()
    {
        //TODO : This needs to be changed, it uses the same flight for both flights
        Vacation vacation = new Vacation(0, this.hotel, this.flight, this.flight, this.numberOfPersons, this.flight.departureDate, this.flight.arrivalDate, this.extraBagage);
        VacationApiModel vacationApiModel = new(this.hotel.id, this.flight.id, this.flight.id, this.numberOfPersons, this.flight.departureDate, this.flight.arrivalDate, this.extraBagage, 1);
        //Wesley, this Vacation must be send to the api to create in the database
        //Daniel, Alstublieft -Arjan
        //Arjan, deze code werkt niet, die id's bestaan helemaal niet
        //Is al klaar gemaakt
        await apiCaller.CreateVacation(vacationApiModel);
    }

    async void OnBookVacationButtonClicked ( object sender, EventArgs e )
    {
        addVacation ( );
        await Navigation.PushAsync ( new GetTicket ( ) );
    }
}