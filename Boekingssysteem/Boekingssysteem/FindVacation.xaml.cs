

namespace Boekingssysteem;

public partial class FindVacation : ContentPage
{
    Hotel hotelRadio;
    Flight flightRadio;
    int numberOfPeople;
    public FindVacation (DateTime startDate, DateTime endDate, string location, int numberOfPeople)
    {
        this.numberOfPeople = numberOfPeople;
        InitializeComponent ( );
        pageLayout();
        addHotels ( location, numberOfPeople );
        addFlights ( location, startDate, endDate );
        }

    private void pageLayout()
    {
        Label seeMap = FindByName("seeMap") as Label;
        var seeMapClick = new TapGestureRecognizer();
        seeMapClick.Tapped += async (sender, e) =>
        {
            await Navigation.PushAsync(new HotelsMap());
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
        //Flight[] flights = getAllFlighs();
        List<Flight> flights = await getAllFlighs();
        List<Flight> flightToRightLocationsAtRightTimes = new List<Flight>();
        for (int i = 0; i < flights.Count; i++)
        {
            if (flights[i].destination == location && flights[i].departureDate == departureDate && flights[i].arrivalDate == arrivalDate)
                flightToRightLocationsAtRightTimes.Add(flights[i]);
        }

        bool firstVlag = true;
        foreach (var flight in flightToRightLocationsAtRightTimes)
        {
            if (firstVlag)
                flightRadio = flight;
            Flights.Add(flightBuilder(firstVlag, flight.plane.airline, flight.departureDate, flight.arrivalDate, flight.price));
            firstVlag = false;
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

    private async Task<List<Flight>> getAllFlighs()
    {
        //Flight[]
        //Flight[] flights = new Flight[5];

        ApiCaller apiCaller = new ApiCaller();
        List<Flight> flights = await apiCaller.GetAllFlights();
        var x = 3;
        //flights[0] = new Flight(1, new Plane(1, "Emerates", 12, 12), 55, "Emmen", new DateTime(2022, 7, 25), "New York", new DateTime(2022, 7, 27), 1);
        //flights[1] = new Flight(2, new Plane(1, "Lufthanza", 12, 12), 55, "Emmen", new DateTime(2022, 7, 20), "Tweede exloermond", new DateTime(2022, 7, 27), 1);
        //flights[2] = new Flight(2, new Plane(1, "Turkey", 12, 12), 55, "Emmen", new DateTime(2022, 7, 7), "Milaan", new DateTime(2022, 7, 27), 1);
        //flights[3] = new Flight(2, new Plane(1, "Klm", 12, 12), 55, "Emmen", new DateTime(2022, 7, 2), "Nieuw Schoonebeek City", new DateTime(2022, 7, 25), 1);
        //flights[4] = new Flight(2, new Plane(1, "Pan Am", 12, 12), 55, "Emmen", new DateTime(2022, 7, 7), "Mariemberg", new DateTime(2022, 7, 27), 1);
        return flights;
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

    async void OnGoOnButtonClicked ( object sender, EventArgs e )
        {
            await Navigation.PushAsync ( new BookVacation  (hotelRadio, numberOfPeople, flightRadio) );
        }
    }