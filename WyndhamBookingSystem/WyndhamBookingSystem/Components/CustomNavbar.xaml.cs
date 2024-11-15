using WyndhamBookingSystem.Views;

namespace WyndhamBookingSystem.Components;

public partial class CustomNavbar : ContentView
{
	public CustomNavbar()
	{
		InitializeComponent();
	}

    private async void OnGoToSearchClicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.LastOrDefault() is ReservarPage)
        {
            return;
        }
        await ShowWithFadeEffect(new ReservarPage());
    }

    private async void OnGoToMenuClicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.LastOrDefault() is MainMenuPage)
        {
            return;
        }
        await ShowWithFadeEffect(new MainMenuPage());
    }


    private async Task ShowWithFadeEffect(Page page)
    {
        page.Opacity = 0; 
        await Navigation.PushAsync(page, animated: false);
        await Task.Delay(5);
        await page.FadeTo(1, 130);
    }
}