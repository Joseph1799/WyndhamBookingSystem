namespace WyndhamBookingSystem.Views
{
    public partial class MainMenuPage : ContentPage
    {

        public MainMenuPage()
        {
            InitializeComponent();
        }

        private async void OnGoToLoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

    }

}
