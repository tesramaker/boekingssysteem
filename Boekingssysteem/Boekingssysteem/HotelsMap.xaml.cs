namespace Boekingssysteem;

public partial class HotelsMap : ContentPage
    {
    public HotelsMap ( )
        {
        InitializeComponent ( );

        Label GoBack = FindByName("GoBack") as Label;
        var GoBackClick = new TapGestureRecognizer ( );
        GoBackClick.Tapped += async ( sender, e ) =>
        {
            await Navigation.PopAsync ( );
        };
        GoBack.GestureRecognizers.Add ( GoBackClick );
        }
    }