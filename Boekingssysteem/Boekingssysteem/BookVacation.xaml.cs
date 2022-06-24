namespace Boekingssysteem;

public partial class BookVacation : ContentPage
{
	public BookVacation()
	{
		InitializeComponent();
	}
    async void OnBookVacationButtonClicked ( object sender, EventArgs e )
        {
        await Navigation.PushAsync ( new GetTicket ( ) );
        }
    }