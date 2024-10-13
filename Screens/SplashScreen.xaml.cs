namespace MauiApp1.Screens;

public partial class SplashScreen : ContentPage
{
	public SplashScreen()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Delay for 3 seconds (3000 milliseconds)
        await Task.Delay(3000);

        // Navigate to the main page (DisplayCards in your case)
        Application.Current.MainPage = new NavigationPage(new NavigationDrawer());
    }
}