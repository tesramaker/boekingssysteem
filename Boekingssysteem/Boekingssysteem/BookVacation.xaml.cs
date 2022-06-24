namespace Boekingssysteem;

public partial class BookVacation : ContentPage
    {
    public BookVacation ( )
        {
        InitializeComponent ( );

        Label Back = FindByName("Back") as Label;
        var BackClick = new TapGestureRecognizer ( );
        BackClick.Tapped += async ( sender, e ) =>
        {
            await Navigation.PopAsync ( );
        };
        Back.GestureRecognizers.Add ( BackClick );
        }
    async void OnBookVacationButtonClicked ( object sender, EventArgs e )
        {
        await Navigation.PushAsync ( new GetTicket ( ) );
        }
    }