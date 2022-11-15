

namespace Boekingssysteem;

public partial class FindVacation : ContentPage
{
    Hotel hotelRadio;
    Flight flightRadio;
    Flight flightBackRadio;
    int numberOfPeople;
    public FindVacation ( DateTime startDate, DateTime endDate, string location, int numberOfPeople )
    {
        this.numberOfPeople = numberOfPeople;
        InitializeComponent ( );
        pageLayout ( );
        addHotels ( location, numberOfPeople );
        addFlights ( location, startDate, endDate );
        }

    private void pageLayout()
    {
        Label seeMap = FindByName("seeMap") as Label;
        var seeMapClick = new TapGestureRecognizer();
        seeMapClick.Tapped += async (sender, e) =>
        {
            NavigateToBuilding25 ( );
        };
        seeMap.GestureRecognizers.Add(seeMapClick);

        Label Back = FindByName("Back") as Label;
        var BackClick = new TapGestureRecognizer();
        BackClick.Tapped += async (sender, e) =>
        {
            await Navigation.PopAsync();
        };
        Back.GestureRecognizers.Add(BackClick);
    }

    private async void addHotels(String location, int numberOfPeople)
    {
        //Get all hotels in certain city from apiCaller and add them to menu
        ApiCaller apiCaller = new ApiCaller();
        List<Hotel> hotels = await apiCaller.GetAllHotelsByCity(location);

        bool firstVlag = true;//This is used to preset only one radiobutton
        foreach (var hotel in hotels)
        {
            if (firstVlag)
                hotelRadio = hotel;
            Hotels.Add(hotelBuilder(hotel, firstVlag, hotel.name, hotel.city, (hotel.room.pricePerNightPerPerson * numberOfPeople)));
            firstVlag = false;
        }
    }

    private Grid hotelBuilder(Hotel hotel, bool first, string name, string city, double pricePerNight)
    {
        //This will build the frontend of the hotel selector menu
        Grid grid = new Grid();

        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

        RadioButton rB = new RadioButton
        {
            Value = hotel,
            Content = name,
            GroupName = "Hotelsr",
            TextColor = Color.FromHex("A4765E"),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            IsChecked = first,//For some reason, this doesn't work
            HorizontalOptions = LayoutOptions.Start
        };
        rB.CheckedChanged += hotelRadioChanged;
        grid.Children.Add( rB );

        Label labelLocation = new Label
        {
            Text = city,
            FontAttributes = FontAttributes.Italic,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(labelLocation);
        Grid.SetColumn(labelLocation, 1);

        Label labelPrice = new Label
        {
            Text = pricePerNight.ToString(),
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(labelPrice);
        Grid.SetColumn(labelPrice, 2);

        return grid;
    }

    private async void addFlights(String location, DateTime departureDate, DateTime arrivalDate)
    {
        ApiCaller apiCaller = new ApiCaller();
        List<Flight> flights = await apiCaller.GetAllFlightsToCity(location);

        bool firstVlag = true;
        foreach (var flight in flights)
        {
            if (flight.arrivalDate >= arrivalDate && flight.arrivalDate < arrivalDate.AddDays(1) && flight.departurePlace == "Emmen")//Since DateTime also stores time, this will select all flights for the next 24h
            {
                if (firstVlag)
                    flightRadio = flight;
                Flights.Add(flightBuilder(firstVlag, flight.plane.airline, flight.departureDate, flight.arrivalDate, flight.price));
                firstVlag = false;
            } 
        }

        flights = await apiCaller.GetAllFlightsToCity("Emmen");//For now we only dilever vacations from Emmen, this might be changed in the future

        firstVlag = true;
        foreach (var flight in flights)
        {
            if (flight.departureDate >= departureDate && flight.departureDate < departureDate.AddDays(1) && flight.departurePlace == location)//Since DateTime also stores time, this will select all flights for the next 24h
            {
                if (firstVlag)
                    flightBackRadio = flight;
                FlightsBack.Add(flightBackBuilder(firstVlag, flight.plane.airline, flight.departureDate, flight.arrivalDate, flight.price));
                firstVlag = false;
            }
        }
    }

    private Grid flightBuilder(bool first, String airline, DateTime toDate, DateTime froDate, double priceFlight)
    {
        Grid grid = new Grid();

        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

        RadioButton rB = new RadioButton
        {
            Content = airline,
            GroupName = "Flightsr",
            TextColor = Color.FromHex("A4765E"),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            IsChecked = first,
            HorizontalOptions = LayoutOptions.Start
        };
        rB.CheckedChanged += flightRadioChanged;
        grid.Children.Add(rB);

        Label toFlight = new Label
        {
            Text = toDate.ToString(),
            FontAttributes = FontAttributes.Italic,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(toFlight);
        Grid.SetColumn(toFlight, 1);

        Label froFlight = new Label
        {
            Text = froDate.ToString(),
            FontAttributes = FontAttributes.Italic,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(froFlight);
        Grid.SetColumn(froFlight, 2);

        Label price = new Label
        {
            Text = priceFlight.ToString(),
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(price);
        Grid.SetColumn(price, 3);

        return grid;
    }

    private Grid flightBackBuilder(bool first, String airline, DateTime toDate, DateTime froDate, double priceFlight)
    {
        Grid grid = new Grid();

        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

        RadioButton rB = new RadioButton
        {
            Content = airline,
            GroupName = "Flightsr",
            TextColor = Color.FromHex("A4765E"),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            IsChecked = first,
            HorizontalOptions = LayoutOptions.Start
        };
        rB.CheckedChanged += flightBackRadioChanged;
        grid.Children.Add(rB);

        Label toFlight = new Label
        {
            Text = toDate.ToString(),
            FontAttributes = FontAttributes.Italic,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(toFlight);
        Grid.SetColumn(toFlight, 1);

        Label froFlight = new Label
        {
            Text = froDate.ToString(),
            FontAttributes = FontAttributes.Italic,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(froFlight);
        Grid.SetColumn(froFlight, 2);

        Label price = new Label
        {
            Text = priceFlight.ToString(),
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(price);
        Grid.SetColumn(price, 3);

        return grid;
    }


    void hotelRadioChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        Hotel hotel = (Hotel)rb.Value;
        hotelRadio = hotel;
    }

    void flightRadioChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        Flight flight = (Flight)rb.Value;
        flightRadio = flight;
    }

    void flightBackRadioChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        Flight flight = (Flight)rb.Value;
        flightBackRadio = flight;
    }

    public async Task NavigateToBuilding25 ( )
        //TODO: See if there's another option. 
        {
        var location = new Location(47.645160, -122.1306032);
        var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

        try
            {
            await Map.Default.OpenAsync ( location, options );
            }
        catch ( Exception ex )
            {
            // No map application available to open
            }
        }

    async void OnGoOnButtonClicked ( object sender, EventArgs e )
    {
         await Navigation.PushAsync ( new BookVacation  (hotelRadio, numberOfPeople, flightRadio, flightBackRadio) );
    }
}