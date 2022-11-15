namespace Boekingssysteem;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    async void OnLoginButtonClicked ( object sender, EventArgs e )
        {
        try
            {
            // do something
            }
        catch
            {
            await DisplayAlert ( "Kan niet doorgaan", "Vul alle velden in.", "OK" );
            }
        }
}