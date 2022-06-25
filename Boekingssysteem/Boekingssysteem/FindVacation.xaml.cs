

namespace Boekingssysteem;

public partial class FindVacation : ContentPage
    {
    public FindVacation (DateTime startDate, DateTime endDate, string location, int numberOfPeople)
     {
        InitializeComponent ( );
        pageLayout();
        addHotels(location);
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
        Hotel[] hotel = getAllHotels();
        List<Hotel> hotelsInLocation = new List<Hotel>();
        for (int i = 0; i < hotel.Length; i++)
        {
            bool vlag = false;
            if (hotel[i].city == location)
            {
                vlag = true;
                hotelsInLocation.Add(hotel[i]);
            }
        }

        var allHotels = "";
        foreach (var i in hotelsInLocation)
        {
            Hotels.Add(hotelBuilder(i.name, i.city));
        }

    }

    private Grid hotelBuilder(string name, string city)
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
            IsChecked = true,
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

    async void OnGoOnButtonClicked ( object sender, EventArgs e )
        {
        await Navigation.PushAsync ( new BookVacation ( ) );
        }
    }