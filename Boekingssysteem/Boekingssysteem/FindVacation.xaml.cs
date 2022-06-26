

namespace Boekingssysteem;

public partial class FindVacation : ContentPage
    {
    public FindVacation (DateTime startDate, DateTime endDate, string location, int numberOfPeople)
     {
        InitializeComponent ( );
        pageLayout();
        addHotels(location);
        addFlights(location, startDate, endDate);
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

    private void addHotels(String location)
    {
        Hotel[] hotels = getAllHotels();
        List<Hotel> hotelsInLocation = new List<Hotel>();
        for (int i = 0; i < hotels.Length; i++)
        {
            if (hotels[i].city == location)
            {
                hotelsInLocation.Add(hotels[i]);
            }
        }

        bool firstVlag = true;//This is used to set only one radiobutton
        foreach (var i in hotelsInLocation)
        {
            Hotels.Add(hotelBuilder(firstVlag, i.name, i.city));
            firstVlag = false;
        }
    }

    private Grid hotelBuilder(bool first, string name, string city)
    {
        Grid grid = new Grid();

        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

        grid.Children.Add(new RadioButton
        {
            Content = name,
            GroupName = "Hotels",
            TextColor = Color.FromHex("A4765E"),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            IsChecked = first,
            HorizontalOptions = LayoutOptions.Start
        });

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
            Text = "Prijs per nacht",
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(labelPrice);
        Grid.SetColumn(labelPrice, 2);

        return grid;
    }

    private Hotel[] getAllHotels()
    {
        //Deze funtie is tijdelijk, het moet vervangen worden door de apicaller van Wesley
        Hotel[] hotels = new Hotel[7];
        hotels[0] = new Hotel("Plaza", "New York", 0, 0, new List<Room> { });
        hotels[1] = new Hotel("Van Der Valk", "Nieuw Amsterdam", 0, 0, new List<Room> { });
        hotels[2] = new Hotel("Hilton", "Chicago", 0, 0, new List<Room> { });
        hotels[3] = new Hotel("Overlook", "Colorado", 0, 0, new List<Room> { });
        hotels[4] = new Hotel("Ceasars Palace", "Las Vegas", 0, 0, new List<Room> { });
        hotels[5] = new Hotel("Ritz", "Parijs", 0, 0, new List<Room> { });
        hotels[6] = new Hotel("Hilton", "New York", 0, 0, new List<Room> { });
        return hotels;
    }

    private void addFlights(String location, DateTime departureDate, DateTime arrivalDate)
    {
        Flight[] flights = getAllFlighs();
        List<Flight> flightToRightLocationsAtRightTimes = new List<Flight>();
        for (int i = 0; i < flights.Length; i++)
        {
            if (flights[i].destination == location && flights[i].departureDate == departureDate && flights[i].arrivalDate == arrivalDate)
            {
                flightToRightLocationsAtRightTimes.Add(flights[i]);
            }
        }

        bool firstVlag = true;
        foreach (var flight in flightToRightLocationsAtRightTimes)
        {
            Flights.Add(flightBuilder(firstVlag, flight.plane.airline, flight.departureDate, flight.arrivalDate));
            firstVlag = false;
        }
    }

    private Grid flightBuilder(bool first, String airline, DateTime toDate, DateTime froDate)
    {
        Grid grid = new Grid();

        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

        grid.Children.Add(new RadioButton
        {
            Content = airline,
            GroupName = "Flights",
            TextColor = Color.FromHex("A4765E"),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            IsChecked = first,
            HorizontalOptions = LayoutOptions.Start
        });

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
            Text = "Prijs",
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Center
        };
        grid.Children.Add(price);
        Grid.SetColumn(price, 3);

        return grid;
    }

    private Flight[] getAllFlighs()
    {
        Flight[] flights = new Flight[5];
        flights[0] = new Flight(1, new Plane(1, "Emerates", 12, 12), 55, "Emmen", new DateTime(2022, 7, 25), "New York", new DateTime(2022, 7, 27), 1);
        flights[1] = new Flight(2, new Plane(1, "Lufthanza", 12, 12), 55, "Emmen", new DateTime(2022, 7, 20), "Tweede exloermond", new DateTime(2022, 7, 27), 1);
        flights[2] = new Flight(2, new Plane(1, "Turkey", 12, 12), 55, "Emmen", new DateTime(2022, 7, 7), "Milaan", new DateTime(2022, 7, 27), 1);
        flights[3] = new Flight(2, new Plane(1, "Klm", 12, 12), 55, "Emmen", new DateTime(2022, 7, 2), "Nieuw Schoonebeek City", new DateTime(2022, 7, 25), 1);
        flights[4] = new Flight(2, new Plane(1, "Pan Am", 12, 12), 55, "Emmen", new DateTime(2022, 7, 7), "Mariemberg", new DateTime(2022, 7, 27), 1);
        return flights;
    }

    async void OnGoOnButtonClicked ( object sender, EventArgs e )
        {
        await Navigation.PushAsync ( new BookVacation ( ) );
        }
    }