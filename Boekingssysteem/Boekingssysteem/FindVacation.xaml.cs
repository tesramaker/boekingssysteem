namespace Boekingssysteem;

public partial class FindVacation : ContentPage
    {
    public FindVacation ( )
        {
        InitializeComponent ( );
        Label seeMap = FindByName("seeMap") as Label;
        var seeMapClick = new TapGestureRecognizer ( );
        seeMapClick.Tapped += async ( sender, e ) =>
        {
            await Navigation.PushAsync ( new HotelsMap ( ) );
        };
        seeMap.GestureRecognizers.Add ( seeMapClick );
        }

    async void OnGoOnButtonClicked ( object sender, EventArgs e )
        {
        await Navigation.PushAsync ( new BookVacation ( ) );
        }
    }