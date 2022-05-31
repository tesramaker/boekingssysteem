namespace Boekingssysteem;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnSearchButtonClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
            SearchBtn.Text = $"Clicked {count} time";
		else
            SearchBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(SearchBtn.Text);
	}
}

